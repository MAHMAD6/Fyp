using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_datePicker : UserControl
    {
        public UC_datePicker(string label)
        {
            InitializeComponent();
            label_for_date_message.Text = label;

            // Adding highlights 
            datePicker.MouseEnter += UC_datePicker_MouseEnter;
            datePicker.MouseLeave += UC_datePicker_MouseLeave;
            datePicker.Enter += UC_datePicker_MouseEnter;
            datePicker.MouseHover += UC_datePicker_MouseEnter;
            label_for_date_message.MouseEnter += UC_datePicker_MouseEnter;
            label_for_date_message.MouseLeave += UC_datePicker_MouseLeave;

        }
        public string GetDate_string()
        {
            return datePicker.ToString();
        }

        public DateTime GetDate_DateTime()
        {
            return datePicker.Value;
        }

        private void UC_datePicker_MouseEnter(object sender, System.EventArgs e)
        {
            //label_for_date_message.ForeColor = Essentials.TextColor;
        }

        private void UC_datePicker_MouseLeave(object sender, System.EventArgs e)
        {
            //label_for_date_message.ForeColor = Essentials.SubColor;
        }
    }
}
