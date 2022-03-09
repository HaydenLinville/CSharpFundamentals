using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    public class InsuranceInfo
    {

        public InsuranceInfo() { }

        public InsuranceInfo(int customerId, string lastName, int age, DateTime enrollDate, int yearsUsed)
        {

            CustomerId = customerId;
            LastName = lastName;
            Age = age;
            EnrollDate = enrollDate;
            YearsUsed = yearsUsed;


        }



        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollDate { get; set; }

        public int YearsUsed { get; set; }




    }
}
