namespace Project_Pulse.UI.UserControls
{
    partial class UC_checkbox
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
            this.elipse_panel_bg_tick = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PB_tick = new System.Windows.Forms.PictureBox();
            this.label_message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_tick)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_panel_bg_tick
            // 
            this.elipse_panel_bg_tick.ElipseRadius = 5;
            this.elipse_panel_bg_tick.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.PB_tick);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 15;
            // 
            // PB_tick
            // 
            this.PB_tick.Image = global::Project_Pulse.Properties.Resources.tick_yellow;
            this.PB_tick.Location = new System.Drawing.Point(2, 3);
            this.PB_tick.Name = "PB_tick";
            this.PB_tick.Size = new System.Drawing.Size(25, 24);
            this.PB_tick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_tick.TabIndex = 1;
            this.PB_tick.TabStop = false;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.label_message.Location = new System.Drawing.Point(37, 12);
            this.label_message.Name = "label_message";
            this.label_message.Padding = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.label_message.Size = new System.Drawing.Size(76, 32);
            this.label_message.TabIndex = 14;
            this.label_message.Text = "Text";
            // 
            // UC_checkbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_message);
            this.DoubleBuffered = true;
            this.Name = "UC_checkbox";
            this.Size = new System.Drawing.Size(178, 60);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_tick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse elipse_panel_bg_tick;
        public System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_tick;
    }
}
