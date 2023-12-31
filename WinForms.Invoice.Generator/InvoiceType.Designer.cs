﻿namespace WinForms.Invoice.Generator
{
    partial class InvoiceType
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.txtDocTypeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the type of invoice you will be creating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDocType.ForeColor = System.Drawing.Color.Blue;
            this.lblDocType.Location = new System.Drawing.Point(117, 122);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(52, 21);
            this.lblDocType.TabIndex = 2;
            this.lblDocType.Text = "label2";
            this.lblDocType.Visible = false;
            // 
            // txtDocTypeId
            // 
            this.txtDocTypeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDocTypeId.Location = new System.Drawing.Point(239, 114);
            this.txtDocTypeId.Name = "txtDocTypeId";
            this.txtDocTypeId.Size = new System.Drawing.Size(149, 29);
            this.txtDocTypeId.TabIndex = 3;
            this.txtDocTypeId.Visible = false;
            // 
            // InvoiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDocTypeId);
            this.Controls.Add(this.lblDocType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceType";
            this.Size = new System.Drawing.Size(547, 294);
            this.VisibleChanged += new System.EventHandler(this.InvoiceType_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label lblDocType;
        private TextBox txtDocTypeId;
    }
}
