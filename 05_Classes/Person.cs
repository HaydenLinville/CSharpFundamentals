using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {

        private string _lastName;
        public Person() {}

        public Person (string firstName, string lastname, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastname;
            DateOfBirth = dOB;


        }
           
         

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        public Vechicle Transport { get; set; } //proprity 


        


    }
}
