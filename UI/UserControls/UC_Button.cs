using Project_Pulse.DL;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_Button : UserControl
    {
        bool isClicked;
        ACTION action_;
        public UC_Button(string text, Image normal, Image hover, Color foreColor)
        {
            InitializeComponent();
            btn.Text = text;
            btn.Image = normal;
            btn.OnHoverImage = hover;
            isClicked = false;
            setForeColor_normalState(foreColor);
        }
        public UC_Button(string text, Image normal, Image hover, ACTION action)
            : this(text, normal, hover)
        {
            InitializeComponent();
            action_ = action;
        }
        public UC_Button(string text, Image normal, Image hover)
        {
            InitializeComponent();
            btn.Text = text;
            btn.Image = normal;
            btn.OnHoverImage = hover;
            isClicked = false;
        }
        public void setForeColor_normalState(Color color)
        {
            this.btn.BaseColor = color;
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            isClicked = true;
            if (ACTION.PROJECT_JOIN == action_)
            {
                if (this.Parent?.Parent is UC_Add_Update_Project_and_evaluation parent)
                {
                    parent.sendRequestButton_click();
                }

            }

            else if (ACTION.PROJECT_ADD == action_)
            {
                if (this.Parent?.Parent is UC_Add_Update_Project_and_evaluation uC_Add_Update_Project)
                {
                    uC_Add_Update_Project.btn_Add_Project_clicked();
                }
            }
            else if (ACTION.PROJECT_UPDATE == action_)
            {
                if (this.Parent.Parent is UC_Add_Update_Project_and_evaluation update)
                {
                    update.btn_UPDATE_Project_clicked();
                }
            }
            else
            {


                if (this.Parent != null && this.Parent.Parent != null && this.Parent.Parent is UC_Advisor_ADD_update_card addAdvisor)
                {
                    addAdvisor.btn_Add_Advisor_Clicked();
                }
            }
        }
        public bool IS_clicked()
        {
            return isClicked;
        }
        public void SET_isClicked(bool val)
        {
            isClicked = val;
        }
    }
}
