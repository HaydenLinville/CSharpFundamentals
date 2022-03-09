using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator
{
    [TestClass]
    public class CalculatorTest
    {

        private Calculator _calculator;

        [DataTestMethod]
        [DataRow(20, 34)]
        public void TestingAddMethod_ShouldReturnTrue(double numOne, double numTwo)
        {
            _calculator = new Calculator(numOne, numTwo);

            Console.WriteLine(_calculator.Adding());

            double checking = numOne + numTwo;

            Assert.AreEqual(_calculator.Adding(), checking);



        }
    }
}
