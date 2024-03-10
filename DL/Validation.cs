using System;
using System.Text.RegularExpressions;

namespace Project_Pulse.DL
{
    internal class Validation
    {
        public static bool isValid_AdvisorRole(string text)
        {
            if (text == "11" || text == "12" || text == "14")
                return true;
            return false;
        }
        public static bool isInteger(string text)
        {
            text = text.Trim();
            if (Regex.IsMatch(text, "^[0-9]+$"))
                return true;
            return false;
        }
        public static void RemoveSpaces_S_E(ref string text)
        {
            text.TrimStart();
            text = text.TrimEnd();
        }

        public static bool Name(string name)
        {
            string temp = name;
            temp = temp.ToLower();
            if (temp == "first name" || temp == "last name" || temp == "firstname" || temp == "lastname" || IsEmpty(name) || !(Regex.IsMatch(name, "^[A-Za-z ]+$")))
            {
                return false;
            }
            return true;
        }
        public static bool Email(string mail)
        {

            if (!(Regex.IsMatch(mail, "^[a-zA-Z0-9.]+@[a-zA-Z\\.]+$")) || mail == "email" || IsEmpty(mail))
            {
                return false;
            }
            return true;
        }

        public static bool Contact(string contact)
        {
            if (!(Regex.IsMatch(contact, "^[0-9]{10,11}$")) || IsEmpty(contact) || contact == "contact")
            {
                return false;
            }
            return true;
        }
        public static bool RollNumberOrID(string usernameID)
        {

            if (!(Regex.IsMatch(usernameID, "^[a-z0-9A-Z-@\\.]+$")) || IsEmpty(usernameID))
            {
                return false;
            }
            return true;
        }
        public static bool Date(DateTime dt)
        {
            if (dt == null)
            {
                return false;
            }
            DateTime todayDate = DateTime.Today;
            if (dt > todayDate.Date)
            {
                return false;
            }
            return true;
        }
        public static bool ProjectTitle(string salary)
        {

            return true;
        }
        public static bool Description(string salary)
        {

            return true;
        }
        public static bool Salary(string salary)
        {

            return true;
        }
        public static bool Designation(string designation)
        {

            return true;
        }

        public static bool IsEmpty(string text)
        {
            return text.Length == 0;
        }
    }
}
