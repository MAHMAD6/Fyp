namespace Project_Pulse.UI.UserControls
{
    partial class UC_TextBox
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
            this.TextBox = new Guna.UI.WinForms.GunaTextBox();
            this.PB_cross_error = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_cross_error)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.Transparent;
            this.TextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.TextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.TextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.TextBox.Font = new System.Drawing.Font("Banana Grotesk Thin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.TextBox.Location = new System.Drawing.Point(11, 7);
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.Radius = 13;
            this.TextBox.SelectedText = "";
            this.TextBox.Size = new System.Drawing.Size(329, 49);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "text here";
            this.TextBox.TextOffsetX = 4;
            this.TextBox.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // PB_cross_error
            // 
            this.PB_cross_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.PB_cross_error.Image = global::Project_Pulse.Properties.Resources.close_red;
            this.PB_cross_error.Location = new System.Drawing.Point(306, 22);
            this.PB_cross_error.Name = "PB_cross_error";
            this.PB_cross_error.Size = new System.Drawing.Size(20, 20);
            this.PB_cross_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_cross_error.TabIndex = 1;
            this.PB_cross_error.TabStop = false;
            this.PB_cross_error.Visible = false;
            // 
            // UC_TextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.PB_cross_error);
            this.Controls.Add(this.TextBox);
            this.DoubleBuffered = true;
            this.Name = "UC_TextBox";
            this.Size = new System.Drawing.Size(349, 64);
            this.Load += new System.EventHandler(this.UC_TextBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_cross_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox TextBox;
        private System.Windows.Forms.PictureBox PB_cross_error;
    }
}
