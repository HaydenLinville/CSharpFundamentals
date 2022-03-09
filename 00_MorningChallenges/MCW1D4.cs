using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_MorningChallenges
{
    

    public class MCW1D4
    {

        public class User
        {
            public User()
            {

            }

            public User(string firstName, string lastName, int iD, DateTime birthday)
            {

                FirstName = firstName;
                LastName = lastName;
                ID = iD;
                BirthDate = birthday;

            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; }
            public DateTime BirthDate { get; set; }


            public string Info()
            {

                return $"{FirstName} {LastName}";
                
            }

            public TimeSpan Age()
            {
                
                
                TimeSpan age = DateTime.Now - BirthDate;
                double totalAgeInYears = age.TotalDays / 365.25;
                return age;




            }


        }
        [TestMethod]
        public void MyTestMethod()
        {

            User user = new User("Hayden", "Linville", 2344, new DateTime(1993, 9, 29));

            Console.WriteLine(user);
            


        }
    }

    
}
