namespace Project_Pulse.UI.UserControls
{
    partial class UC_Student_Details_card
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
            this.components = new System.ComponentModel.Container();
            this.panel_top_border = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_border_heading = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PB_profile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label_h_email = new System.Windows.Forms.Label();
            this.label_h_contact = new System.Windows.Forms.Label();
            this.label_h_DOB = new System.Windows.Forms.Label();
            this.label_h_Gender = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_Designation_roll_number = new System.Windows.Forms.Label();
            this.label_more_info = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_DOB = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_h_salary = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.panel_top_border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top_border
            // 
            this.panel_top_border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.panel_top_border.Controls.Add(this.label_id);
            this.panel_top_border.Controls.Add(this.label_border_heading);
            this.panel_top_border.Controls.Add(this.btn_close);
            this.panel_top_border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_border.Location = new System.Drawing.Point(0, 0);
            this.panel_top_border.Name = "panel_top_border";
            this.panel_top_border.Size = new System.Drawing.Size(509, 40);
            this.panel_top_border.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.label_id.Location = new System.Drawing.Point(174, 5);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(56, 39);
            this.label_id.TabIndex = 17;
            this.label_id.Text = "#01";
            // 
            // label_border_heading
            // 
            this.label_border_heading.AutoSize = true;
            this.label_border_heading.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_border_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.label_border_heading.Location = new System.Drawing.Point(10, 4);
            this.label_border_heading.Name = "label_border_heading";
            this.label_border_heading.Size = new System.Drawing.Size(173, 31);
            this.label_border_heading.TabIndex = 16;
            this.label_border_heading.Text = "Student Card";
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_close.BorderColor = System.Drawing.Color.Black;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_close.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.Image = global::Project_Pulse.Properties.Resources.close_dark;
            this.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_close.Location = new System.Drawing.Point(450, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_close.Size = new System.Drawing.Size(59, 40);
            this.btn_close.TabIndex = 15;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel_top_border;
            // 
            // PB_profile
            // 
            this.PB_profile.BaseColor = System.Drawing.Color.White;
            this.PB_profile.Image = global::Project_Pulse.Properties.Resources.profile_holder_;
            this.PB_profile.Location = new System.Drawing.Point(25, 62);
            this.PB_profile.Name = "PB_profile";
            this.PB_profile.Size = new System.Drawing.Size(214, 204);
            this.PB_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_profile.TabIndex = 1;
            this.PB_profile.TabStop = false;
            this.PB_profile.UseTransfarantBackground = false;
            // 
            // label_h_email
            // 
            this.label_h_email.AutoSize = true;
            this.label_h_email.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_h_email.Location = new System.Drawing.Point(32, 314);
            this.label_h_email.Name = "label_h_email";
            this.label_h_email.Size = new System.Drawing.Size(87, 31);
            this.label_h_email.TabIndex = 20;
            this.label_h_email.Text = "Email:";
            // 
            // label_h_contact
            // 
            this.label_h_contact.AutoSize = true;
            this.label_h_contact.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_h_contact.Location = new System.Drawing.Point(32, 361);
            this.label_h_contact.Name = "label_h_contact";
            this.label_h_contact.Size = new System.Drawing.Size(114, 31);
            this.label_h_contact.TabIndex = 21;
            this.label_h_contact.Text = "Contact:";
            // 
            // label_h_DOB
            // 
            this.label_h_DOB.AutoSize = true;
            this.label_h_DOB.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_h_DOB.Location = new System.Drawing.Point(33, 409);
            this.label_h_DOB.Name = "label_h_DOB";
            this.label_h_DOB.Size = new System.Drawing.Size(179, 31);
            this.label_h_DOB.TabIndex = 22;
            this.label_h_DOB.Text = "Date Of Birth:";
            // 
            // label_h_Gender
            // 
            this.label_h_Gender.AutoSize = true;
            this.label_h_Gender.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_h_Gender.Location = new System.Drawing.Point(34, 458);
            this.label_h_Gender.Name = "label_h_Gender";
            this.label_h_Gender.Size = new System.Drawing.Size(107, 31);
            this.label_h_Gender.TabIndex = 23;
            this.label_h_Gender.Text = "Gender:";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_first_name.Location = new System.Drawing.Point(300, 98);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(155, 31);
            this.label_first_name.TabIndex = 17;
            this.label_first_name.Text = "Muhammad";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_last_name.Location = new System.Drawing.Point(328, 140);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(100, 31);
            this.label_last_name.TabIndex = 18;
            this.label_last_name.Text = "Ahmad";
            // 
            // label_Designation_roll_number
            // 
            this.label_Designation_roll_number.AutoSize = true;
            this.label_Designation_roll_number.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Designation_roll_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_Designation_roll_number.Location = new System.Drawing.Point(307, 181);
            this.label_Designation_roll_number.Name = "label_Designation_roll_number";
            this.label_Designation_roll_number.Size = new System.Drawing.Size(137, 31);
            this.label_Designation_roll_number.TabIndex = 19;
            this.label_Designation_roll_number.Text = "22-CS-09";
            // 
            // label_more_info
            // 
            this.label_more_info.AutoSize = true;
            this.label_more_info.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_more_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.label_more_info.Location = new System.Drawing.Point(184, 272);
            this.label_more_info.Name = "label_more_info";
            this.label_more_info.Size = new System.Drawing.Size(130, 31);
            this.label_more_info.TabIndex = 24;
            this.label_more_info.Text = "More Info";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Nexa Extra Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_email.Location = new System.Drawing.Point(237, 319);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(232, 25);
            this.label_email.TabIndex = 25;
            this.label_email.Text = "acstechyt@gmail.com";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Font = new System.Drawing.Font("Nexa Extra Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_Contact.Location = new System.Drawing.Point(237, 367);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(164, 25);
            this.label_Contact.TabIndex = 26;
            this.label_Contact.Text = "03006552386";
            // 
            // label_DOB
            // 
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Nexa Extra Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_DOB.Location = new System.Drawing.Point(237, 411);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(142, 25);
            this.label_DOB.TabIndex = 27;
            this.label_DOB.Text = "2004-09-05";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Nexa Extra Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_Gender.Location = new System.Drawing.Point(236, 458);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(60, 25);
            this.label_Gender.TabIndex = 28;
            this.label_Gender.Text = "Male";
            // 
            // label_h_salary
            // 
            this.label_h_salary.AutoSize = true;
            this.label_h_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_h_salary.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_h_salary.Location = new System.Drawing.Point(32, 497);
            this.label_h_salary.Name = "label_h_salary";
            this.label_h_salary.Size = new System.Drawing.Size(97, 31);
            this.label_h_salary.TabIndex = 29;
            this.label_h_salary.Text = "Salary:";
            this.label_h_salary.Visible = false;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Font = new System.Drawing.Font("Nexa Extra Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.label_salary.Location = new System.Drawing.Point(237, 502);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(60, 25);
            this.label_salary.TabIndex = 30;
            this.label_salary.Text = "Male";
            this.label_salary.Visible = false;
            // 
            // UC_Student_Details_card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.label_h_salary);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_DOB);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_more_info);
            this.Controls.Add(this.label_h_Gender);
            this.Controls.Add(this.label_h_DOB);
            this.Controls.Add(this.label_h_contact);
            this.Controls.Add(this.label_h_email);
            this.Controls.Add(this.label_Designation_roll_number);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.PB_profile);
            this.Controls.Add(this.panel_top_border);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nexa Heavy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UC_Student_Details_card";
            this.Size = new System.Drawing.Size(509, 541);
            this.panel_top_border.ResumeLayout(false);
            this.panel_top_border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_border;
        private Guna.UI.WinForms.GunaButton btn_close;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_border_heading;
        private Guna.UI.WinForms.GunaCirclePictureBox PB_profile;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label_h_email;
        private System.Windows.Forms.Label label_h_contact;
        private System.Windows.Forms.Label label_h_DOB;
        private System.Windows.Forms.Label label_h_Gender;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_Designation_roll_number;
        private System.Windows.Forms.Label label_more_info;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_Contact;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_h_salary;
        private System.Windows.Forms.Label label_salary;
    }
}
