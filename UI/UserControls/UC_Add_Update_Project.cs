using Project_Pulse.BL;
using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using Project_Pulse.Properties;
using Project_Pulse.UI.FORMS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_Add_Update_Project_and_evaluation : UserControl
    {
        UC_TextBox title_or_evalution_name;
        UC_TextBox description_or_total_marks;
        UC_TextBox GroupID;
        UC_Button sendRequestbutton;
        ACTION Action_;
        Project project_;
        UC_Button addProject_btn;

        // Advisors
        UC_TextBox main_advisor_id_or_total_weightage;
        UC_TextBox main_advisor_role;
        UC_TextBox co_advisor_id_or_obtained_marks;
        UC_TextBox co_advisor_role;
        UC_TextBox industry_advisor_id_or_group_id;
        UC_TextBox industry_advisor_role;
        public UC_Add_Update_Project_and_evaluation(ACTION action, Project project)
        {
            InitializeComponent();
            Action_ = action;
            project_ = project;
            if (action == ACTION.PROJECT_UPDATE)
            {

                title_or_evalution_name = new UC_TextBox("Project Title");
                title_or_evalution_name.SetSize(350, 43);
                flowLayoutPanel.Controls.Add(title_or_evalution_name);
                description_or_total_marks = new UC_TextBox("Enter Project description");
                description_or_total_marks.SetSize(350, 200);
                flowLayoutPanel.Controls.Add(description_or_total_marks);
                addProject_btn = new UC_Button("Update", Resources.Sign_up_light, Resources.sign_up_dark, ACTION.PROJECT_UPDATE);
                flowLayoutPanel.Controls.Add(addProject_btn);
            }
            else if (action == ACTION.PROJECT_JOIN)
            {
                GroupID = new UC_TextBox("Enter Group Id");
                flowLayoutPanel.Controls.Add(GroupID);
                sendRequestbutton = new UC_Button("Send Request", Resources.Sign_up_light, Resources.sign_up_dark, ACTION.PROJECT_JOIN);
                flowLayoutPanel.Controls.Add(sendRequestbutton);


            }
        }
        public UC_Add_Update_Project_and_evaluation(ACTION action)
        {
            InitializeComponent();
            Action_ = action;
            if (action == ACTION.PROJECT_UPDATE)
            {
                title_or_evalution_name = new UC_TextBox("Project Title");
                title_or_evalution_name.SetSize(350, 43);
                flowLayoutPanel.Controls.Add(title_or_evalution_name);
                description_or_total_marks = new UC_TextBox("Enter Project description");
                description_or_total_marks.SetSize(350, 200);
                flowLayoutPanel.Controls.Add(description_or_total_marks);



                addProject_btn = new UC_Button("Add", Resources.Sign_up_light, Resources.sign_up_dark, ACTION.PROJECT_ADD);
                flowLayoutPanel.Controls.Add(addProject_btn);
            }
            else if (action == ACTION.PROJECT_ADD)
            {
                flowLayoutPanel.AutoScroll = true;
                Add_Project();
            }
            else if (action == ACTION.EVALUATION_NEW)
            {
                flowLayoutPanel.AutoScroll = true;
                take_evaluation();
            }
        }
        void take_evaluation()
        {
            title_or_evalution_name = new UC_TextBox("Evaluation Name");
            title_or_evalution_name.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(title_or_evalution_name);

            industry_advisor_id_or_group_id = new UC_TextBox("Group Id");
            industry_advisor_id_or_group_id.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(industry_advisor_id_or_group_id);

            description_or_total_marks = new UC_TextBox("Total Marks");
            description_or_total_marks.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(description_or_total_marks);

            main_advisor_id_or_total_weightage = new UC_TextBox("Total Weightage");
            main_advisor_id_or_total_weightage.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(main_advisor_id_or_total_weightage);

            co_advisor_id_or_obtained_marks = new UC_TextBox("Obtained Marks");
            co_advisor_id_or_obtained_marks.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(co_advisor_id_or_obtained_marks);

            addProject_btn = new UC_Button("Confirm", Resources.Sign_up_light, Resources.sign_up_dark, ACTION.PROJECT_ADD);
            flowLayoutPanel.Controls.Add(addProject_btn);
        }
        void Add_Project()
        {
            title_or_evalution_name = new UC_TextBox("Project Title");
            title_or_evalution_name.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(title_or_evalution_name);
            description_or_total_marks = new UC_TextBox("Enter Project description");
            description_or_total_marks.SetSize(350, 83);
            flowLayoutPanel.Controls.Add(description_or_total_marks);

            main_advisor_id_or_total_weightage = new UC_TextBox("Main Advisor id");
            main_advisor_id_or_total_weightage.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(main_advisor_id_or_total_weightage);


            co_advisor_id_or_obtained_marks = new UC_TextBox("Co Advisor id");
            co_advisor_id_or_obtained_marks.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(co_advisor_id_or_obtained_marks);


            industry_advisor_id_or_group_id = new UC_TextBox("Industry Advisor id");
            industry_advisor_id_or_group_id.SetSize(350, 43);
            flowLayoutPanel.Controls.Add(industry_advisor_id_or_group_id);




            addProject_btn = new UC_Button("Add", Resources.Sign_up_light, Resources.sign_up_dark, ACTION.PROJECT_ADD);
            flowLayoutPanel.Controls.Add(addProject_btn);


        }
        public void sendRequestButton_click()
        {
            //bool isAreadyPresent = false;

            //for(int i = 0; i < AdvisorCRUD.requests.Count; i++)
            //{
            //    if (AdvisorCRUD.requests[i].ProjectID == project_ )
            //}
            AdvisorCRUD.requests.Add(new GroupProject(int.Parse(GroupID.getDetails()), project_.ID, DateTime.Now));
            var form = new form_message("Success", "Send  your  request:  for  approval", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Project_Pulse.Properties.Resources.close_circle_light);
            form.Show();
        }













        bool containsError = false;

        public void btn_Add_Project_clicked()
        {
            containsError = false;

            if (Action_ == ACTION.EVALUATION_NEW)
            {
                string evaluation_name_string = title_or_evalution_name.getDetails();
                string totalMarks_string = description_or_total_marks.getDetails();
                string obtainedMarks_string = co_advisor_id_or_obtained_marks.getDetails();
                string totalWeightage_string = main_advisor_id_or_total_weightage.getDetails();
                string GroupID_string = industry_advisor_id_or_group_id.getDetails();
                if (Validation.isInteger(totalWeightage_string))
                {
                    main_advisor_id_or_total_weightage.SetErrorState(false);
                }
                else
                {
                    containsError = true;
                    main_advisor_id_or_total_weightage.SetErrorState(true);
                }
                if (Validation.RollNumberOrID(evaluation_name_string))
                {
                    title_or_evalution_name.SetErrorState(false);
                }
                else
                {
                    containsError = true;
                    title_or_evalution_name.SetErrorState(true);
                }
                if (Validation.isInteger(totalMarks_string))
                {
                    description_or_total_marks.SetErrorState(false);
                }
                else
                {
                    containsError = true;
                    description_or_total_marks.SetErrorState(true);
                }
                if (Validation.isInteger(obtainedMarks_string))
                {
                    co_advisor_id_or_obtained_marks.SetErrorState(false);
                }
                else
                {
                    co_advisor_id_or_obtained_marks.SetErrorState(true);
                    containsError = true;
                }
                if (Validation.isInteger(GroupID_string) && ProjectCRUD.IsGroupPresentInGroupProject(int.Parse(GroupID_string)))
                {
                    industry_advisor_id_or_group_id.SetErrorState(false);
                }
                else
                {
                    containsError = true;
                    industry_advisor_id_or_group_id.SetErrorState(true);
                }
                // more validations here
                if (!containsError)
                {
                    int totalmarks_int = int.Parse(totalMarks_string);
                    int obtainedmarks_int = int.Parse(obtainedMarks_string);
                    int totalWeightage_int = int.Parse(totalWeightage_string);
                    int groupid_int = int.Parse(GroupID_string);

                    Evaluation evaluation = new Evaluation(totalmarks_int, totalWeightage_int, evaluation_name_string);
                    EvaluationCRUD.InsertEvaluation(evaluation);
                    EvaluationCRUD.InsertGroupEvaluation(groupid_int, evaluation.ID, obtainedmarks_int, DateTime.Now);
                    form_close();

                }
























            }
            else
            {


                string title_string = title_or_evalution_name.getDetails();
                string description_string = description_or_total_marks.getDetails();

                string co_advisor_id_string = co_advisor_id_or_obtained_marks.getDetails();
                string main_advisor_id_string = main_advisor_id_or_total_weightage.getDetails();
                string industry_advisor_id_string = industry_advisor_id_or_group_id.getDetails();



                if (Validation.ProjectTitle(title_string))
                {
                    title_or_evalution_name.SetErrorState(false);
                    if (Validation.Description(description_string))
                    {
                        description_or_total_marks.SetErrorState(false);




                        // ADVISOR ID'S

                        if (Validation.isInteger(co_advisor_id_string) && AdvisorCRUD.isIdPresent(int.Parse(co_advisor_id_string)))
                        {
                            co_advisor_id_or_obtained_marks.SetErrorState(false);
                        }
                        else
                        {
                            containsError = true;
                            co_advisor_id_or_obtained_marks.SetErrorState(true);
                        }

                        if (Validation.isInteger(main_advisor_id_string) && AdvisorCRUD.isIdPresent(int.Parse(main_advisor_id_string)))
                        {
                            main_advisor_id_or_total_weightage.SetErrorState(false);
                        }
                        else
                        {
                            containsError = true;
                            main_advisor_id_or_total_weightage.SetErrorState(true);
                        }
                        if (Validation.isInteger(industry_advisor_id_string) && AdvisorCRUD.isIdPresent(int.Parse(industry_advisor_id_string)))
                        {
                            industry_advisor_id_or_group_id.SetErrorState(true);
                        }
                        else
                        {
                            containsError = true;
                            industry_advisor_id_or_group_id.SetErrorState(false);
                        }
                        if (int.Parse(main_advisor_id_string) == int.Parse(co_advisor_id_string) || int.Parse(co_advisor_id_string) == int.Parse(industry_advisor_id_string) || int.Parse(industry_advisor_id_string) == int.Parse(main_advisor_id_string))
                        {
                            containsError = true;
                            main_advisor_id_or_total_weightage.SetErrorState(true);
                            co_advisor_id_or_obtained_marks.SetErrorState(true);
                            industry_advisor_id_or_group_id.SetErrorState(true);
                        }

                        if (!containsError)
                        {
                            ProjectCRUD.AddProject(title_string, description_string);
                            int ProjectID = ProjectCRUD.GetID(title_string);

                            ProjectAdvisor mainAdvisor = new ProjectAdvisor(int.Parse(main_advisor_id_string), ProjectID, (int)LOOKUP.MAIN_ADVISOR, DateTime.Now);

                            ProjectAdvisor coAdvisor = new ProjectAdvisor(int.Parse(co_advisor_id_string), ProjectID, (int)LOOKUP.CO_ADVISOR, DateTime.Now);

                            ProjectAdvisor industryAdvisor = new ProjectAdvisor(int.Parse(industry_advisor_id_string), ProjectID, (int)LOOKUP.INDUSTRY_ADVISOR, DateTime.Now);

                            AdvisorCRUD.AddProjectAdvisor(mainAdvisor);
                            AdvisorCRUD.AddProjectAdvisor(coAdvisor);
                            AdvisorCRUD.AddProjectAdvisor(industryAdvisor);


                            form_close();
                        }
                        //else
                        //{
                        //    form_message incorrectAdvisorValue = new form_message("Incorrect Id", "you  typed  username  or  id:  incorrect !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                        //    incorrectAdvisorValue.Show();
                        //}





                    }
                    else // INCORRECT DESCRIPTION
                    {
                        description_or_total_marks.SetErrorState(true);
                    }
                }
                else// INCORRECT TITLE
                {
                    title_or_evalution_name.SetErrorState(true);
                }
            }

        }
        public void btn_UPDATE_Project_clicked()
        {
            string title_string = title_or_evalution_name.getDetails();
            string description_string = description_or_total_marks.getDetails();
            if (Validation.ProjectTitle(title_string))
            {
                title_or_evalution_name.SetErrorState(false);
                if (Validation.Description(description_string))
                {
                    description_or_total_marks.SetErrorState(false);
                    ProjectCRUD.UpdateProject(project_.ID, title_string, description_string);
                    form_close();
                }
                else // INCORRECT DESCRIPTION
                {
                    description_or_total_marks.SetErrorState(true);
                }
            }
            else// INCORRECT TITLE
            {
                title_or_evalution_name.SetErrorState(true);
            }
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            form_close();
        }
        public void form_close()
        {
            if (this.Parent is form_credentials form)
            {
                form.Close();
            }
        }
    }
}
