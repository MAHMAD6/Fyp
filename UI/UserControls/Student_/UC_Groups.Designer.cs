namespace Project_Pulse.UI.UserControls.Student_
{
    partial class UC_Groups
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
            this.FL_holder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.TB_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.elipse_user_control = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label_heading = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // FL_holder
            // 
            this.FL_holder.AutoScroll = true;
            this.FL_holder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FL_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_holder.Location = new System.Drawing.Point(0, 53);
            this.FL_holder.Name = "FL_holder";
            this.FL_holder.Size = new System.Drawing.Size(779, 509);
            this.FL_holder.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.FL_holder);
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 562);
            this.panel1.TabIndex = 2;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.panel_header.Controls.Add(this.label_heading);
            this.panel_header.Controls.Add(this.btn_add);
            this.panel_header.Controls.Add(this.TB_search);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(779, 53);
            this.panel_header.TabIndex = 3;
            // 
            // TB_search
            // 
            this.TB_search.BackColor = System.Drawing.Color.White;
            this.TB_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_search.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.TB_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_search.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.TB_search.Location = new System.Drawing.Point(478, 10);
            this.TB_search.Name = "TB_search";
            this.TB_search.PasswordChar = '\0';
            this.TB_search.SelectedText = "";
            this.TB_search.Size = new System.Drawing.Size(170, 30);
            this.TB_search.TabIndex = 18;
            this.TB_search.Text = "Search Group";
            this.TB_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_search_KeyDown);
            // 
            // elipse_user_control
            // 
            this.elipse_user_control.Radius = 30;
            this.elipse_user_control.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 30;
            this.gunaElipse2.TargetControl = this.panel1;
            // 
            // label_heading
            // 
            this.label_heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.label_heading.CausesValidation = false;
            this.label_heading.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_heading.Location = new System.Drawing.Point(16, 9);
            this.label_heading.Margin = new System.Windows.Forms.Padding(3);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(415, 33);
            this.label_heading.TabIndex = 13;
            this.label_heading.Text = "Double click to Preview Adivsor";
            this.label_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Animated = true;
            this.btn_add.AnimationHoverSpeed = 0.07F;
            this.btn_add.AnimationSpeed = 0.03F;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_add.BorderColor = System.Drawing.Color.Black;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_add.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_add.Image = global::Project_Pulse.Properties.Resources.profile_holder_;
            this.btn_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_add.Location = new System.Drawing.Point(700, 0);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_add.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_add.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_add.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(79, 53);
            this.btn_add.TabIndex = 19;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // UC_Groups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.Name = "UC_Groups";
            this.Size = new System.Drawing.Size(779, 562);
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL_holder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_header;
        private Guna.UI.WinForms.GunaButton btn_add;
        private Guna.UI.WinForms.GunaLineTextBox TB_search;
        private Guna.UI.WinForms.GunaElipse elipse_user_control;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label label_heading;
    }
}
