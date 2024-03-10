namespace Project_Pulse.UI.UserControls
{
    partial class UC_search_result
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
            this.btn_back = new Guna.UI.WinForms.GunaButton();
            this.label_search_results = new System.Windows.Forms.Label();
            this.label_numberOf_selected_students = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // FL_holder
            // 
            this.FL_holder.AutoScroll = true;
            this.FL_holder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FL_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_holder.Location = new System.Drawing.Point(0, 53);
            this.FL_holder.Name = "FL_holder";
            this.FL_holder.Size = new System.Drawing.Size(773, 506);
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
            this.panel1.Size = new System.Drawing.Size(773, 559);
            this.panel1.TabIndex = 1;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.panel_header.Controls.Add(this.btn_back);
            this.panel_header.Controls.Add(this.label_search_results);
            this.panel_header.Controls.Add(this.label_numberOf_selected_students);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(773, 53);
            this.panel_header.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.AnimationHoverSpeed = 0.07F;
            this.btn_back.AnimationSpeed = 0.03F;
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_back.BorderColor = System.Drawing.Color.Black;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_back.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_back.Image = global::Project_Pulse.Properties.Resources.close_dark;
            this.btn_back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_back.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_back.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_back.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_back.OnPressedColor = System.Drawing.Color.Black;
            this.btn_back.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_back.Size = new System.Drawing.Size(79, 53);
            this.btn_back.TabIndex = 17;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label_search_results
            // 
            this.label_search_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.label_search_results.CausesValidation = false;
            this.label_search_results.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_search_results.Location = new System.Drawing.Point(209, 11);
            this.label_search_results.Margin = new System.Windows.Forms.Padding(3);
            this.label_search_results.Name = "label_search_results";
            this.label_search_results.Size = new System.Drawing.Size(332, 33);
            this.label_search_results.TabIndex = 13;
            this.label_search_results.Text = "SearchResults";
            this.label_search_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numberOf_selected_students
            // 
            this.label_numberOf_selected_students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.label_numberOf_selected_students.CausesValidation = false;
            this.label_numberOf_selected_students.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberOf_selected_students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_numberOf_selected_students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_numberOf_selected_students.Location = new System.Drawing.Point(401, 10);
            this.label_numberOf_selected_students.Margin = new System.Windows.Forms.Padding(3);
            this.label_numberOf_selected_students.Name = "label_numberOf_selected_students";
            this.label_numberOf_selected_students.Size = new System.Drawing.Size(45, 33);
            this.label_numberOf_selected_students.TabIndex = 14;
            this.label_numberOf_selected_students.Text = "0";
            this.label_numberOf_selected_students.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_numberOf_selected_students.Visible = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 30;
            this.gunaElipse2.TargetControl = this.panel1;
            // 
            // UC_search_result
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UC_search_result";
            this.Size = new System.Drawing.Size(773, 559);
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FL_holder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_header;
        private Guna.UI.WinForms.GunaButton btn_back;
        private System.Windows.Forms.Label label_search_results;
        private System.Windows.Forms.Label label_numberOf_selected_students;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}
