namespace Project_Pulse.UI.UserControls
{
    partial class UC_data_tile
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel_bg = new System.Windows.Forms.Panel();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PB_profile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // panel_bg
            // 
            this.panel_bg.Controls.Add(this.label_ID);
            this.panel_bg.Controls.Add(this.label_email);
            this.panel_bg.Controls.Add(this.label_first_name);
            this.panel_bg.Controls.Add(this.PB_profile);
            this.panel_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bg.Location = new System.Drawing.Point(4, 4);
            this.panel_bg.Name = "panel_bg";
            this.panel_bg.Size = new System.Drawing.Size(303, 254);
            this.panel_bg.TabIndex = 0;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Albert Sans Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_ID.Location = new System.Drawing.Point(2, 6);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(77, 32);
            this.label_ID.TabIndex = 14;
            this.label_ID.Text = "#1001";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Albert Sans Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(52, 205);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(209, 27);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "acstechyt@gmail.com";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Nexa Heavy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_first_name.Location = new System.Drawing.Point(84, 175);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(138, 30);
            this.label_first_name.TabIndex = 12;
            this.label_first_name.Text = "first_name";
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 15;
            this.gunaElipse2.TargetControl = this.panel_bg;
            // 
            // PB_profile
            // 
            this.PB_profile.BaseColor = System.Drawing.Color.White;
            this.PB_profile.Image = global::Project_Pulse.Properties.Resources.profile_holder_;
            this.PB_profile.Location = new System.Drawing.Point(82, 16);
            this.PB_profile.Name = "PB_profile";
            this.PB_profile.Size = new System.Drawing.Size(148, 141);
            this.PB_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_profile.TabIndex = 11;
            this.PB_profile.TabStop = false;
            this.PB_profile.UseTransfarantBackground = false;
            // 
            // UC_data_tile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel_bg);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UC_data_tile";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(311, 262);
            this.panel_bg.ResumeLayout(false);
            this.panel_bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel_bg;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_first_name;
        private Guna.UI.WinForms.GunaCirclePictureBox PB_profile;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}
