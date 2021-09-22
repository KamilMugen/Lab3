
namespace Lab3
{
    partial class EditRate
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
            this.labelBuying = new System.Windows.Forms.Label();
            this.labelSelling = new System.Windows.Forms.Label();
            this.numericUpDownBuyingRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSellingRate = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingRate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuying
            // 
            this.labelBuying.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBuying.AutoSize = true;
            this.labelBuying.Location = new System.Drawing.Point(86, 88);
            this.labelBuying.Name = "labelBuying";
            this.labelBuying.Size = new System.Drawing.Size(65, 13);
            this.labelBuying.TabIndex = 0;
            this.labelBuying.Text = "Buying Rate";
            // 
            // labelSelling
            // 
            this.labelSelling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelling.AutoSize = true;
            this.labelSelling.Location = new System.Drawing.Point(89, 162);
            this.labelSelling.Name = "labelSelling";
            this.labelSelling.Size = new System.Drawing.Size(64, 13);
            this.labelSelling.TabIndex = 1;
            this.labelSelling.Text = "Selling Rate";
            // 
            // numericUpDownBuyingRate
            // 
            this.numericUpDownBuyingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBuyingRate.Location = new System.Drawing.Point(273, 80);
            this.numericUpDownBuyingRate.Name = "numericUpDownBuyingRate";
            this.numericUpDownBuyingRate.Size = new System.Drawing.Size(111, 20);
            this.numericUpDownBuyingRate.TabIndex = 2;
            // 
            // numericUpDownSellingRate
            // 
            this.numericUpDownSellingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSellingRate.Location = new System.Drawing.Point(273, 154);
            this.numericUpDownSellingRate.Name = "numericUpDownSellingRate";
            this.numericUpDownSellingRate.Size = new System.Drawing.Size(111, 20);
            this.numericUpDownSellingRate.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(89, 228);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(295, 49);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 393);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownSellingRate);
            this.Controls.Add(this.numericUpDownBuyingRate);
            this.Controls.Add(this.labelSelling);
            this.Controls.Add(this.labelBuying);
            this.Name = "EditRate";
            this.Text = "EditRate";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSellingRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuying;
        private System.Windows.Forms.Label labelSelling;
        private System.Windows.Forms.NumericUpDown numericUpDownBuyingRate;
        private System.Windows.Forms.NumericUpDown numericUpDownSellingRate;
        private System.Windows.Forms.Button buttonSave;
    }
}