using Project_Pulse.UI.UserControls.Advisor__;
using System;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_request_card : UserControl
    {
        public int GroupID_;
        public int ProjectID_;
        public UC_request_card(int groupID, int projectID, int members)
        {
            ProjectID_ = projectID;
            GroupID_ = groupID;
            InitializeComponent();
            label_GroupID_.Text = groupID.ToString();
            label_projectid.Text = projectID.ToString();
            label_members.Text = members.ToString();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (this.Parent?.Parent?.Parent is UC_requests request)
            {
                request.accept_Request(GroupID_, ProjectID_);
            }
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            if (this.Parent?.Parent?.Parent is UC_requests request)
            {
                request.reject_Request(this);
            }
        }
    }
}
