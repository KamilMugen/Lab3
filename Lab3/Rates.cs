using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Lab3.Model;

namespace Lab3
{
    public partial class Rates : Form
    {
        private List<Rate> rateList;
        public Rates()
        {
            InitializeComponent();
        }

        private void GetRatesFromBank_Click(object sender, EventArgs e)
        {
            rateList = GetCourses();
            RatesGridView.DataSource = rateList;

            comboBoxCurrency.BindingContext = new BindingContext();

            comboBoxCurrency.DataSource = rateList;
            comboBoxCurrency.DisplayMember = "Code";
            comboBoxCurrency.ValueMember = "BuyingRate";
            numericUpDownAmount.Minimum = 1;
            numericUpDownAmount.Maximum = 1000;
            numericUpDownValue.Minimum = 0;
            numericUpDownValue.Maximum = 10 * 100 * 1000;
            numericUpDownValue.DecimalPlaces = 2;

            calculateExchange();
        }
        private void calculateExchange()
        {
            var gridRowView = RatesGridView.CurrentRow;
            var row = (Rate)gridRowView.DataBoundItem;
            Rate currentRate = (Rate)comboBoxCurrency.SelectedItem;
            decimal exchange = 0;

            if (row.Code == currentRate.Code)
            {
                decimal currentValue = (decimal)comboBoxCurrency.SelectedValue;
                decimal amout = numericUpDownAmount.Value;
                exchange = currentValue * currentRate.Units * amout;
            }
            else
            {
                exchange = row.BuyingRate / (currentRate.BuyingRate);

            }
            numericUpDownValue.Value = exchange;
        }

        private List<Rate> GetCourses()
        {
            var lst = new List<Rate>();
            var webClient = new System.Net.WebClient();
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                var courses = webClient.DownloadString("http://www.nbp.pl/kursy/xml/LastC.xml");
                xmlDoc.LoadXml(courses);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error occured during processing: {ex.Message}",
                                    "Currency calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Rate>();
            }

            foreach(XmlNode position in xmlDoc.GetElementsByTagName("pozycja"))
            {
                if(position is XmlElement element)
                {
                    Rate rate = new Rate();
                    var childElem = element.GetElementsByTagName("nazwa_waluty");
                    rate.Name = childElem[0].InnerText;

                    childElem = element.GetElementsByTagName("kod_waluty");
                    rate.Code = childElem[0].InnerText;

                    childElem = element.GetElementsByTagName("przelicznik");
                    rate.Units = decimal.Parse(childElem[0].InnerText);

                    childElem = element.GetElementsByTagName("kurs_kupna");
                    rate.BuyingRate = decimal.Parse(childElem[0].InnerText);

                    childElem = element.GetElementsByTagName("kurs_sprzedazy");
                    rate.SellingRate = decimal.Parse(childElem[0].InnerText);

                    lst.Add(rate);
                }

            }
            return lst;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (comboBoxCurrency.DataSource != null)
                calculateExchange();
            else
                MessageBox.Show("First click on \"Gate rates from a Bank\" button", "Wrong operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (RatesGridView.CurrentRow == null)
            {
                MessageBox.Show("First click on \"Gate rates from a Bank\" button", "Wrong operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var gridRowView = RatesGridView.CurrentRow;
            var row = (Rate)gridRowView.DataBoundItem;

            EditRate editRate = new EditRate(row);
            editRate.SavedRate += EditRate_SavedRate;
            editRate.Show();
        }

        private void EditRate_SavedRate(Rate newRate)
        {
            var rate = rateList.Find(x => x.Code == newRate.Code);

            rate.BuyingRate = newRate.BuyingRate;
            rate.SellingRate = newRate.SellingRate;

            RatesGridView.Update();
            RatesGridView.Refresh();
        }
    }
}
