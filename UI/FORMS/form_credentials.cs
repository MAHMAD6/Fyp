using Project_Pulse.BL;
using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.UI.UserControls;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_credentials : Form
    {
        #region CONSTRUCTORS
        public form_credentials()
        {
            InitializeComponent();
        }
        public form_credentials(Project project, ACTION action)
        {
            InitializeComponent();
            this.BackColor = Color_.colorful_main;
            if (ACTION.PROJECT_JOIN == action)
            {
                join_Project(project);
            }
        }
        public form_credentials(Project project)
        {
            InitializeComponent();
            this.BackColor = Color_.colorful_main;
            UC_Add_Update_Project_and_evaluation updateProject = new UC_Add_Update_Project_and_evaluation(ACTION.PROJECT_UPDATE, project);
            setMenu(updateProject);
        }
        public form_credentials(ACTION action)
        {
            InitializeComponent();
            ActionManipulator(action, null);
            this.BackColor = Color_.colorful_main;

        }
        public form_credentials(ACTION action, Advisor advisor)
        {
            InitializeComponent();
            ActionManipulator(action, advisor);

        }
        public form_credentials(Student student)
        {
            InitializeComponent();

            UC_Student_Details_card newCard = new UC_Student_Details_card(student);
            newCard.Dock = DockStyle.Fill;
            this.Controls.Add(newCard);
        }
        public form_credentials(Advisor advisor)
        {
            InitializeComponent();
            UC_Student_Details_card newCard = new UC_Student_Details_card(advisor);
            newCard.Dock = DockStyle.Fill;
            this.Controls.Add(newCard);
        }
        #endregion 


        void ActionManipulator(ACTION action, BL.Advisor advisor)
        {
            if (action == ACTION.ADD_ADVISOR)
            {
                Add_Advisor();
            }
            else if (action == ACTION.UPDATE_ADVISOR)
            {
                Update_Advisor(advisor);
            }
            else if (action == ACTION.PROJECT_ADD)
            {
                Add_Project(action);
            }
            else if (action == ACTION.EVALUATION_NEW)
            {
                take_evaluation(action);
            }

        }
        void take_evaluation(ACTION action)
        {
            setMenu(new UC_Add_Update_Project_and_evaluation(action));// using uc_add_update for evaluation also
        }
        void join_Project(Project project)
        {
            setMenu(new UC_Add_Update_Project_and_evaluation(ACTION.PROJECT_JOIN, project));
        }



        void Add_Project(ACTION action)
        {

            setMenu(new UC_Add_Update_Project_and_evaluation(action));
        }

        // ADVISOR
        void Update_Advisor(BL.Advisor advisor)
        {
            setSize(498, 663);
            setMenu(new UC_Advisor_ADD_update_card(ACTION.UPDATE_ADVISOR, advisor));

        }
        void Add_Advisor()
        {
            setSize(498, 663);
            setMenu(new UC_Advisor_ADD_update_card(ACTION.ADD_ADVISOR));

        }

        public void setSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width, height);
        }
        public void setMenu(Control control)
        {
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }
    }

}
