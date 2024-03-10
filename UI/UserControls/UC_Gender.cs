using Project_Pulse.DL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_Gender : UserControl
    {
        LOOKUP checked_;
        List<UC_checkbox> Checkboxes = new List<UC_checkbox>();
        public UC_Gender()
        {
            checked_ = 0;
            InitializeComponent();
            uC_checkbox_female.SET_message_and_value("female", DL.LOOKUP.FEMALE);
            Checkboxes.Add(uC_checkbox_female);
            uC_checkbox_male.SET_message_and_value("male", DL.LOOKUP.MALE);
            Checkboxes.Add(uC_checkbox_male);

        }
        public int GetValue()
        {
            return (int)checked_;
        }
        private void UC_Gender_Load(object sender, System.EventArgs e)
        {
            timer_for_gender.Start();
        }

        List<UC_checkbox> checked_Checkboxes = new List<UC_checkbox>();
        private void timer_for_gender_Tick(object sender, System.EventArgs e)
        {
            foreach (var checkbox in Checkboxes)
            {
                if (checkbox.GET_state())
                {
                    checked_Checkboxes.Add(checkbox);
                }
            }

            if (checked_Checkboxes.Count > 1)
            {
                UC_checkbox max_ = checked_Checkboxes[0];
                for (int i = 0; i < checked_Checkboxes.Count; i++)
                {
                    max_ = (max_._date > checked_Checkboxes[i]._date) ? max_ : checked_Checkboxes[i];
                }
                foreach (var checkbox in checked_Checkboxes)
                {
                    if (checkbox != max_)
                    {
                        checkbox.SET_state(false);
                    }
                    else
                    {
                        checked_ = max_._value;
                    }
                }
                checked_Checkboxes.Clear();
            }
        }

        private void uC_checkbox1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
