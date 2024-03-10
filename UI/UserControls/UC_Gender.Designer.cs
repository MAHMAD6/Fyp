namespace Project_Pulse.UI.UserControls
{
    partial class UC_Gender
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
            this.label_for_gender = new System.Windows.Forms.Label();
            this.timer_for_gender = new System.Windows.Forms.Timer(this.components);
            this.uC_checkbox_female = new Project_Pulse.UI.UserControls.UC_checkbox();
            this.uC_checkbox_male = new Project_Pulse.UI.UserControls.UC_checkbox();
            this.SuspendLayout();
            // 
            // label_for_gender
            // 
            this.label_for_gender.AutoSize = true;
            this.label_for_gender.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_for_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.label_for_gender.Location = new System.Drawing.Point(-11, 3);
            this.label_for_gender.Name = "label_for_gender";
            this.label_for_gender.Padding = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.label_for_gender.Size = new System.Drawing.Size(110, 32);
            this.label_for_gender.TabIndex = 11;
            this.label_for_gender.Text = "Gender";
            // 
            // timer_for_gender
            // 
            this.timer_for_gender.Interval = 10;
            this.timer_for_gender.Tick += new System.EventHandler(this.timer_for_gender_Tick);
            // 
            // uC_checkbox_female
            // 
            this.uC_checkbox_female._value = Project_Pulse.DL.LOOKUP.NULL;
            this.uC_checkbox_female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.uC_checkbox_female.Location = new System.Drawing.Point(229, -9);
            this.uC_checkbox_female.Name = "uC_checkbox_female";
            this.uC_checkbox_female.Size = new System.Drawing.Size(123, 60);
            this.uC_checkbox_female.TabIndex = 13;
            // 
            // uC_checkbox_male
            // 
            this.uC_checkbox_male._value = Project_Pulse.DL.LOOKUP.NULL;
            this.uC_checkbox_male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.uC_checkbox_male.Location = new System.Drawing.Point(101, -10);
            this.uC_checkbox_male.Name = "uC_checkbox_male";
            this.uC_checkbox_male.Size = new System.Drawing.Size(178, 60);
            this.uC_checkbox_male.TabIndex = 14;
            this.uC_checkbox_male.Load += new System.EventHandler(this.uC_checkbox1_Load);
            // 
            // UC_Gender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.uC_checkbox_female);
            this.Controls.Add(this.uC_checkbox_male);
            this.Controls.Add(this.label_for_gender);
            this.DoubleBuffered = true;
            this.Name = "UC_Gender";
            this.Size = new System.Drawing.Size(383, 41);
            this.Load += new System.EventHandler(this.UC_Gender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_for_gender;
        private System.Windows.Forms.Timer timer_for_gender;
        private UC_checkbox uC_checkbox_female;
        private UC_checkbox uC_checkbox_male;
    }
}
