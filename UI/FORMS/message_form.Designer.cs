namespace Project_Pulse.UI.FORMS
{
    partial class form_message
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
            this.elipse_form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer_fade_form = new System.Windows.Forms.Timer(this.components);
            this.gunaShadowPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.label_light = new Guna.UI.WinForms.GunaLabel();
            this.label_dark = new Guna.UI.WinForms.GunaLabel();
            this.PB_message_icon = new System.Windows.Forms.PictureBox();
            this.gunaShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_message_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.ElipseRadius = 30;
            this.elipse_form.TargetControl = this;
            // 
            // timer_fade_form
            // 
            this.timer_fade_form.Enabled = true;
            this.timer_fade_form.Tick += new System.EventHandler(this.timer_fade_form_Tick);
            // 
            // gunaShadowPanel
            // 
            this.gunaShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(21)))), ((int)(((byte)(17)))));
            this.gunaShadowPanel.Controls.Add(this.label_light);
            this.gunaShadowPanel.Controls.Add(this.label_dark);
            this.gunaShadowPanel.Controls.Add(this.PB_message_icon);
            this.gunaShadowPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaShadowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel.Name = "gunaShadowPanel";
            this.gunaShadowPanel.Radius = 6;
            this.gunaShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel.ShadowDepth = 10;
            this.gunaShadowPanel.Size = new System.Drawing.Size(509, 108);
            this.gunaShadowPanel.TabIndex = 0;
            // 
            // label_light
            // 
            this.label_light.AutoSize = true;
            this.label_light.Font = new System.Drawing.Font("Vazirmatn Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_light.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_light.Location = new System.Drawing.Point(49, 59);
            this.label_light.Name = "label_light";
            this.label_light.Size = new System.Drawing.Size(371, 38);
            this.label_light.TabIndex = 2;
            this.label_light.Text = "Failed  to  save:  Invalid  Group Data";
            // 
            // label_dark
            // 
            this.label_dark.AutoSize = true;
            this.label_dark.Font = new System.Drawing.Font("Vazirmatn Medium", 13F, System.Drawing.FontStyle.Bold);
            this.label_dark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.label_dark.Location = new System.Drawing.Point(87, 21);
            this.label_dark.Name = "label_dark";
            this.label_dark.Size = new System.Drawing.Size(65, 38);
            this.label_dark.TabIndex = 1;
            this.label_dark.Text = "Error";
            // 
            // PB_message_icon
            // 
            this.PB_message_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_message_icon.Image = global::Project_Pulse.Properties.Resources.close_circle_light;
            this.PB_message_icon.Location = new System.Drawing.Point(46, 25);
            this.PB_message_icon.Name = "PB_message_icon";
            this.PB_message_icon.Size = new System.Drawing.Size(40, 26);
            this.PB_message_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_message_icon.TabIndex = 0;
            this.PB_message_icon.TabStop = false;
            // 
            // form_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(42)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(509, 108);
            this.Controls.Add(this.gunaShadowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_message";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "message_form";
            this.gunaShadowPanel.ResumeLayout(false);
            this.gunaShadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_message_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elipse_form;
        private System.Windows.Forms.Timer timer_fade_form;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel;
        private Guna.UI.WinForms.GunaLabel label_light;
        private Guna.UI.WinForms.GunaLabel label_dark;
        private System.Windows.Forms.PictureBox PB_message_icon;
    }
}