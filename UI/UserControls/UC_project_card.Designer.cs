namespace Project_Pulse.UI.UserControls
{
    partial class UC_project_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_project_card));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PB_project = new System.Windows.Forms.PictureBox();
            this.panel_text_holder = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_side_bar = new System.Windows.Forms.Panel();
            this.Select_Project = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_project)).BeginInit();
            this.panel_text_holder.SuspendLayout();
            this.panel_side_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_text_holder);
            this.panel1.Controls.Add(this.panel_side_bar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 232);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PB_project);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(63, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 232);
            this.panel3.TabIndex = 5;
            // 
            // PB_project
            // 
            this.PB_project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_project.Image = global::Project_Pulse.Properties.Resources.project_main_logo;
            this.PB_project.Location = new System.Drawing.Point(0, 0);
            this.PB_project.Name = "PB_project";
            this.PB_project.Size = new System.Drawing.Size(255, 232);
            this.PB_project.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_project.TabIndex = 2;
            this.PB_project.TabStop = false;
            // 
            // panel_text_holder
            // 
            this.panel_text_holder.Controls.Add(this.label_id);
            this.panel_text_holder.Controls.Add(this.label_description);
            this.panel_text_holder.Controls.Add(this.label_title);
            this.panel_text_holder.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_text_holder.Location = new System.Drawing.Point(309, 0);
            this.panel_text_holder.Name = "panel_text_holder";
            this.panel_text_holder.Size = new System.Drawing.Size(456, 232);
            this.panel_text_holder.TabIndex = 4;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Albert Sans Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(130, 34);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(143, 27);
            this.label_id.TabIndex = 8;
            this.label_id.Text = "Project# 10010";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Nexa Extra Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(3, 127);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(421, 26);
            this.label_description.TabIndex = 7;
            this.label_description.Text = "The person doesn\'t always need to yes";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Broadway", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(25, 61);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(369, 57);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "Project Title";
            // 
            // panel_side_bar
            // 
            this.panel_side_bar.Controls.Add(this.Select_Project);
            this.panel_side_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side_bar.Location = new System.Drawing.Point(0, 0);
            this.panel_side_bar.Name = "panel_side_bar";
            this.panel_side_bar.Size = new System.Drawing.Size(63, 232);
            this.panel_side_bar.TabIndex = 3;
            // 
            // Select_Project
            // 
            this.Select_Project.Animated = true;
            this.Select_Project.AnimationHoverSpeed = 0.07F;
            this.Select_Project.AnimationSpeed = 0.03F;
            this.Select_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.Select_Project.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Select_Project.BorderColor = System.Drawing.Color.Black;
            this.Select_Project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Select_Project.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Select_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Select_Project.FocusedColor = System.Drawing.Color.Empty;
            this.Select_Project.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Project.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Select_Project.Image = ((System.Drawing.Image)(resources.GetObject("Select_Project.Image")));
            this.Select_Project.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Select_Project.ImageSize = new System.Drawing.Size(26, 26);
            this.Select_Project.Location = new System.Drawing.Point(0, 0);
            this.Select_Project.Name = "Select_Project";
            this.Select_Project.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Select_Project.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Select_Project.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Select_Project.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Select_Project.OnHoverImage")));
            this.Select_Project.OnPressedColor = System.Drawing.Color.Black;
            this.Select_Project.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Select_Project.Size = new System.Drawing.Size(63, 232);
            this.Select_Project.TabIndex = 15;
            this.Select_Project.Click += new System.EventHandler(this.Select_Project_Click);
            // 
            // UC_project_card
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.Name = "UC_project_card";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(773, 240);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_project)).EndInit();
            this.panel_text_holder.ResumeLayout(false);
            this.panel_text_holder.PerformLayout();
            this.panel_side_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_side_bar;
        private System.Windows.Forms.PictureBox PB_project;
        private System.Windows.Forms.Panel panel_text_holder;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_id;
        private Guna.UI.WinForms.GunaButton Select_Project;
    }
}
