using Project_Pulse.BL.Abstract;
using Project_Pulse.DL;
using Project_Pulse.DL.CRUD_s;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls.Advisor__
{
    public partial class UC_requests : UserControl
    {
        List<UC_request_card> groups = new List<UC_request_card>();
        public UC_requests()
        {
            InitializeComponent();
            loadAndDisplayData();
        }
        void loadAndDisplayData()
        {
            for (int i = 0; i < AdvisorCRUD.requests.Count; i++)
            {
                List<GroupStudent> list = GroupCRUD.GetGroupStudents(AdvisorCRUD.requests[i].GroupID);
                UC_request_card uC_Group_Card = new UC_request_card(AdvisorCRUD.requests[i].GroupID, AdvisorCRUD.requests[i].ProjectID, list.Count);
                FL_holder.Controls.Add(uC_Group_Card);

            }
        }
        public void reject_Request(UC_request_card card)
        {
            groups.Remove(card);
            removeRequestFromCRUDlist(card.ProjectID_, card.GroupID_);
        }
        public void accept_Request(int GroupId, int projectID)
        {
            GroupCRUD.AddGroupProject(GroupId, projectID, DateTime.Now);
            removeRequestFromCRUDlist(projectID, GroupId);
        }
        void removeRequestFromCRUDlist(int projectID, int GroupId)
        {
            for (int i = 0; i < AdvisorCRUD.requests.Count; i++)
            {
                if (projectID == AdvisorCRUD.requests[i].ProjectID && GroupId == AdvisorCRUD.requests[i].GroupID)
                {
                    AdvisorCRUD.requests.RemoveAt(i);
                }
            }
        }
    }
}
