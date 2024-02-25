namespace Project_Pulse.UI.FORMS
{
    partial class loading_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading_page));
            this.page_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.label_panel = new System.Windows.Forms.Panel();
            this.label_loading = new System.Windows.Forms.Label();
            this.label_terms_conditions = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.elipse_for_loading_label = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel.SuspendLayout();
            this.label_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // page_elipse
            // 
            this.page_elipse.ElipseRadius = 20;
            this.page_elipse.TargetControl = this;
            // 
            // panel_elipse
            // 
            this.panel_elipse.ElipseRadius = 20;
            this.panel_elipse.TargetControl = this.panel;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.panel.Controls.Add(this.label_panel);
            this.panel.Controls.Add(this.label_terms_conditions);
            this.panel.Controls.Add(this.guna2CircleProgressBar1);
            this.panel.Controls.Add(this.PictureBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(798, 448);
            this.panel.TabIndex = 0;
            this.panel.UseWaitCursor = true;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label_panel
            // 
            this.label_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label_panel.Controls.Add(this.label_loading);
            this.label_panel.Location = new System.Drawing.Point(476, 336);
            this.label_panel.Name = "label_panel";
            this.label_panel.Size = new System.Drawing.Size(130, 37);
            this.label_panel.TabIndex = 6;
            this.label_panel.UseWaitCursor = true;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.BackColor = System.Drawing.Color.Transparent;
            this.label_loading.Font = new System.Drawing.Font("Banana Grotesk Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_loading.Location = new System.Drawing.Point(8, 5);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(95, 28);
            this.label_loading.TabIndex = 4;
            this.label_loading.Text = "loading";
            this.label_loading.UseWaitCursor = true;
            // 
            // label_terms_conditions
            // 
            this.label_terms_conditions.AutoSize = true;
            this.label_terms_conditions.BackColor = System.Drawing.Color.Transparent;
            this.label_terms_conditions.Font = new System.Drawing.Font("Nexa Extra Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_terms_conditions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_terms_conditions.Location = new System.Drawing.Point(352, 403);
            this.label_terms_conditions.Name = "label_terms_conditions";
            this.label_terms_conditions.Size = new System.Drawing.Size(364, 19);
            this.label_terms_conditions.TabIndex = 5;
            this.label_terms_conditions.Text = "You are accepting our terms and conditions";
            this.label_terms_conditions.UseWaitCursor = true;
            this.label_terms_conditions.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(511, 266);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressThickness = 7;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(50, 50);
            this.guna2CircleProgressBar1.TabIndex = 3;
            this.guna2CircleProgressBar1.UseWaitCursor = true;
            this.guna2CircleProgressBar1.Value = 90;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Image = global::Project_Pulse.Properties.Resources.loading_bg;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(798, 448);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.UseWaitCursor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // elipse_for_loading_label
            // 
            this.elipse_for_loading_label.ElipseRadius = 15;
            this.elipse_for_loading_label.TargetControl = this.label_panel;
            // 
            // loading_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loading_page";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Navigator";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.loading_page_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.label_panel.ResumeLayout(false);
            this.label_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse page_elipse;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuElipse panel_elipse;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_terms_conditions;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Panel label_panel;
        private Bunifu.Framework.UI.BunifuElipse elipse_for_loading_label;
    }
}