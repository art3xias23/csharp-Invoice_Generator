namespace WinForms.Invoice.Generator
{
    partial class InvoiceCurrency
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrency.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrency.Location = new System.Drawing.Point(227, 35);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(89, 28);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(22, 94);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(511, 23);
            this.cmbCurrency.TabIndex = 1;
            // 
            // InvoiceCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Name = "InvoiceCurrency";
            this.Size = new System.Drawing.Size(547, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCurrency;
        private ComboBox cmbCurrency;
    }
}
