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
            this.nudPaymentPerHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHoursPerDay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentPerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrency.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrency.Location = new System.Drawing.Point(159, 35);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(55, 15);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(275, 31);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(160, 23);
            this.cmbCurrency.TabIndex = 1;
            // 
            // nudPaymentPerHour
            // 
            this.nudPaymentPerHour.Location = new System.Drawing.Point(275, 79);
            this.nudPaymentPerHour.Name = "nudPaymentPerHour";
            this.nudPaymentPerHour.Size = new System.Drawing.Size(160, 23);
            this.nudPaymentPerHour.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(159, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payment Per Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(159, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hours Per Day";
            // 
            // nudHoursPerDay
            // 
            this.nudHoursPerDay.DecimalPlaces = 1;
            this.nudHoursPerDay.Location = new System.Drawing.Point(275, 126);
            this.nudHoursPerDay.Name = "nudHoursPerDay";
            this.nudHoursPerDay.Size = new System.Drawing.Size(160, 23);
            this.nudHoursPerDay.TabIndex = 4;
            // 
            // InvoiceCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudHoursPerDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPaymentPerHour);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Name = "InvoiceCurrency";
            this.Size = new System.Drawing.Size(547, 294);
            this.Load += new System.EventHandler(this.InvoiceCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentPerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCurrency;
        private ComboBox cmbCurrency;
        private NumericUpDown nudPaymentPerHour;
        private Label label1;
        private Label label2;
        private NumericUpDown nudHoursPerDay;
    }
}
