using Project_Pulse.BL;
using Project_Pulse.DL;
using Project_Pulse.UI.FORMS;
using Project_Pulse.UI.UserControls.Advisor;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class
        UC_data_tile : UserControl
    {
        public Student Student_;
        public BL.Advisor Advisor_;
        public bool Checked_;
        public UC_data_tile()
        {
            InitializeComponent();
            constructorDAT();
        }
        public UC_data_tile(Student student)
        {
            InitializeComponent();
            Advisor_ = null;
            Student_ = student;
            label_email.Text = student.Email;
            label_first_name.Text = student.FirstName;
            label_ID.Text = student.ID.ToString();
            PB_profile.Image = student.Img;
            constructorDAT();
        }
        public UC_data_tile(BL.Advisor advisor)
        {
            InitializeComponent();
            Student_ = null;
            Advisor_ = advisor;
            label_email.Text = advisor.Email;
            label_first_name.Text = advisor.FirstName;
            label_ID.Text = advisor.ID.ToString();
            PB_profile.Image = advisor.Img;
            constructorDAT();
        }
        public void SetHoverAndClickEffect(bool val)
        {
            if (val)
            {
                // hover
                panel_bg.MouseEnter += hover_mouseEnter;
                panel_bg.MouseLeave += hover_mouseLeave;
                label_email.MouseLeave += hover_mouseLeave;
                label_email.MouseEnter += hover_mouseEnter;
                label_first_name.MouseLeave += hover_mouseLeave;
                label_first_name.Enter += hover_mouseEnter;
                label_ID.MouseLeave += hover_mouseLeave;
                label_ID.MouseEnter += hover_mouseEnter;
                PB_profile.MouseEnter += hover_mouseEnter;
                PB_profile.MouseLeave += hover_mouseLeave;
                // click
                panel_bg.Click += click_TILE;
                label_email.Click += click_TILE;
                label_first_name.Click += click_TILE;
                label_ID.Click += click_TILE;
                PB_profile.Click += click_TILE;
                // Double click
                panel_bg.DoubleClick += doubleClick_TILE;
                label_email.Click += click_TILE;
                label_first_name.Click += click_TILE;
                label_ID.Click += click_TILE;
                PB_profile.Click += click_TILE;
            }
        }
        void constructorDAT()// basic initializing
        {
            setDefaultColor();
            Checked_ = false;
        }
        void hover_mouseEnter(object sender, EventArgs e)
        {
            setCheckedColor();
        }
        void hover_mouseLeave(object sender, EventArgs e)
        {
            if (!Checked_)
                setDefaultColor();
        }
        public void setDefaultColor()
        {
            this.BackColor = Color_.dark_main;
            panel_bg.BackColor = Color_.dark_main;
            panel_bg.ForeColor = Color_.mid_light;
            label_email.BackColor = Color_.dark_main;
            label_email.ForeColor = Color_.mid_light;
            label_first_name.BackColor = Color_.dark_main;
            label_first_name.ForeColor = Color_.light;
            label_ID.BackColor = Color_.dark_main;
            label_ID.ForeColor = Color_.green;
            PB_profile.BackColor = Color_.dark_main;

        }
        public void setCheckedColor()
        {
            this.BackColor = Color_.colorful_main;
            panel_bg.BackColor = Color_.light;
            panel_bg.ForeColor = Color_.dark_main;
            label_email.BackColor = Color_.light;
            label_email.ForeColor = Color_.dark_main;
            label_first_name.BackColor = Color_.light;
            label_first_name.ForeColor = Color_.dark_main;
            label_ID.BackColor = Color_.light;
            label_ID.ForeColor = Color_.green_mid;
            PB_profile.BackColor = Color_.light;
        }
        void click_TILE(object sender, EventArgs e)
        {
            Checked_ = !Checked_;
            if (Checked_)
            {
                setCheckedColor();
            }
            else
            {
                setDefaultColor();
            }
            if (Student_ != null && this.Parent?.Parent?.Parent is UC_manage_Students manageSTudents)
            {
                manageSTudents.updateCheckedStudent(this);
            }
            if (Advisor_ != null && this.Parent?.Parent?.Parent is UC_manage_Advisor manage_Advisor)
            {
                manage_Advisor.updateCheckedStudent(this);
            }
        }
        void doubleClick_TILE(object sender, EventArgs args)
        {
            if (Advisor_ != null)
            {
                form_credentials form_Credentials = new form_credentials(Advisor_);
                form_Credentials.Show();
            }
            else if (Student_ != null)
            {

                form_credentials form_Credentials = new form_credentials(Student_);
                form_Credentials.Show();
            }

        }
    }
}
