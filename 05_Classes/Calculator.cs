using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        //sub

        public decimal Sub(decimal numO, decimal numT)
        {
            decimal subtr = numO - numT;
            return subtr;
        }

        //Mult
        public decimal Mult(decimal numO, decimal numT)

        {
            decimal mul = numO * numT;
            return mul;
        }
        
        //div
        public decimal Div(decimal numO, decimal numT)
        {
            decimal divi = numO / numT;
            return divi;
        }

        //Remainder
        public decimal Rem(decimal numO, decimal numT)
        {
            decimal remain = numO % numT;
            return remain;
        }


        public int CalculateAge(DateTime birthDate)

        {
            TimeSpan age = DateTime.Now - birthDate;
            double totalAgeInYears = age.TotalDays / 365.25;
            double rounded = Math.Floor(totalAgeInYears);
            int year = Convert.ToInt32(rounded);
            return year;
        }

    }
}
