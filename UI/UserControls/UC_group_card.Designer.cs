namespace Project_Pulse.UI.UserControls
{
    partial class UC_group_card
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
            this.panel_join = new System.Windows.Forms.Panel();
            this.btn_join = new Guna.UI.WinForms.GunaButton();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_members = new System.Windows.Forms.Label();
            this.panel_createdON = new System.Windows.Forms.Panel();
            this.label_created_on = new System.Windows.Forms.Label();
            this.panel_img = new System.Windows.Forms.Panel();
            this.PB_image = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_id = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.panel_join.SuspendLayout();
            this.panel_delete.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_createdON.SuspendLayout();
            this.panel_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_image)).BeginInit();
            this.panel_id.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_join
            // 
            this.panel_join.Controls.Add(this.btn_join);
            this.panel_join.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_join.Location = new System.Drawing.Point(572, 3);
            this.panel_join.Name = "panel_join";
            this.panel_join.Size = new System.Drawing.Size(92, 66);
            this.panel_join.TabIndex = 5;
            // 
            // btn_join
            // 
            this.btn_join.Animated = true;
            this.btn_join.AnimationHoverSpeed = 0.07F;
            this.btn_join.AnimationSpeed = 0.03F;
            this.btn_join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_join.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_join.BorderColor = System.Drawing.Color.Black;
            this.btn_join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_join.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_join.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_join.FocusedColor = System.Drawing.Color.Empty;
            this.btn_join.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_join.Image = global::Project_Pulse.Properties.Resources.sign_up_dark;
            this.btn_join.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_join.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_join.Location = new System.Drawing.Point(13, 0);
            this.btn_join.Name = "btn_join";
            this.btn_join.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_join.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_join.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_join.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_join.OnPressedColor = System.Drawing.Color.Black;
            this.btn_join.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_join.Size = new System.Drawing.Size(79, 66);
            this.btn_join.TabIndex = 22;
            this.btn_join.Visible = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.btn_delete);
            this.panel_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_delete.Location = new System.Drawing.Point(664, 3);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(98, 66);
            this.panel_delete.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.Image = global::Project_Pulse.Properties.Resources.close_dark;
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_delete.Location = new System.Drawing.Point(19, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(79, 66);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_members);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(427, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 66);
            this.panel4.TabIndex = 3;
            // 
            // label_members
            // 
            this.label_members.AutoSize = true;
            this.label_members.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_members.Location = new System.Drawing.Point(15, 15);
            this.label_members.Name = "label_members";
            this.label_members.Size = new System.Drawing.Size(122, 29);
            this.label_members.TabIndex = 8;
            this.label_members.Text = "members";
            // 
            // panel_createdON
            // 
            this.panel_createdON.Controls.Add(this.label_created_on);
            this.panel_createdON.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_createdON.Location = new System.Drawing.Point(209, 3);
            this.panel_createdON.Name = "panel_createdON";
            this.panel_createdON.Size = new System.Drawing.Size(218, 66);
            this.panel_createdON.TabIndex = 2;
            // 
            // label_created_on
            // 
            this.label_created_on.AutoSize = true;
            this.label_created_on.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_created_on.Location = new System.Drawing.Point(9, 17);
            this.label_created_on.Name = "label_created_on";
            this.label_created_on.Size = new System.Drawing.Size(138, 29);
            this.label_created_on.TabIndex = 7;
            this.label_created_on.Text = "created on";
            // 
            // panel_img
            // 
            this.panel_img.Controls.Add(this.PB_image);
            this.panel_img.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_img.Location = new System.Drawing.Point(128, 3);
            this.panel_img.Name = "panel_img";
            this.panel_img.Size = new System.Drawing.Size(81, 66);
            this.panel_img.TabIndex = 1;
            // 
            // PB_image
            // 
            this.PB_image.Image = global::Project_Pulse.Properties.Resources.student_dark;
            this.PB_image.Location = new System.Drawing.Point(11, 12);
            this.PB_image.Name = "PB_image";
            this.PB_image.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PB_image.ShadowDecoration.Parent = this.PB_image;
            this.PB_image.Size = new System.Drawing.Size(64, 43);
            this.PB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_image.TabIndex = 5;
            this.PB_image.TabStop = false;
            // 
            // panel_id
            // 
            this.panel_id.Controls.Add(this.label_id);
            this.panel_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_id.Location = new System.Drawing.Point(3, 3);
            this.panel_id.Name = "panel_id";
            this.panel_id.Size = new System.Drawing.Size(125, 66);
            this.panel_id.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(17, 18);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(73, 29);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "1000";
            // 
            // UC_group_card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panel_delete);
            this.Controls.Add(this.panel_join);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_createdON);
            this.Controls.Add(this.panel_img);
            this.Controls.Add(this.panel_id);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bebas Neue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Name = "UC_group_card";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(761, 72);
            this.panel_join.ResumeLayout(false);
            this.panel_delete.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_createdON.ResumeLayout(false);
            this.panel_createdON.PerformLayout();
            this.panel_img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_image)).EndInit();
            this.panel_id.ResumeLayout(false);
            this.panel_id.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_join;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_createdON;
        private System.Windows.Forms.Panel panel_img;
        private System.Windows.Forms.Panel panel_id;
        private System.Windows.Forms.Label label_created_on;
        private System.Windows.Forms.Label label_members;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PB_image;
        private System.Windows.Forms.Label label_id;
        private Guna.UI.WinForms.GunaButton btn_join;
        private Guna.UI.WinForms.GunaButton btn_delete;
    }
}
