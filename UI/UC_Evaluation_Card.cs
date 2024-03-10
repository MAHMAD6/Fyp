using Project_Pulse.BL.Abstract;
using System.Windows.Forms;

namespace Project_Pulse.UI
{
    public partial class UC_Evaluation_Card : UserControl
    {
        public GroupEvaluation GroupEvaluation_;
        public UC_Evaluation_Card(GroupEvaluation groupEvaluation)
        {
            InitializeComponent();
            GroupEvaluation_ = groupEvaluation;
            label_Evaluation_id.Text = "# " + GroupEvaluation_.ID;
            label_group_id.Text = "# " + GroupEvaluation_.GroupID;
            label_name.Text = GroupEvaluation_.Name;
            label_total_weightage.Text = GroupEvaluation_.TotalWeightage + "%";
            label_marks.Text = GroupEvaluation_.TotalMarks + " ";
            label_obtained_marks.Text = GroupEvaluation_.ObtainedMarks + " ";




        }
    }
}
