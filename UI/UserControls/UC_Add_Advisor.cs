using Project_Pulse.BL;
using Project_Pulse.DL;
using Project_Pulse.Properties;
using Project_Pulse.UI.FORMS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_Advisor_ADD_update_card : UserControl
    {
        UC_TextBox email;
        UC_TextBox contact;
        UC_TextBox salary;
        UC_TextBox designation;
        UC_datePicker DOB;
        UC_Button addAdvisor_btn;
        UC_Gender gender;
        UC_TextBox firstName;
        UC_TextBox lastName;
        ACTION Action_;
        BL.Advisor Advisor_;
        public UC_Advisor_ADD_update_card(ACTION action)
        {
            InitializeComponent();
            Add_components();
            Action_ = action;

        }
        public UC_Advisor_ADD_update_card(ACTION action, BL.Advisor advisor_)
        {
            InitializeComponent();
            Add_components();
            Action_ = action;
            Advisor_ = advisor_;
        }


        void Add_components()
        {
            firstName = new UC_TextBox("first name");
            lastName = new UC_TextBox("last name");
            email = new UC_TextBox("email");
            contact = new UC_TextBox("contact");
            salary = new UC_TextBox("salary");
            designation = new UC_TextBox("designation");
            DOB = new UC_datePicker("date of birth");
            gender = new UC_Gender();
            addAdvisor_btn = new UC_Button("Add", Resources.Sign_up_light, Resources.sign_up_dark);

            this.Size = new System.Drawing.Size(494, 659);
            flowLayoutPanel.Controls.Add(firstName);
            flowLayoutPanel.Controls.Add(lastName);
            flowLayoutPanel.Controls.Add(email);
            flowLayoutPanel.Controls.Add(contact);
            flowLayoutPanel.Controls.Add(salary);
            flowLayoutPanel.Controls.Add(designation);
            flowLayoutPanel.Controls.Add(DOB);
            flowLayoutPanel.Controls.Add(gender);
            flowLayoutPanel.Controls.Add(addAdvisor_btn);
        }
        public void btn_Add_Advisor_Clicked()
        {
            string firstname_string = firstName.getDetails();
            string lastname_string = lastName.getDetails();
            string email_string = email.getDetails();
            string contact_string = contact.getDetails();
            DateTime datetime = DOB.GetDate_DateTime();
            int gender_int = gender.GetValue();
            string designation_string = designation.getDetails();
            string salary_string = salary.getDetails();
            if (Validation.Name(firstname_string))
            {
                firstName.SetErrorState(false);
                if (Validation.Name(lastname_string))
                {
                    lastName.SetErrorState(false);
                    if (Validation.Email(email_string))
                    {
                        email.SetErrorState(false);
                        if (Validation.Contact(contact_string))
                        {
                            contact.SetErrorState(false);
                            if (Validation.Salary(salary_string))
                            {
                                salary.SetErrorState(false);
                                if (Validation.Designation(designation_string))
                                {
                                    designation.SetErrorState(false);
                                    if (Validation.Date(datetime))
                                    {
                                        if (Action_ == ACTION.UPDATE_ADVISOR || !PersonCRUD.isAlreadyPresent_Email(email_string))
                                        {

                                            if (Action_ == ACTION.UPDATE_ADVISOR)
                                            {
                                                Advisor_.FirstName = firstname_string;
                                                Advisor_.LastName = lastname_string;
                                                Advisor_.Email = email_string;
                                                Advisor_.Birthday = datetime;
                                                Advisor_.Contact = contact_string;
                                                Advisor_.Designation = int.Parse(designation_string);
                                                Advisor_.Salary = float.Parse(salary_string);
                                                Advisor_.Gender = gender_int;
                                                AdvisorCRUD.UpdateAdvisor(Advisor_);
                                                PersonCRUD.UpdatePerson((Person)Advisor_);
                                            }
                                            else
                                            {
                                                // Creating of Person Object
                                                Person person = new Person(firstname_string, lastname_string, email_string, contact_string, datetime, gender_int);
                                                PersonCRUD.AddPerson(person);
                                                person.ID = PersonCRUD.GetId(person.FirstName, person.LastName, person.Email);
                                                BL.Advisor advisor = new BL.Advisor(int.Parse(designation_string), float.Parse(salary_string), person);
                                                AdvisorCRUD.AddAdvisor(advisor);
                                            }

                                        }
                                        else // repeated email
                                        {
                                            form_message repeatedEmail = new form_message("Incorrect Email", "Email  already  exists:  typed ", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                                            repeatedEmail.Show();
                                            close_form();
                                        }
                                    }
                                    else // incorrect date
                                    {
                                        form_message incorrectDate = new form_message("Incorrect Date", "you  type  date:  invalid !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                                        incorrectDate.Show();

                                    }
                                }
                                else// incorrect designation
                                {
                                    designation.SetErrorState(true);

                                }
                            }
                            else// incorrect salary
                            {
                                salary.SetErrorState(true);

                            }
                        }
                        else // incorrect contact
                        {
                            contact.SetErrorState(true);

                        }

                    }
                    else// incorrect Email
                    {
                        email.SetErrorState(true);
                    }


                }
                else // incorrect last name
                {
                    lastName.SetErrorState(true);
                }




            }
            else // incorrect first name
            {
                firstName.SetErrorState(true);
            }
        }

        void close_form()
        {
            if (this.Parent is form_credentials form)
            {
                form.Close();
            }
        }
        private void btn_close_Click(object sender, System.EventArgs e)
        {
            close_form();
        }
    }
}
