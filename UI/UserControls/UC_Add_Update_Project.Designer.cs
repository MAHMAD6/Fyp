namespace Project_Pulse.UI.UserControls
{
    partial class UC_Add_Update_Project_and_evaluation
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
            this.panel_top_border = new System.Windows.Forms.Panel();
            this.label_border_heading = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_top_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top_border
            // 
            this.panel_top_border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.panel_top_border.Controls.Add(this.label_border_heading);
            this.panel_top_border.Controls.Add(this.btn_close);
            this.panel_top_border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top_border.Location = new System.Drawing.Point(0, 0);
            this.panel_top_border.Name = "panel_top_border";
            this.panel_top_border.Size = new System.Drawing.Size(513, 40);
            this.panel_top_border.TabIndex = 3;
            // 
            // label_border_heading
            // 
            this.label_border_heading.AutoSize = true;
            this.label_border_heading.Font = new System.Drawing.Font("Nexa Heavy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_border_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.label_border_heading.Location = new System.Drawing.Point(10, 4);
            this.label_border_heading.Name = "label_border_heading";
            this.label_border_heading.Size = new System.Drawing.Size(155, 31);
            this.label_border_heading.TabIndex = 16;
            this.label_border_heading.Text = "Add Project";
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
            this.btn_close.Location = new System.Drawing.Point(454, 0);
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
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(67, 40);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(446, 505);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // UC_Add_Update_Project
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel_top_border);
            this.Controls.Add(this.flowLayoutPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nexa Heavy", 16.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.Name = "UC_Add_Update_Project";
            this.Size = new System.Drawing.Size(513, 545);
            this.panel_top_border.ResumeLayout(false);
            this.panel_top_border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top_border;
        private System.Windows.Forms.Label label_border_heading;
        private Guna.UI.WinForms.GunaButton btn_close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
