namespace Project_Pulse.UI.UserControls
{
    partial class uc_message_for_controls
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
            this.label_menu_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_menu_header
            // 
            this.label_menu_header.AutoSize = true;
            this.label_menu_header.Font = new System.Drawing.Font("Banana Grotesk Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.label_menu_header.Location = new System.Drawing.Point(-9, 12);
            this.label_menu_header.Name = "label_menu_header";
            this.label_menu_header.Padding = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.label_menu_header.Size = new System.Drawing.Size(257, 41);
            this.label_menu_header.TabIndex = 10;
            this.label_menu_header.Text = "Welcome back!";
            // 
            // uc_message_for_controls
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.label_menu_header);
            this.Name = "uc_message_for_controls";
            this.Size = new System.Drawing.Size(438, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu_header;
    }
}
