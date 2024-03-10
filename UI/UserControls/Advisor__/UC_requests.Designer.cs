namespace Project_Pulse.UI.UserControls.Advisor__
{
    partial class UC_requests
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
            this.elipse_user_control = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label_heading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // FL_holder
            // 
            this.FL_holder.AutoScroll = true;
            this.FL_holder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
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
            this.panel1.TabIndex = 3;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(161)))), ((int)(((byte)(200)))));
            this.panel_header.Controls.Add(this.label_heading);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(779, 53);
            this.panel_header.TabIndex = 3;
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
            this.label_heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(161)))), ((int)(((byte)(200)))));
            this.label_heading.CausesValidation = false;
            this.label_heading.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_heading.Location = new System.Drawing.Point(182, 10);
            this.label_heading.Margin = new System.Windows.Forms.Padding(3);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(415, 33);
            this.label_heading.TabIndex = 14;
            this.label_heading.Text = "Requests";
            this.label_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_requests
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_requests";
            this.Size = new System.Drawing.Size(779, 562);
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL_holder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_header;
        private Guna.UI.WinForms.GunaElipse elipse_user_control;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.Label label_heading;
    }
}
