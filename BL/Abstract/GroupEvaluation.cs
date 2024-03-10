using System;

namespace Project_Pulse.BL.Abstract
{
    public class GroupEvaluation : Evaluation
    {
        public int ObtainedMarks { get; set; }
        public int GroupID { get; set; }
        public DateTime EvaluationDate { get; set; }

        public GroupEvaluation(int obtainedMarks, int groupID, DateTime evaluationDate, Evaluation evaluation) : base(evaluation)
        {
            this.ObtainedMarks = obtainedMarks;
            this.GroupID = groupID;
            this.EvaluationDate = evaluationDate;
        }
    }
}
