using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept28FBClass
{
    public enum Relationship { Single, Married, Taken, Complicated }
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                TimeSpan profileAge = DateTime.Now - BirthDate;
                double totalAgeYears = profileAge.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeYears));
            }
        }
        public Relationship Status { get; set; }
        public string Occupation { get; set; }

        public Profile(string firstName, string lastName, DateTime dateOfBirth, Relationship status, string occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            Status = status;
            Occupation = occupation;
        }
        public Profile()
        {

        }
    }
}
