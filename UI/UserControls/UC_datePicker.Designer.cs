namespace Project_Pulse.UI.UserControls
{
    partial class UC_datePicker
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
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label_for_date_message = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.datePicker.BorderRadius = 0;
            this.datePicker.Font = new System.Drawing.Font("Banana Grotesk Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.FormatCustom = "dd/mm/yyyy";
            this.datePicker.Location = new System.Drawing.Point(159, 7);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(226, 41);
            this.datePicker.TabIndex = 0;
            this.datePicker.Value = new System.DateTime(2024, 2, 27, 13, 53, 37, 551);
            // 
            // label_for_date_message
            // 
            this.label_for_date_message.AutoSize = true;
            this.label_for_date_message.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_for_date_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.label_for_date_message.Location = new System.Drawing.Point(-10, 11);
            this.label_for_date_message.Name = "label_for_date_message";
            this.label_for_date_message.Padding = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.label_for_date_message.Size = new System.Drawing.Size(130, 32);
            this.label_for_date_message.TabIndex = 10;
            this.label_for_date_message.Text = "Pick Date";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.datePicker;
            // 
            // UC_datePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.label_for_date_message);
            this.Controls.Add(this.datePicker);
            this.DoubleBuffered = true;
            this.Name = "UC_datePicker";
            this.Size = new System.Drawing.Size(404, 54);
            this.MouseEnter += new System.EventHandler(this.UC_datePicker_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_datePicker_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuDatepicker datePicker;
        public System.Windows.Forms.Label label_for_date_message;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
