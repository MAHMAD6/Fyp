namespace Project_Pulse.UI.FORMS
{
    partial class manager_main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_main_page));
            this.shadow_form = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu_holder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_menu_header = new System.Windows.Forms.Label();
            this.btn_minimize = new Guna.UI.WinForms.GunaButton();
            this.btn_maximize = new Guna.UI.WinForms.GunaButton();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.panel_side_bar = new System.Windows.Forms.Panel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btn_student = new Guna.UI.WinForms.GunaButton();
            this.panel_business = new System.Windows.Forms.Panel();
            this.label_project_heading_top_left = new System.Windows.Forms.Label();
            this.PB_project_logo = new System.Windows.Forms.PictureBox();
            this.panel_user_info_left_bottom = new System.Windows.Forms.Panel();
            this.label_user_bottom_left = new System.Windows.Forms.Label();
            this.PB_userProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_signout = new Guna.UI.WinForms.GunaButton();
            this.panel_topLine = new System.Windows.Forms.Panel();
            this.dragControl_form = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resize_form = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_side_bar.SuspendLayout();
            this.panel_business.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_project_logo)).BeginInit();
            this.panel_user_info_left_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_userProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Yellow;
            this.panel_main.Controls.Add(this.panel_menu_holder);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel_side_bar);
            this.panel_main.Controls.Add(this.panel_topLine);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1278, 737);
            this.panel_main.TabIndex = 0;
            // 
            // panel_menu_holder
            // 
            this.panel_menu_holder.BackColor = System.Drawing.Color.Silver;
            this.panel_menu_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu_holder.Location = new System.Drawing.Point(300, 43);
            this.panel_menu_holder.Name = "panel_menu_holder";
            this.panel_menu_holder.Size = new System.Drawing.Size(978, 694);
            this.panel_menu_holder.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.label_menu_header);
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_maximize);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 37);
            this.panel2.TabIndex = 3;
            // 
            // label_menu_header
            // 
            this.label_menu_header.AutoSize = true;
            this.label_menu_header.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_menu_header.Font = new System.Drawing.Font("Banana Grotesk Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_menu_header.Location = new System.Drawing.Point(0, 0);
            this.label_menu_header.Name = "label_menu_header";
            this.label_menu_header.Padding = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.label_menu_header.Size = new System.Drawing.Size(91, 32);
            this.label_menu_header.TabIndex = 9;
            this.label_menu_header.Text = "Menu";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Animated = true;
            this.btn_minimize.AnimationHoverSpeed = 0.07F;
            this.btn_minimize.AnimationSpeed = 0.03F;
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_minimize.BorderColor = System.Drawing.Color.Black;
            this.btn_minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FocusedColor = System.Drawing.Color.Empty;
            this.btn_minimize.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_minimize.Image = global::Project_Pulse.Properties.Resources.minmize_dark;
            this.btn_minimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_minimize.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_minimize.Location = new System.Drawing.Point(795, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_minimize.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_minimize.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_minimize.OnHoverImage = global::Project_Pulse.Properties.Resources.minimize_light;
            this.btn_minimize.OnPressedColor = System.Drawing.Color.Black;
            this.btn_minimize.Size = new System.Drawing.Size(61, 37);
            this.btn_minimize.TabIndex = 8;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Animated = true;
            this.btn_maximize.AnimationHoverSpeed = 0.07F;
            this.btn_maximize.AnimationSpeed = 0.03F;
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_maximize.BorderColor = System.Drawing.Color.Black;
            this.btn_maximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_maximize.FocusedColor = System.Drawing.Color.Empty;
            this.btn_maximize.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_maximize.Image = global::Project_Pulse.Properties.Resources.maximize_dark;
            this.btn_maximize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_maximize.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_maximize.Location = new System.Drawing.Point(856, 0);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_maximize.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_maximize.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_maximize.OnHoverImage = global::Project_Pulse.Properties.Resources.maximize_light;
            this.btn_maximize.OnPressedColor = System.Drawing.Color.Black;
            this.btn_maximize.Size = new System.Drawing.Size(61, 37);
            this.btn_maximize.TabIndex = 7;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.BorderColor = System.Drawing.Color.Black;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_close.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.Image = global::Project_Pulse.Properties.Resources.close_dark;
            this.btn_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_close.Location = new System.Drawing.Point(917, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_close.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_close.Size = new System.Drawing.Size(61, 37);
            this.btn_close.TabIndex = 6;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_side_bar
            // 
            this.panel_side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel_side_bar.Controls.Add(this.gunaButton3);
            this.panel_side_bar.Controls.Add(this.gunaButton2);
            this.panel_side_bar.Controls.Add(this.gunaButton1);
            this.panel_side_bar.Controls.Add(this.btn_student);
            this.panel_side_bar.Controls.Add(this.panel_business);
            this.panel_side_bar.Controls.Add(this.panel_user_info_left_bottom);
            this.panel_side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side_bar.Location = new System.Drawing.Point(0, 6);
            this.panel_side_bar.Name = "panel_side_bar";
            this.panel_side_bar.Size = new System.Drawing.Size(300, 731);
            this.panel_side_bar.TabIndex = 2;
            // 
            // gunaButton3
            // 
            this.gunaButton3.Animated = true;
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(0, 417);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(300, 75);
            this.gunaButton3.TabIndex = 8;
            this.gunaButton3.Text = "student";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(0, 342);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(300, 75);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Text = "student";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 267);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(300, 75);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "student";
            // 
            // btn_student
            // 
            this.btn_student.Animated = true;
            this.btn_student.AnimationHoverSpeed = 0.07F;
            this.btn_student.AnimationSpeed = 0.03F;
            this.btn_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_student.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_student.BorderColor = System.Drawing.Color.Black;
            this.btn_student.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_student.FocusedColor = System.Drawing.Color.Empty;
            this.btn_student.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))));
            this.btn_student.Image = ((System.Drawing.Image)(resources.GetObject("btn_student.Image")));
            this.btn_student.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_student.Location = new System.Drawing.Point(0, 192);
            this.btn_student.Name = "btn_student";
            this.btn_student.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.btn_student.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_student.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_student.OnHoverImage = null;
            this.btn_student.OnPressedColor = System.Drawing.Color.Black;
            this.btn_student.Size = new System.Drawing.Size(300, 75);
            this.btn_student.TabIndex = 5;
            this.btn_student.Text = "student";
            // 
            // panel_business
            // 
            this.panel_business.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel_business.Controls.Add(this.label_project_heading_top_left);
            this.panel_business.Controls.Add(this.PB_project_logo);
            this.panel_business.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_business.Location = new System.Drawing.Point(0, 0);
            this.panel_business.Name = "panel_business";
            this.panel_business.Size = new System.Drawing.Size(300, 192);
            this.panel_business.TabIndex = 4;
            // 
            // label_project_heading_top_left
            // 
            this.label_project_heading_top_left.AutoSize = true;
            this.label_project_heading_top_left.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_project_heading_top_left.Font = new System.Drawing.Font("Banana Grotesk Medium", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_project_heading_top_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_project_heading_top_left.Location = new System.Drawing.Point(0, 136);
            this.label_project_heading_top_left.Name = "label_project_heading_top_left";
            this.label_project_heading_top_left.Padding = new System.Windows.Forms.Padding(47, 0, 0, 30);
            this.label_project_heading_top_left.Size = new System.Drawing.Size(245, 56);
            this.label_project_heading_top_left.TabIndex = 10;
            this.label_project_heading_top_left.Text = "Project Navigator";
            // 
            // PB_project_logo
            // 
            this.PB_project_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_project_logo.Image = global::Project_Pulse.Properties.Resources.project_logo;
            this.PB_project_logo.Location = new System.Drawing.Point(90, 18);
            this.PB_project_logo.Name = "PB_project_logo";
            this.PB_project_logo.Size = new System.Drawing.Size(101, 114);
            this.PB_project_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_project_logo.TabIndex = 0;
            this.PB_project_logo.TabStop = false;
            // 
            // panel_user_info_left_bottom
            // 
            this.panel_user_info_left_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel_user_info_left_bottom.Controls.Add(this.label_user_bottom_left);
            this.panel_user_info_left_bottom.Controls.Add(this.PB_userProfile);
            this.panel_user_info_left_bottom.Controls.Add(this.btn_signout);
            this.panel_user_info_left_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_user_info_left_bottom.Location = new System.Drawing.Point(0, 685);
            this.panel_user_info_left_bottom.Name = "panel_user_info_left_bottom";
            this.panel_user_info_left_bottom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel_user_info_left_bottom.Size = new System.Drawing.Size(300, 46);
            this.panel_user_info_left_bottom.TabIndex = 3;
            // 
            // label_user_bottom_left
            // 
            this.label_user_bottom_left.AutoSize = true;
            this.label_user_bottom_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_user_bottom_left.Font = new System.Drawing.Font("Banana Grotesk Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_bottom_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_user_bottom_left.Location = new System.Drawing.Point(95, 0);
            this.label_user_bottom_left.Name = "label_user_bottom_left";
            this.label_user_bottom_left.Padding = new System.Windows.Forms.Padding(13, 15, 0, 0);
            this.label_user_bottom_left.Size = new System.Drawing.Size(62, 36);
            this.label_user_bottom_left.TabIndex = 11;
            this.label_user_bottom_left.Text = "User";
            // 
            // PB_userProfile
            // 
            this.PB_userProfile.BaseColor = System.Drawing.Color.White;
            this.PB_userProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_userProfile.Location = new System.Drawing.Point(55, 0);
            this.PB_userProfile.Name = "PB_userProfile";
            this.PB_userProfile.Size = new System.Drawing.Size(40, 42);
            this.PB_userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_userProfile.TabIndex = 10;
            this.PB_userProfile.TabStop = false;
            this.PB_userProfile.UseTransfarantBackground = false;
            // 
            // btn_signout
            // 
            this.btn_signout.Animated = true;
            this.btn_signout.AnimationHoverSpeed = 0.07F;
            this.btn_signout.AnimationSpeed = 0.03F;
            this.btn_signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_signout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_signout.BorderColor = System.Drawing.Color.Black;
            this.btn_signout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_signout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_signout.FocusedColor = System.Drawing.Color.Empty;
            this.btn_signout.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_signout.Image = global::Project_Pulse.Properties.Resources.sign_out_dark;
            this.btn_signout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_signout.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_signout.Location = new System.Drawing.Point(0, 0);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_signout.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_signout.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_signout.OnHoverImage = global::Project_Pulse.Properties.Resources.sign_out_light;
            this.btn_signout.OnPressedColor = System.Drawing.Color.Black;
            this.btn_signout.Size = new System.Drawing.Size(55, 42);
            this.btn_signout.TabIndex = 9;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // panel_topLine
            // 
            this.panel_topLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_topLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topLine.Location = new System.Drawing.Point(0, 0);
            this.panel_topLine.Name = "panel_topLine";
            this.panel_topLine.Size = new System.Drawing.Size(1278, 6);
            this.panel_topLine.TabIndex = 1;
            // 
            // dragControl_form
            // 
            this.dragControl_form.TargetControl = null;
            // 
            // manager_main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1278, 737);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manager_main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager-PNavigator";
            this.Load += new System.EventHandler(this.manager_main_page_Load);
            this.panel_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_side_bar.ResumeLayout(false);
            this.panel_business.ResumeLayout(false);
            this.panel_business.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_project_logo)).EndInit();
            this.panel_user_info_left_bottom.ResumeLayout(false);
            this.panel_user_info_left_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_userProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm shadow_form;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_side_bar;
        private System.Windows.Forms.Panel panel_user_info_left_bottom;
        private System.Windows.Forms.Panel panel_topLine;
        private Guna.UI.WinForms.GunaButton btn_student;
        private System.Windows.Forms.Panel panel_business;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btn_close;
        private Guna.UI.WinForms.GunaButton btn_minimize;
        private Guna.UI.WinForms.GunaButton btn_maximize;
        private System.Windows.Forms.Label label_menu_header;
        private System.Windows.Forms.PictureBox PB_project_logo;
        private System.Windows.Forms.Label label_project_heading_top_left;
        private System.Windows.Forms.Panel panel_menu_holder;
        private Guna.UI.WinForms.GunaButton btn_signout;
        private System.Windows.Forms.Label label_user_bottom_left;
        private Guna.UI.WinForms.GunaCirclePictureBox PB_userProfile;
        private Guna.UI2.WinForms.Guna2DragControl dragControl_form;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        public Guna.UI2.WinForms.Guna2ResizeForm resize_form;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
    }
}