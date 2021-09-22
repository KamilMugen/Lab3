
namespace Lab3
{
    partial class Rates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GetRatesFromBank = new System.Windows.Forms.Button();
            this.RatesGridView = new System.Windows.Forms.DataGridView();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetRatesFromBank
            // 
            this.GetRatesFromBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetRatesFromBank.Cursor = System.Windows.Forms.Cursors.Default;
            this.GetRatesFromBank.Location = new System.Drawing.Point(39, 30);
            this.GetRatesFromBank.Name = "GetRatesFromBank";
            this.GetRatesFromBank.Size = new System.Drawing.Size(180, 46);
            this.GetRatesFromBank.TabIndex = 0;
            this.GetRatesFromBank.Text = "Get rates from a bank";
            this.GetRatesFromBank.UseVisualStyleBackColor = true;
            this.GetRatesFromBank.Click += new System.EventHandler(this.GetRatesFromBank_Click);
            // 
            // RatesGridView
            // 
            this.RatesGridView.AllowUserToAddRows = false;
            this.RatesGridView.AllowUserToDeleteRows = false;
            this.RatesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RatesGridView.AutoGenerateColumns = false;
            this.RatesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RatesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.buyingRateDataGridViewTextBoxColumn,
            this.sellingRateDataGridViewTextBoxColumn});
            this.RatesGridView.DataSource = this.rateBindingSource;
            this.RatesGridView.Location = new System.Drawing.Point(39, 97);
            this.RatesGridView.Name = "RatesGridView";
            this.RatesGridView.ReadOnly = true;
            this.RatesGridView.Size = new System.Drawing.Size(281, 341);
            this.RatesGridView.TabIndex = 1;
            // 
            // labelCurrency
            // 
            this.labelCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(540, 63);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(49, 13);
            this.labelCurrency.TabIndex = 2;
            this.labelCurrency.Text = "Currency";
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(543, 122);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount";
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(546, 258);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Value";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(634, 55);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCurrency.TabIndex = 5;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(634, 114);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(115, 20);
            this.numericUpDownAmount.TabIndex = 6;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownValue.Location = new System.Drawing.Point(634, 258);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(115, 20);
            this.numericUpDownValue.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Location = new System.Drawing.Point(549, 174);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(206, 36);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyingRateDataGridViewTextBoxColumn
            // 
            this.buyingRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyingRateDataGridViewTextBoxColumn.DataPropertyName = "BuyingRate";
            this.buyingRateDataGridViewTextBoxColumn.HeaderText = "BuyingRate";
            this.buyingRateDataGridViewTextBoxColumn.Name = "buyingRateDataGridViewTextBoxColumn";
            this.buyingRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingRateDataGridViewTextBoxColumn
            // 
            this.sellingRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellingRateDataGridViewTextBoxColumn.DataPropertyName = "SellingRate";
            this.sellingRateDataGridViewTextBoxColumn.HeaderText = "SellingRate";
            this.sellingRateDataGridViewTextBoxColumn.Name = "sellingRateDataGridViewTextBoxColumn";
            this.sellingRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataSource = typeof(Lab3.Model.Rate);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(549, 380);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(206, 35);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.RatesGridView);
            this.Controls.Add(this.GetRatesFromBank);
            this.Name = "Rates";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RatesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetRatesFromBank;
        private System.Windows.Forms.DataGridView RatesGridView;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button buttonEdit;
    }
}