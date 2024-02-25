using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.FORMS
{
    public partial class loading_page : Form
    {
        public loading_page()
        {
            InitializeComponent();
        }

        int loading_time = 0;
        List<string> loading_label_text_list = new List<string>() { "loading.", "loading..", "loading..." };
        private void loading_page_Load(object sender, EventArgs e)
        {
            loading_time = 0;

        }
        int list_index = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (loading_time < 85 / 2)
            {
                loading_time++;
                label_loading.Text = loading_label_text_list[list_index];
                list_index = list_index >= loading_label_text_list.Count - 1 ? 0 : list_index + 1;
            }
            else
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
