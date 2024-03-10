using System;

namespace Project_Pulse.BL.Abstract
{
    public class GroupProject
    {
        public int GroupID { get; set; }
        public int ProjectID { get; set; }
        public DateTime AssignmentDate { get; set; }
        public GroupProject(int groupID, int projectID, DateTime assignmentDate)
        {
            this.GroupID = groupID;
            this.ProjectID = projectID;
            this.AssignmentDate = assignmentDate;
        }
    }
}
