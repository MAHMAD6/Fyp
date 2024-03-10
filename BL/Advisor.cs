namespace Project_Pulse.BL
{
    public class Advisor : Person
    {
        public int Designation { get; set; }
        public float Salary { get; set; }
        public Advisor(int designation, float salary, Person person)
            : base(person)
        {
            Designation = designation;
            Salary = salary;
        }
        public Advisor(Advisor advisor)
            : base((Person)advisor)
        {

            Designation = advisor.Designation;
            Salary = advisor.Salary;
        }
    }
}
