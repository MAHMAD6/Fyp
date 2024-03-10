namespace Project_Pulse.BL.Abstract
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Project(int id, string title, string description)
        {
            this.ID = id;
            this.Title = title;
            this.Description = description;
        }
    }
}
