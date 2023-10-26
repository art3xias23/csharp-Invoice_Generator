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
            this.pnlTitle2 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pnlNavigation2 = new System.Windows.Forms.Panel();
            this.pbRight2 = new System.Windows.Forms.PictureBox();
            this.pbLeft3 = new System.Windows.Forms.PictureBox();
            this.pnlMain2 = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlTitle2.SuspendLayout();
            this.pnlNavigation2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft3)).BeginInit();
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
            // pnlTitle2
            // 
            this.pnlTitle2.Controls.Add(this.lblTitle2);
            this.pnlTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle2.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle2.Name = "pnlTitle2";
            this.pnlTitle2.Size = new System.Drawing.Size(595, 52);
            this.pnlTitle2.TabIndex = 0;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle2.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(595, 52);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Invoice Generator";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlNavigation2
            // 
            this.pnlNavigation2.Controls.Add(this.pbRight2);
            this.pnlNavigation2.Controls.Add(this.pbLeft3);
            this.pnlNavigation2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation2.Location = new System.Drawing.Point(0, 408);
            this.pnlNavigation2.Name = "pnlNavigation2";
            this.pnlNavigation2.Size = new System.Drawing.Size(595, 52);
            this.pnlNavigation2.TabIndex = 1;
            // 
            // pbRight2
            // 
            this.pbRight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRight2.Image = global::WinForms.Invoice.Generator.Resource1.right_arrow;
            this.pbRight2.Location = new System.Drawing.Point(449, 0);
            this.pbRight2.Name = "pbRight2";
            this.pbRight2.Size = new System.Drawing.Size(143, 46);
            this.pbRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight2.TabIndex = 1;
            this.pbRight2.TabStop = false;
            this.pbRight2.Click += new System.EventHandler(this.pbRight2_Click);
            // 
            // pbLeft3
            // 
            this.pbLeft3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLeft3.Image = global::WinForms.Invoice.Generator.Resource1.left_arrow;
            this.pbLeft3.Location = new System.Drawing.Point(3, 0);
            this.pbLeft3.Name = "pbLeft3";
            this.pbLeft3.Size = new System.Drawing.Size(143, 46);
            this.pbLeft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft3.TabIndex = 0;
            this.pbLeft3.TabStop = false;
            this.pbLeft3.Click += new System.EventHandler(this.pbLeft2_Click);
            // 
            // pnlMain2
            // 
            this.pnlMain2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain2.Location = new System.Drawing.Point(0, 52);
            this.pnlMain2.Name = "pnlMain2";
            this.pnlMain2.Size = new System.Drawing.Size(595, 356);
            this.pnlMain2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 472);
            this.Controls.Add(this.pnlNavigation2);
            this.Controls.Add(this.pnlMain2);
            this.Controls.Add(this.pnlTitle2);
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
            this.pnlTitle2.ResumeLayout(false);
            this.pnlNavigation2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlControls;
        private Panel pnlTitle;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlTitle2;
        private Panel pnlNavigation2;
        private Panel pnlMain2;
        private Label lblTitle2;
        private PictureBox pbRight2;
        private PictureBox pbLeft3;
    }
}