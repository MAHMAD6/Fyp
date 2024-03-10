using System;
using System.Drawing;

namespace Project_Pulse.BL
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime Birthday { get; set; }
        public int ID { get; set; }
        public int Gender { get; set; }
        public Image Img { get; set; }
        public Person(string firstName, string lastName, string email, string contact, DateTime birthday, int gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Contact = contact;
            Birthday = birthday;
            Gender = gender;
            Img = Project_Pulse.Properties.Resources.profile_holder_;
        }
        public Person(Person person)
        {
            this.ID = person.ID;
            FirstName = person.FirstName;
            LastName = person.LastName;
            Email = person.Email;
            Contact = person.Contact;
            Birthday = person.Birthday;
            Gender = person.Gender;
            Img = Project_Pulse.Properties.Resources.profile_holder_;
        }
        public string ToString__()
        {
            return this.FirstName + " + " + this.LastName + " + " + this.Email + " + " + this.Contact + " + " + this.Gender.ToString();
        }
    }
}
