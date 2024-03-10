namespace Project_Pulse.UI.UserControls
{
    partial class UC_Button
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
            this.btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Animated = true;
            this.btn.AnimationHoverSpeed = 0.07F;
            this.btn.AnimationSpeed = 0.03F;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn.BorderColor = System.Drawing.Color.Black;
            this.btn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn.CheckedBorderColor = System.Drawing.Color.IndianRed;
            this.btn.CheckedForeColor = System.Drawing.Color.White;
            this.btn.CheckedImage = global::Project_Pulse.Properties.Resources.sign_up_dark;
            this.btn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn.FocusedColor = System.Drawing.Color.Empty;
            this.btn.Font = new System.Drawing.Font("Banana Grotesk", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.btn.Image = global::Project_Pulse.Properties.Resources.Sign_up_light;
            this.btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.ImageSize = new System.Drawing.Size(37, 37);
            this.btn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn.Location = new System.Drawing.Point(8, 3);
            this.btn.Name = "btn";
            this.btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.btn.OnHoverImage = global::Project_Pulse.Properties.Resources.sign_up_dark;
            this.btn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(208)))), ((int)(((byte)(197)))));
            this.btn.OnPressedColor = System.Drawing.Color.Black;
            this.btn.Radius = 20;
            this.btn.Size = new System.Drawing.Size(329, 49);
            this.btn.TabIndex = 0;
            this.btn.Text = "Click here";
            this.btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // UC_Button
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.btn);
            this.DoubleBuffered = true;
            this.Name = "UC_Button";
            this.Size = new System.Drawing.Size(341, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btn;
    }
}
