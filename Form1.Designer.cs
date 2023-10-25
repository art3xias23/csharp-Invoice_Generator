namespace WinForms.Invoice.Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pbLeft2 = new System.Windows.Forms.PictureBox();
            this.pbRight2 = new System.Windows.Forms.PictureBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(595, 352);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pictureBox2);
            this.pnlControls.Controls.Add(this.pictureBox1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 412);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(595, 60);
            this.pnlControls.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinForms.Invoice.Generator.Resource1.right_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(351, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Invoice.Generator.Resource1.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(85, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(595, 60);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(219, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Invoice Creator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbRight2);
            this.panel2.Controls.Add(this.pbLeft2);
            this.panel2.Location = new System.Drawing.Point(-1, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 52);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-1, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 356);
            this.panel3.TabIndex = 2;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(597, 52);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Invoice Generator";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbLeft2
            // 
            this.pbLeft2.Image = global::WinForms.Invoice.Generator.Resource1.left_arrow;
            this.pbLeft2.Location = new System.Drawing.Point(97, 3);
            this.pbLeft2.Name = "pbLeft2";
            this.pbLeft2.Size = new System.Drawing.Size(143, 46);
            this.pbLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft2.TabIndex = 0;
            this.pbLeft2.TabStop = false;
            // 
            // pbRight2
            // 
            this.pbRight2.Image = global::WinForms.Invoice.Generator.Resource1.right_arrow;
            this.pbRight2.Location = new System.Drawing.Point(337, 3);
            this.pbRight2.Name = "pbRight2";
            this.pbRight2.Size = new System.Drawing.Size(143, 46);
            this.pbRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight2.TabIndex = 1;
            this.pbRight2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlControls;
        private Panel pnlTitle;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlTitle1;
        private Panel pnlNavigation1;
        private Panel pnlMain1;
        private Label label1;
        private PictureBox pbRight;
        private PictureBox pbLeft;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblTitle2;
        private PictureBox pbRight2;
        private PictureBox pbLeft2;
    }
}