using Project_Pulse.DL;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{


    public partial class UC_TextBox : UserControl
    {

        public UC_TextBox(string placeholder)
        {
            InitializeComponent();
            TextBox.Text = placeholder;
            TextBox.GotFocus += TB_GotFocus;
            TextBox.LostFocus += TB_LostFocus;
        }
        public void SetSize(int width, int height)
        {
            this.Size = new System.Drawing.Size(width + 20, height + 20);
            TextBox.Size = new System.Drawing.Size(width, height);
            TextBox.Multiline = true;

        }

        void TB_LostFocus(object sender, EventArgs e)
        {
            PB_cross_error.BackColor = TextBox.BaseColor;

        }
        void TB_GotFocus(object sender, EventArgs e)
        {
            PB_cross_error.BackColor = TextBox.FocusedBaseColor;

        }
        public Guna.UI.WinForms.GunaTextBox GET_Textbox()
        {
            return TextBox;
        }

        public string getDetails()
        {
            string text = TextBox.Text;
            Validation.RemoveSpaces_S_E(ref text);
            return text;
        }
        public void SetErrorState(bool value)
        {
            if (value)
            {
                PB_cross_error.Visible = true;
                return;
            }
            PB_cross_error.Visible = false;
        }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            //this.Cursor = new Cursor(Project_Pulse.Properties.Resources.cursor.Handle);

        }

        private void UC_TextBox_Load(object sender, EventArgs e)
        {

        }







    }
}
