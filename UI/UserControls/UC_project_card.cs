using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.UI.FORMS;
using Project_Pulse.UI.UserControls.Advisor__;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_project_card : UserControl
    {
        public bool checked_;
        public Project project_;

        public UC_project_card(Project project, bool isJoin)
        {
            InitializeComponent();
            project_ = project;
            setDefaultColor();
            checked_ = false;
        }

        public UC_project_card(Project project)
        {
            InitializeComponent();
            project_ = project;
            label_id.Text = "project# " + project.ID.ToString();
            label_title.Text = project.Title;
            label_description.Text = project.Description;
            setDefaultColor();
            checked_ = false;
        }
        public void setHoverEffectAndClick()
        {
            // HOVER 
            panel_side_bar.MouseEnter += hover_mouseEnter;
            panel_text_holder.MouseEnter += hover_mouseEnter;
            label_description.MouseEnter += hover_mouseEnter;
            label_title.MouseEnter += hover_mouseEnter;
            label_id.MouseEnter += hover_mouseEnter;
            PB_project.MouseEnter += hover_mouseEnter;
            panel_side_bar.MouseLeave += hover_mouseLeave;
            panel_text_holder.MouseLeave += hover_mouseLeave;
            label_description.MouseLeave += hover_mouseLeave;
            label_title.MouseLeave += hover_mouseLeave;
            PB_project.MouseLeave += hover_mouseLeave;
            label_id.MouseLeave += hover_mouseLeave;
            panel_side_bar.Click += click;
            panel_text_holder.Click += click;
            label_description.Click += click;
            label_title.Click += click;
            PB_project.Click += click;
            label_id.Click += click;
        }
        public void setDefaultColor()
        {
            this.BackColor = Color_.dark_main;
            label_id.BackColor = Color_.dark_main;
            panel_side_bar.BackColor = Color_.dark_main;
            panel_text_holder.BackColor = Color_.dark_main;
            label_description.BackColor = Color_.dark_main;
            label_title.BackColor = Color_.dark_main;
            PB_project.BackColor = Color_.dark_main;
            label_description.ForeColor = Color_.mid_light;
            label_id.ForeColor = Color_.mid_light;
            label_title.ForeColor = Color_.mid_light;
        }
        public void setCheckedColor()
        {
            this.BackColor = Color_.colorful_main;
            label_title.BackColor = Color_.dark_main;
            panel_side_bar.BackColor = Color_.dark_main;
            panel_text_holder.BackColor = Color_.dark_main;
            label_description.BackColor = Color_.dark_main;
            label_title.BackColor = Color_.dark_main;
            PB_project.BackColor = Color_.dark_main;
            label_description.ForeColor = Color_.mid_light;
            label_title.ForeColor = Color_.mid_light;
            label_title.ForeColor = Color_.mid_light;
        }
        void click(object sender, EventArgs e)
        {
            checked_ = !checked_;
            if (checked_)
            {
                setCheckedColor();

            }
            else
            {
                setDefaultColor();
            }
            if (this.Parent?.Parent?.Parent is UC_manage_Projects_ manageProjects)
            {
                manageProjects.updateCheckedProjects(this);
            }
        }

        void hover_mouseEnter(object sender, EventArgs e)
        {
            setCheckedColor();
        }
        void hover_mouseLeave(object sender, EventArgs e)
        {
            if (!checked_)
                setDefaultColor();
        }

        private void Select_Project_Click(object sender, EventArgs e)
        {
            if (this.Parent?.Parent?.Parent is UC_manage_Projects_ manageProjects)
            {
                form_credentials selectProjectConfomation = new form_credentials(project_, ACTION.PROJECT_JOIN);
                selectProjectConfomation.Show();
            }
        }
    }
}
