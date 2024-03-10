using System;

namespace Project_Pulse.BL
{
    public class ProjectAdvisor
    {
        public int AdvisorID { get; set; }
        public int ProjectID { get; set; }
        public int AdvisorRole { get; set; }
        public DateTime AssignmentDate { get; set; }
        public ProjectAdvisor(int advisorID, int projectID, int advisorRole, DateTime assignmentDate)
        {
            this.AdvisorID = advisorID;
            this.ProjectID = projectID;
            this.AdvisorRole = advisorRole;
            this.AssignmentDate = assignmentDate;
        }
    }
}
