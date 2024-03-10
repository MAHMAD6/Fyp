using Project_Pulse.DL;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_checkbox : UserControl
    {
        bool _checked;
        public LOOKUP _value { get; set; }
        public DateTime _date;
        public UC_checkbox()
        {
            InitializeComponent();
            _checked = false;
            _date = DateTime.Now;
            uncheck();

            PB_tick.Click += click_CB;
            panel1.Click += click_CB;
            label_message.Click += click_CB;
        }
        public void SET_message_and_value(string message, LOOKUP value)
        {
            this._value = value;

            label_message.Text = message;
        }
        private void click_CB(object sender, EventArgs e)
        {
            _checked = !_checked;
            if (_checked)
            {
                check();
            }
            else
            {
                uncheck();
            }
        }
        void check()
        {
            _date = DateTime.Now;
            PB_tick.Image = Project_Pulse.Properties.Resources.tick_yellow;
            label_message.ForeColor = System.Drawing.Color.White;
        }
        void uncheck()
        {
            //label_message.ForeColor = Essentials.SubColor;
            PB_tick.Image = null;
        }
        public void SET_state(bool state)
        {
            _checked = state;
            if (_checked)
            {
                check();
            }
            else
            {
                uncheck();
            }
        }
        public bool GET_state()
        { return _checked; }
    }
}
