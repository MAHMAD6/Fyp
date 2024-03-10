using Project_Pulse.BL;
using Project_Pulse.DL;
using Project_Pulse.Properties;
using Project_Pulse.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            Color();
            sign_IN();
        }
        public void Color()
        {
            //panel_assistant.BackColor = Essentials.panel_dark;
            //panel_border_top.BackColor = Essentials.panel_border_top;

            //panel_close_line.BackColor = Essentials.Panel_light;
            //panel_dark_assistant.BackColor = Essentials.panel_dark;
            //panel_line_x.BackColor = Essentials.Panel_light;
            //panel_menu.BackColor = Essentials.panel_dark;
            //FL_panel_login.BackColor = Essentials.Panel_light;
            //label_menu.BackColor = label_menu.Parent.BackColor;
            //label_menu.ForeColor = Essentials.heading_;
            //PB_Assistant.BackColor = PB_Assistant.BackColor;

        }
        private void lginform_Load(object sender, EventArgs e)
        {
            timer_text_assistant.Start();
            UpdateLabel();
        }



        #region SIGN IN
        UC_TextBox usernameOrId;
        UC_Button signInBtn;
        UC_Button signUpBtn = null;
        System.Windows.Forms.Timer timer_sign_in;
        void sign_IN()
        {
            signIn = true;
            textChangeCount = 0;
            FL_panel_login.Controls.Clear();
            changeAssistant_activity(Resources.assistant_happy_1, 0);

            // Adding sign up fields
            System.Windows.Forms.Panel panel_to_fill_space = new System.Windows.Forms.Panel();
            panel_to_fill_space.Size = new System.Drawing.Size(676, 40);
            FL_panel_login.Controls.Add(panel_to_fill_space);

            uc_message_for_controls message_For_Controls = new uc_message_for_controls("Welcome Back!", 18, 65, 11);
            FL_panel_login.Controls.Add(message_For_Controls);

            usernameOrId = new UC_TextBox("username or id");
            FL_panel_login.Controls.Add(usernameOrId);

            signInBtn = new UC_Button("sign in", Resources.sign_in_light, Resources.sign_in_dark);
            FL_panel_login.Controls.Add(signInBtn);

            uc_message_for_controls or_message = new uc_message_for_controls("does not have a account?  then,", 12, 41, 11);
            or_message.SET_size(0, 0);
            FL_panel_login.Controls.Add(or_message);

            System.Drawing.Color btn_fore_color = new System.Drawing.Color();
            btn_fore_color = Color_.green_dark;
            signUpBtn = new UC_Button("sign up", Resources.Sign_up_light, Resources.sign_up_dark, btn_fore_color);

            FL_panel_login.Controls.Add(signUpBtn);

            // Text box

            usernameOrId.GET_Textbox().TextChanged += usernameOrId_textChanged;


            // setting timer for button click check
            timer_sign_in = new System.Windows.Forms.Timer();
            timer_sign_in.Tick += timer_sign_in_tick;
            timer_sign_in.Interval = 20;
            timer_sign_in.Start();

            // Setting up labels and assistant
            label_menu.Text = "Sign In";

        }

        void usernameOrId_textChanged(object sender, EventArgs e)
        {
            if (Validation.Name(usernameOrId.getDetails()))
            {
                usernameOrId.SetErrorState(false);
            }
            textChanged_toChangeAssistantActivity(TYPE.SIGN_ID);
        }




        void timer_sign_in_tick(object sender, EventArgs e)
        {
            if (signUpBtn.IS_clicked())
            {
                signUpBtn.SET_isClicked(false);
                timer_sign_in.Stop();
                sign_UP();
            }
            else if (signInBtn.IS_clicked())
            {
                signInBtn.SET_isClicked(false);
                string usernameOrId_ = usernameOrId.getDetails();
                Validation.RemoveSpaces_S_E(ref usernameOrId_);
                if (Validation.RollNumberOrID(usernameOrId_))
                {
                    usernameOrId.SetErrorState(false);
                    AdvisorCRUD.CurrentAdvisor = AdvisorCRUD.GetAdvisorByEmail(usernameOrId_);
                    StudentCRUD.CurrentStudent = StudentCRUD.GetStudentByEmail(usernameOrId_);
                    if (AdvisorCRUD.CurrentAdvisor != null)// Advisor login successfully
                    {
                        timer_sign_in.Stop();
                        Program.formToinvoke = TYPE.ADVISOR;
                        this.Close();
                    }
                    else if (StudentCRUD.CurrentStudent != null)
                    {
                        timer_sign_in.Stop();
                        Program.formToinvoke = TYPE.STUDENT;
                        this.Close();
                    }
                    else
                    {
                        form_message incorrectCredentials = new form_message("Incorrect Id", "you  typed  username  or  id:  incorrect !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                        incorrectCredentials.Show();
                    }
                }
                else
                {
                    usernameOrId.SetErrorState(true);

                }


            }
        }
        #endregion//---------------------------------------------




        #region SIGN UP
        UC_Button signupbtn;
        UC_TextBox firstName;
        UC_TextBox lastName;
        UC_TextBox email;
        UC_TextBox contact;
        UC_datePicker dateOfBirth;
        UC_Gender gender;
        System.Windows.Forms.Timer timer_sign_up_btn;
        void sign_UP()
        {
            signIn = false;
            assistant_currently_typing = false;
            label_menu.Text = "sign up";
            FL_panel_login.Controls.Clear();

            // Adding sign up fields
            firstName = new UC_TextBox("first name");
            FL_panel_login.Controls.Add(firstName);
            lastName = new UC_TextBox("last name");
            FL_panel_login.Controls.Add(lastName);
            email = new UC_TextBox("email");
            FL_panel_login.Controls.Add(email);
            contact = new UC_TextBox("contact");
            FL_panel_login.Controls.Add(contact);
            dateOfBirth = new UC_datePicker("Date of Birth");
            FL_panel_login.Controls.Add(dateOfBirth);
            gender = new UC_Gender();
            FL_panel_login.Controls.Add(gender);
            signupbtn = new UC_Button("sign up", Resources.Sign_up_light, Resources.sign_up_dark);
            FL_panel_login.Controls.Add(signupbtn);

            timer_sign_up_btn = new System.Windows.Forms.Timer();
            timer_sign_up_btn.Interval = 20;
            timer_sign_up_btn.Tick += timer_sign_up_btn_Tick;
            timer_sign_up_btn.Start();
            if (signUpBtn.IS_clicked())
            {

            }

            //Setting up assistant
            changeAssistant_activity(Resources.assistant_loved, 4);
            firstName.GET_Textbox().TextChanged += firstName_textChanged;
            lastName.GET_Textbox().TextChanged += lastName_textChanged;
            email.GET_Textbox().TextChanged += email_textChanged;
            contact.GET_Textbox().TextChanged += contact_textChanged;
        }
        void timer_sign_up_btn_Tick(object sender, EventArgs e)
        {
            if (signupbtn.IS_clicked())
            {
                signupbtn.SET_isClicked(false);
                string firstname_string = firstName.getDetails();
                string lastname_string = lastName.getDetails();
                string email_string = email.getDetails();
                string contact_string = contact.getDetails();
                DateTime datetime = dateOfBirth.GetDate_DateTime();
                int gender_int = gender.GetValue();
                if (Validation.Name(firstname_string) && firstname_string != "first name")//first name
                {
                    firstName.SetErrorState(false);
                    if (Validation.Name(lastname_string) && lastname_string != "last name")
                    {
                        lastName.SetErrorState(false);
                        if (Validation.Email(email_string) && email_string != "email")
                        {
                            email.SetErrorState(false);
                            if (!PersonCRUD.isAlreadyPresent_Email(email_string))
                            {
                                if (Validation.Date(dateOfBirth.GetDate_DateTime()))
                                {
                                    if (Validation.Contact(contact_string) && contact_string != "contact")
                                    {
                                        contact.SetErrorState(false);
                                        if (gender_int == 1 || gender_int == 2)
                                        {


                                            // Creating of Person Object
                                            Person person = new Person(firstname_string, lastname_string, email_string, contact_string, datetime, gender_int);
                                            PersonCRUD.AddPerson(person);
                                            person.ID = PersonCRUD.GetId(person.FirstName, person.LastName, person.Email);
                                            Student student = new Student(StudentCRUD.GenerateRollNumber(person.ID), person);
                                            Essentials.SendEmail(student.Email, Essentials.subject_signUp, Essentials.GetBodySignUP(student));
                                            StudentCRUD.AddStudent(student);
                                            StudentCRUD.CurrentStudent = student;
                                            Program.formToinvoke = TYPE.STUDENT;

                                            timer_sign_in.Stop();

                                            Program.emailSuccess.SetApartmentState(ApartmentState.STA);

                                            // Start the new thread
                                            Program.emailSuccess.Start();
                                            this.Close();

                                        }

                                    }
                                    else // incorrect contact format
                                    {
                                        contact.SetErrorState(true);
                                    }
                                }
                                else// incorrect date
                                {
                                    form_message incorrectDate = new form_message("Incorrect Date", "you  type  date:  invalid !", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                                    incorrectDate.Show();
                                }
                            }
                            else // repeated Email
                            {
                                form_message repeatedEmail = new form_message("Incorrect Email", "Email  already  exists:  typed ", ColorTranslator.FromHtml("#D02A1D"), ColorTranslator.FromHtml("#811511"), Resources.close_circle_light);
                                repeatedEmail.Show();
                            }
                        }
                        else //incorrect email
                        {
                            email.SetErrorState(true);

                        }

                    }
                    else// last name incorrect
                    {
                        lastName.SetErrorState(true);

                    }
                }
                else// first name incorrect
                {
                    //incorrect username
                    firstName.SetErrorState(true);

                }
            }
        }
        void firstName_textChanged(object sender, EventArgs e)
        {
            if (Validation.Name(firstName.getDetails()))
            {
                firstName.SetErrorState(false);

            }
            textChanged_toChangeAssistantActivity(TYPE.FIRSTNAME);
        }
        void lastName_textChanged(object sender, EventArgs e)
        {
            textChanged_toChangeAssistantActivity(TYPE.LASTNAME);
        }
        void email_textChanged(object sender, EventArgs e)
        {
            textChanged_toChangeAssistantActivity(TYPE.EMAIL);
        }
        void contact_textChanged(object sender, EventArgs e)
        {
            textChanged_toChangeAssistantActivity(TYPE.CONTACT);
        }

        #endregion






        #region Assistant
        int textChangeCount;
        void textChanged_toChangeAssistantActivity(TYPE type)
        {
            if (textChangeCount == 1)
            {
                switch (type)
                {
                    case TYPE.FIRSTNAME:
                        changeAssistant_activity(Resources.assistant_happy_3, (int)type);
                        break;
                    case TYPE.LASTNAME:
                        changeAssistant_activity(Resources.assistant_sad, (int)type);
                        break;
                    case TYPE.CONTACT:
                        changeAssistant_activity(Resources.assistant_kidding, (int)type);
                        break;
                    case TYPE.EMAIL:
                        changeAssistant_activity(Resources.assistant_happy_1, (int)type);
                        break;
                    case TYPE.GENDER:
                        changeAssistant_activity(Resources.assistant_shocked_swirl, (int)type);
                        break;
                    case TYPE.DATEOFBIRTH:
                        changeAssistant_activity(Resources.assistant_happy_2, (int)type);
                        break;
                    case TYPE.SIGN_ID:
                        changeAssistant_activity(Resources.assistant_happy_3, (int)type);
                        break;
                }
                previousAssistantActivity = type;
                textChangeCount = 0;
            }
            if (!assistant_currently_typing && type != previousAssistantActivity)
            {
                textChangeCount += 1;
            }
        }

        TYPE previousAssistantActivity;

        private List<string[]> messages = new List<string[]>
        {
            new string[]
            {
                "As-Salaam-Alaikum",
                "Please Enter your",
                "required credentials",
                "or simply sign up !"
            },
            new string[]
            {
                "Don't touch me.",

            },
            new string[]
            {
                "You hit me this "
                ,"is not good :( "
            },
             new string[]
            {
                "Enter the id given"
                ,"to you by admin."
            }
            ,
              new string[] // 4
            {
                " Welcome aboard! ",
                " We're thrilled to ",
                "have you join our " ,
                "family of love and ",
                "support!"
            },
            new string[]
            {
                "We can't wait to greet",
                " you by name, starting ",
                "with your lovely first ","name!"
            },
            new string[]
{
    "Embrace the journey",
    " with us! 💖 Let's",
    " complete your profile",
    " with the warmth of",
    " your last name."
}
,new string[]
{
    "Unlock the door to",
    " connection! 💖 Share",
    " your email, and let's",
    " stay in touch",
    " seamlessly."
}
,new string[]
{
    "Connect with us",
    " effortlessly! 💖 Share",
    " your contact and let's",
    " keep the conversation",
    " flowing smoothly."
}
,new string[]
{
    "Express yourself freely",
    " with us! 💖 Let's learn",
    " about your gender and",
    " create a welcoming",
    " space together."
},
new string[]//10
{
    "Celebrate with us! 💖",
    " Let's mark your special",
    " day together. Share",
    " your birthday, and",
    " let the festivities begin!"
}


        };

        private int currentMessageIndex = 0;
        private int currentLineIndex = 0;
        private int currentIndex = 0;
        private bool showCursor = true;
        private string printedText = "";
        private void timer_text_assistant_Tick(object sender, EventArgs e)
        {
            showCursor = !showCursor;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            if (currentMessageIndex < messages.Count)
            {
                string[] currentMessage = messages[currentMessageIndex];
                if (currentLineIndex < currentMessage.Length)
                {
                    string currentLine = currentMessage[currentLineIndex];
                    if (currentIndex < currentLine.Length)
                    {
                        assistant_currently_typing = true;
                        printedText += currentLine[currentIndex];
                        label_message_assistant.Text = printedText;
                        if (showCursor)
                        {
                            label_message_assistant.Text += "|";
                        }
                        currentIndex++;
                    }
                    else
                    {
                        printedText += Environment.NewLine;
                        currentLineIndex++;
                        currentIndex = 0;
                    }

                }
                else
                {
                    label_message_assistant.Text = printedText;
                    printedText = "";
                    assistant_currently_typing = false;
                    timer_text_assistant.Stop();
                    currentLineIndex = 0;
                    currentIndex = 0;
                }
            }
            else
            {
                assistant_currently_typing = false;
                timer_text_assistant.Stop();
            }
        }
        int count_cool_down;
        bool assistant_currently_typing;
        bool changeAssistant_activity(Image img, int index)
        {
            if (!assistant_currently_typing)
            {

                currentMessageIndex = index;
                printedText = "";
                label_message_assistant.Text = "";
                PB_Assistant.Image = img;
                timer_text_assistant.Start();
                return true;
            }
            return false;
        }
        private void PB_Assistant_click(object sender, EventArgs e)
        {

            changeAssistant_activity(Resources.assistant_injured, 2);
            assistant_cool_down();
        }
        bool signIn;
        private void PB_Assistant_MouseEnter(object sender, EventArgs e)
        {
            changeAssistant_activity(Resources.assistant_angry, 1);
        }
        private void PB_Assistant_MouseLeave(object sender, EventArgs e)
        {
            assistant_cool_down();

        }

        System.Windows.Forms.Timer timer_assistant_to_cool_down = new System.Windows.Forms.Timer();
        void assistant_cool_down()
        {
            timer_assistant_to_cool_down.Tick += timer_assistant_to_cool_down_Tick;
            timer_assistant_to_cool_down.Interval = 1000;
            timer_assistant_to_cool_down.Start();
            count_cool_down = 0;
        }

        void timer_assistant_to_cool_down_Tick(object sender, EventArgs e)
        {
            if (signIn)
            {
                if (count_cool_down == 20)
                {
                    changeAssistant_activity(Resources.assistant_happy_1, 0);
                    count_cool_down = 0;
                    timer_assistant_to_cool_down.Enabled = false;
                    timer_assistant_to_cool_down.Stop();
                }
                count_cool_down++;

            }
            else
            {
                if (count_cool_down == 20)
                {
                    changeAssistant_activity(Resources.assistant_loved, 4);
                    count_cool_down = 0;
                    timer_assistant_to_cool_down.Enabled = false;
                    timer_assistant_to_cool_down.Stop();
                }
                count_cool_down++;

            }
        }
        #endregion  
        private void btn_close_Click(object sender, EventArgs e)
        {
            Essentials.CloseApplication();
        }
    }

}

