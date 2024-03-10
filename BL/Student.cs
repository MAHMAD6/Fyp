using System;

namespace Project_Pulse.BL
{
    public class Student : Person
    {
        public string RollNumber { get; set; }
        public Student(string firstName, string lastName, string email, string contact, DateTime birthday, int gender, int id, string rollNumber)
            : base(firstName, lastName, email, contact, birthday, gender)
        {
            RollNumber = rollNumber;
            this.ID = ID;
        }
        public Student(string rollNumber, Person person)
            : base(person.FirstName, person.LastName, person.Email, person.Contact, person.Birthday, person.Gender)
        {
            this.ID = person.ID;
            RollNumber = rollNumber;
        }
        public Student(Student student)
            : base((Person)student)
        {
            this.RollNumber = student.RollNumber;
        }
    }
}
