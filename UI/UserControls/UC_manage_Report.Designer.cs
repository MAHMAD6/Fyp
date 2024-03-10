namespace Project_Pulse.UI.UserControls
{
    partial class UC_manage_Report
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_report_1 = new System.Windows.Forms.Label();
            this.rbtn_report_1 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.rbtn_2 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.label_report_2 = new System.Windows.Forms.Label();
            this.rbtn3 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.label_report_3 = new System.Windows.Forms.Label();
            this.rbtn4 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.label_report_4 = new System.Windows.Forms.Label();
            this.rbtn5 = new Guna.UI.WinForms.GunaMediumRadioButton();
            this.btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label_report_5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Pulse.Properties.Resources.pdf_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(278, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the Report you want to generate";
            // 
            // label_report_1
            // 
            this.label_report_1.AutoSize = true;
            this.label_report_1.Location = new System.Drawing.Point(319, 150);
            this.label_report_1.Name = "label_report_1";
            this.label_report_1.Size = new System.Drawing.Size(406, 31);
            this.label_report_1.TabIndex = 2;
            this.label_report_1.Text = "list of all students with Advisory board";
            this.label_report_1.Click += new System.EventHandler(this.label_report_1_Click);
            // 
            // rbtn_report_1
            // 
            this.rbtn_report_1.BaseColor = System.Drawing.Color.White;
            this.rbtn_report_1.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtn_report_1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtn_report_1.FillColor = System.Drawing.Color.White;
            this.rbtn_report_1.Location = new System.Drawing.Point(283, 155);
            this.rbtn_report_1.Name = "rbtn_report_1";
            this.rbtn_report_1.Size = new System.Drawing.Size(20, 20);
            this.rbtn_report_1.TabIndex = 3;
            // 
            // rbtn_2
            // 
            this.rbtn_2.BaseColor = System.Drawing.Color.White;
            this.rbtn_2.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtn_2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtn_2.FillColor = System.Drawing.Color.White;
            this.rbtn_2.Location = new System.Drawing.Point(283, 204);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(20, 20);
            this.rbtn_2.TabIndex = 5;
            // 
            // label_report_2
            // 
            this.label_report_2.AutoSize = true;
            this.label_report_2.Location = new System.Drawing.Point(319, 199);
            this.label_report_2.Name = "label_report_2";
            this.label_report_2.Size = new System.Drawing.Size(236, 31);
            this.label_report_2.TabIndex = 4;
            this.label_report_2.Text = "MarkSheet of Projects";
            this.label_report_2.Click += new System.EventHandler(this.label_report_2_Click);
            // 
            // rbtn3
            // 
            this.rbtn3.BaseColor = System.Drawing.Color.White;
            this.rbtn3.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtn3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtn3.FillColor = System.Drawing.Color.White;
            this.rbtn3.Location = new System.Drawing.Point(283, 252);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(20, 20);
            this.rbtn3.TabIndex = 7;
            // 
            // label_report_3
            // 
            this.label_report_3.AutoSize = true;
            this.label_report_3.Location = new System.Drawing.Point(319, 247);
            this.label_report_3.Name = "label_report_3";
            this.label_report_3.Size = new System.Drawing.Size(299, 31);
            this.label_report_3.TabIndex = 6;
            this.label_report_3.Text = "Individual evaluation record";
            this.label_report_3.Click += new System.EventHandler(this.label_report_3_Click);
            // 
            // rbtn4
            // 
            this.rbtn4.BaseColor = System.Drawing.Color.White;
            this.rbtn4.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtn4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtn4.FillColor = System.Drawing.Color.White;
            this.rbtn4.Location = new System.Drawing.Point(283, 299);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(20, 20);
            this.rbtn4.TabIndex = 9;
            // 
            // label_report_4
            // 
            this.label_report_4.AutoSize = true;
            this.label_report_4.Location = new System.Drawing.Point(319, 294);
            this.label_report_4.Name = "label_report_4";
            this.label_report_4.Size = new System.Drawing.Size(447, 31);
            this.label_report_4.TabIndex = 8;
            this.label_report_4.Text = "ContactSheet of students under an advisor";
            this.label_report_4.Click += new System.EventHandler(this.label_report_4_Click);
            // 
            // rbtn5
            // 
            this.rbtn5.BaseColor = System.Drawing.Color.White;
            this.rbtn5.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtn5.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtn5.FillColor = System.Drawing.Color.White;
            this.rbtn5.Location = new System.Drawing.Point(283, 347);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(20, 20);
            this.rbtn5.TabIndex = 11;
            // 
            // btn
            // 
            this.btn.Animated = true;
            this.btn.AnimationHoverSpeed = 0.07F;
            this.btn.AnimationSpeed = 0.03F;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn.BorderColor = System.Drawing.Color.Black;
            this.btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn.CheckedBorderColor = System.Drawing.Color.IndianRed;
            this.btn.CheckedForeColor = System.Drawing.Color.White;
            this.btn.CheckedImage = global::Project_Pulse.Properties.Resources.sign_up_dark;
            this.btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn.FocusedColor = System.Drawing.Color.Empty;
            this.btn.Font = new System.Drawing.Font("Banana Grotesk", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.btn.Image = global::Project_Pulse.Properties.Resources.project_logo;
            this.btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.ImageSize = new System.Drawing.Size(37, 37);
            this.btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn.Location = new System.Drawing.Point(341, 411);
            this.btn.Name = "btn";
            this.btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.btn.OnHoverImage = global::Project_Pulse.Properties.Resources.sign_up_dark;
            this.btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.btn.OnPressedColor = System.Drawing.Color.Black;
            this.btn.Radius = 20;
            this.btn.Size = new System.Drawing.Size(329, 49);
            this.btn.TabIndex = 12;
            this.btn.Text = "Generate report";
            this.btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label_report_5
            // 
            this.label_report_5.AutoSize = true;
            this.label_report_5.Location = new System.Drawing.Point(319, 340);
            this.label_report_5.Name = "label_report_5";
            this.label_report_5.Size = new System.Drawing.Size(390, 31);
            this.label_report_5.TabIndex = 10;
            this.label_report_5.Text = "Group And Group Assignment status";
            this.label_report_5.Click += new System.EventHandler(this.label_report_5_Click);
            // 
            // UC_manage_Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.label_report_5);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.label_report_4);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.label_report_3);
            this.Controls.Add(this.rbtn_2);
            this.Controls.Add(this.label_report_2);
            this.Controls.Add(this.rbtn_report_1);
            this.Controls.Add(this.label_report_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.Name = "UC_manage_Report";
            this.Size = new System.Drawing.Size(773, 559);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_report_1;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_report_1;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn_2;
        private System.Windows.Forms.Label label_report_2;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn3;
        private System.Windows.Forms.Label label_report_3;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn4;
        private System.Windows.Forms.Label label_report_4;
        private Guna.UI.WinForms.GunaMediumRadioButton rbtn5;
        private Guna.UI.WinForms.GunaAdvenceButton btn;
        private System.Windows.Forms.Label label_report_5;
    }
}
