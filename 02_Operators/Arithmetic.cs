using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            
            //Can use other types of values

            int a = 22;
            int b = 15;

            //Addtion
            int sum = a + b;
            //Subtraction
            int difference = a - b;
            // Multiplication
            int product = a * b;
            //Division
            int quotient = a / b; //With hole number it drops the remainder/decimal
            //Remainder
            int remainder = a % b; // Returns the remainder

            DateTime today = DateTime.UtcNow;
            DateTime someDay = new DateTime(1980, 02, 28);
            TimeSpan timeSpan = today - someDay;

        }
        
    }
}
