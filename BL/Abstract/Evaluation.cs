namespace Project_Pulse.BL.Abstract
{
    public class Evaluation
    {
        public int ID { get; set; }
        public int TotalMarks { get; set; }
        public int TotalWeightage { get; set; }
        public string Name { get; set; }
        public Evaluation(int id, int totalMarks, int totalWeightage, string name)
        {
            this.ID = id;
            this.TotalMarks = totalMarks;
            this.TotalWeightage = totalWeightage;
            this.Name = name;
        }
        public Evaluation(Evaluation evaluation)
        {
            this.ID = evaluation.ID;
            this.TotalMarks = evaluation.TotalMarks;
            this.TotalWeightage = evaluation.TotalWeightage;
            this.Name = evaluation.Name;
        }
        public Evaluation(int totalMarks, int totalWeightage, string name)
        {
            this.TotalMarks = totalMarks;
            this.TotalWeightage = totalWeightage;
            this.Name = name;
        }
    }
}
