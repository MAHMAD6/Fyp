namespace Project_Pulse.UI.UserControls.Advisor
{
    partial class UC_manage_Students
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FL_students_holder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_loadmore = new System.Windows.Forms.Panel();
            this.btn_loadMore = new Guna.UI2.WinForms.Guna2Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.TB_search_student = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.label_heading_double_click = new System.Windows.Forms.Label();
            this.label_Selected = new System.Windows.Forms.Label();
            this.PB_unSelect = new System.Windows.Forms.PictureBox();
            this.label_numberOf_selected_students = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.FL_students_holder.SuspendLayout();
            this.panel_loadmore.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_unSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.FL_students_holder);
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 547);
            this.panel1.TabIndex = 0;
            // 
            // FL_students_holder
            // 
            this.FL_students_holder.AutoScroll = true;
            this.FL_students_holder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.FL_students_holder.Controls.Add(this.panel_loadmore);
            this.FL_students_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FL_students_holder.Location = new System.Drawing.Point(0, 53);
            this.FL_students_holder.Name = "FL_students_holder";
            this.FL_students_holder.Size = new System.Drawing.Size(761, 494);
            this.FL_students_holder.TabIndex = 4;
            // 
            // panel_loadmore
            // 
            this.panel_loadmore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.panel_loadmore.Controls.Add(this.btn_loadMore);
            this.panel_loadmore.Enabled = false;
            this.panel_loadmore.Location = new System.Drawing.Point(3, 3);
            this.panel_loadmore.Name = "panel_loadmore";
            this.panel_loadmore.Size = new System.Drawing.Size(761, 53);
            this.panel_loadmore.TabIndex = 4;
            this.panel_loadmore.Visible = false;
            // 
            // btn_loadMore
            // 
            this.btn_loadMore.CheckedState.Parent = this.btn_loadMore;
            this.btn_loadMore.CustomImages.Parent = this.btn_loadMore;
            this.btn_loadMore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_loadMore.Font = new System.Drawing.Font("Nexa Heavy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadMore.ForeColor = System.Drawing.Color.White;
            this.btn_loadMore.HoverState.Parent = this.btn_loadMore;
            this.btn_loadMore.Location = new System.Drawing.Point(302, 7);
            this.btn_loadMore.Name = "btn_loadMore";
            this.btn_loadMore.ShadowDecoration.Parent = this.btn_loadMore;
            this.btn_loadMore.Size = new System.Drawing.Size(116, 43);
            this.btn_loadMore.TabIndex = 0;
            this.btn_loadMore.Text = "Load More";
            this.btn_loadMore.Click += new System.EventHandler(this.btn_loadMore_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.panel_header.Controls.Add(this.TB_search_student);
            this.panel_header.Controls.Add(this.btn_delete);
            this.panel_header.Controls.Add(this.label_heading_double_click);
            this.panel_header.Controls.Add(this.label_Selected);
            this.panel_header.Controls.Add(this.PB_unSelect);
            this.panel_header.Controls.Add(this.label_numberOf_selected_students);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(761, 53);
            this.panel_header.TabIndex = 3;
            // 
            // TB_search_student
            // 
            this.TB_search_student.BackColor = System.Drawing.Color.White;
            this.TB_search_student.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_search_student.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.TB_search_student.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_search_student.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.TB_search_student.Location = new System.Drawing.Point(506, 13);
            this.TB_search_student.Name = "TB_search_student";
            this.TB_search_student.PasswordChar = '\0';
            this.TB_search_student.SelectedText = "";
            this.TB_search_student.Size = new System.Drawing.Size(170, 30);
            this.TB_search_student.TabIndex = 18;
            this.TB_search_student.Text = "Search Student";
            this.TB_search_student.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_search_student_KeyDown);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(183)))), ((int)(((byte)(20)))));
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Banana Grotesk Extralight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.Image = global::Project_Pulse.Properties.Resources.close_dark;
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_delete.Location = new System.Drawing.Point(682, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.btn_delete.OnHoverImage = global::Project_Pulse.Properties.Resources.close_light;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(79, 53);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label_heading_double_click
            // 
            this.label_heading_double_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.label_heading_double_click.CausesValidation = false;
            this.label_heading_double_click.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading_double_click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_heading_double_click.Location = new System.Drawing.Point(-3, 10);
            this.label_heading_double_click.Margin = new System.Windows.Forms.Padding(3);
            this.label_heading_double_click.Name = "label_heading_double_click";
            this.label_heading_double_click.Size = new System.Drawing.Size(501, 33);
            this.label_heading_double_click.TabIndex = 13;
            this.label_heading_double_click.Text = "Double click to Preview a student";
            this.label_heading_double_click.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Selected
            // 
            this.label_Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(9)))), ((int)(((byte)(81)))));
            this.label_Selected.CausesValidation = false;
            this.label_Selected.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.label_Selected.Location = new System.Drawing.Point(270, 10);
            this.label_Selected.Margin = new System.Windows.Forms.Padding(3);
            this.label_Selected.Name = "label_Selected";
            this.label_Selected.Size = new System.Drawing.Size(129, 33);
            this.label_Selected.TabIndex = 16;
            this.label_Selected.Text = "Selected:";
            this.label_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Selected.Visible = false;
            // 
            // PB_unSelect
            // 
            this.PB_unSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_unSelect.Image = global::Project_Pulse.Properties.Resources.close_circle_light;
            this.PB_unSelect.Location = new System.Drawing.Point(13, 8);
            this.PB_unSelect.Name = "PB_unSelect";
            this.PB_unSelect.Size = new System.Drawing.Size(66, 39);
            this.PB_unSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_unSelect.TabIndex = 15;
            this.PB_unSelect.TabStop = false;
            this.PB_unSelect.Visible = false;
            this.PB_unSelect.Click += new System.EventHandler(this.PB_unSelect_Click);
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
            // UC_manage_Students
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nexa Heavy", 11F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(29)))));
            this.Name = "UC_manage_Students";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(773, 559);
            this.panel1.ResumeLayout(false);
            this.FL_students_holder.ResumeLayout(false);
            this.panel_loadmore.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_unSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.FlowLayoutPanel FL_students_holder;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox PB_unSelect;
        private System.Windows.Forms.Label label_numberOf_selected_students;
        private System.Windows.Forms.Label label_heading_double_click;
        private System.Windows.Forms.Panel panel_loadmore;
        private Guna.UI2.WinForms.Guna2Button btn_loadMore;
        private System.Windows.Forms.Label label_Selected;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaLineTextBox TB_search_student;
    }
}
