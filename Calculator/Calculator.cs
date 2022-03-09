using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
       public Calculator() { }

        public Calculator(double numOne, double numTwo)
        {
            NumOne = numOne;
            NumTwo = numTwo;



        }



        public double NumOne { get; set; }

        public double NumTwo { get; set; }






        public double Adding()
        {
            double value = NumOne + NumTwo;

            return value;
        }
        

        public double Sub()
        {
            double value = NumOne - NumTwo;

            return value;
        }

        public double Mult()
        {
            double value = NumOne * NumTwo;

            return value;
        }


        public double Dev()
        {
            double value = NumOne / NumTwo;

            return value;
        }


         

        
    }
}
