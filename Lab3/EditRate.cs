using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Model;

namespace Lab3
{
    public partial class EditRate : Form
    {
        internal event Action<Rate> SavedRate;
        private readonly string currency;
        internal EditRate(Rate rate)
        {
            InitializeComponent();
            numericUpDownBuyingRate.DecimalPlaces = 2;
            numericUpDownSellingRate.DecimalPlaces = 2;

            currency = rate.Code;
            numericUpDownBuyingRate.Value = rate.BuyingRate;
            numericUpDownSellingRate.Value = rate.SellingRate;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SavedRate != null)
            {
                var rate = new Rate()
                {
                    Code = currency,
                    BuyingRate = numericUpDownBuyingRate.Value,
                    SellingRate = numericUpDownSellingRate.Value
                };
                SavedRate.Invoke(rate);
            }
            Close();
        }
    }
}
