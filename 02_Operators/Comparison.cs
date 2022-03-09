using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void Comparisons()
        {

            //REVIEW YOU ARE SLEEPY RIGHT NOW!

            int age = 25;

            string username = "Hayden";

            bool equals = age == 45;
            bool userIsAdam = username == "Adam";

            Console.WriteLine("User is 45: " + equals);
            Console.WriteLine($"User is Adam: {userIsAdam}");

            bool notEqual = age != 112;
            bool userIsNotJusting = username != "Justin";
            Console.WriteLine($"user is not 112: {notEqual}");
            Console.WriteLine("User is not Justin: " + userIsNotJusting);


            //Comparisons on reference type work different
            //Equals check the address which is different for two objects 

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool areSame = firstList == secondList;

            
            //More comparison operations
            bool greaterThan = age > 12;
            bool lessThan = age < 75;

            bool greaThanOrEqual = age >= 66;
            bool lessThanOrEqual = age <= 23;

            bool trueValue = true;
            bool falseValue = false;

            // or
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool FOrT = falseValue || trueValue;
            bool ForF = falseValue || falseValue; //Only one to be false

            //Anda

            bool tAndT = trueValue && trueValue; //Only one to be true
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;


        }
    }
}
