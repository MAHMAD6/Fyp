using Project_Pulse.BL;
using Project_Pulse.DL;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_Student_Details_card : UserControl
    {
        public UC_Student_Details_card()
        {
            InitializeComponent();
        }
        public UC_Student_Details_card(Student student)
        {
            InitializeComponent();
            label_Designation_roll_number.Text = student.RollNumber;
            setPersonCredentials((Person)student);

        }
        public UC_Student_Details_card(BL.Advisor advisor)
        {
            InitializeComponent();
            label_Designation_roll_number.Text = Essentials.LookupToString(advisor.Designation);
            label_h_salary.Visible = true;
            label_salary.Visible = true;
            label_salary.Text = advisor.Salary.ToString();
            label_border_heading.Text = "Advisor Card";
            setPersonCredentials((Person)advisor);

        }
        void setPersonCredentials(Person person)
        {
            label_id.Text = "#" + person.ID.ToString();
            label_first_name.Text = person.FirstName;
            label_last_name.Text = person.LastName;
            label_email.Text = person.Email;
            label_Contact.Text = person.Contact;
            PB_profile.Image = person.Img;
            label_Gender.Text = Essentials.LookupToString(person.Gender);
        }
        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}
