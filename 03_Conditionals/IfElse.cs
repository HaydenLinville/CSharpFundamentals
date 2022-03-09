using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {

            bool userIsHungry = true;

            //if Keword
            if(userIsHungry) //Condition in parethesis
            {
                //Body
                Console.WriteLine("Eat something");
            }

            string name = "Jacob";

            if (name == "Jacob")
            {
                Console.WriteLine("You must be so cool!");
            }

            if (name != "Jacob")
            {
                Console.WriteLine("You must not be very cool.");
            }

        }
        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if(choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("Stay home and do your chores");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            //Nested conditionals

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tried today");

                if(totalHours< 4)
                {
                    Console.WriteLine("You should get more sleep");
                }
            }
           

        }
        [TestMethod]
        public void IfElseIfStatements()
        {

            Random rng = new Random();

            int roll = rng.Next(1,7);

            if (roll == 6)
            {
                Console.WriteLine("You rolled six! Good job!");
            }
            else if (roll == 5) 
            {
                Console.WriteLine("You rolled five not bad!");

            }
            else if(roll < 5 && roll > 3) 
            {
                Console.WriteLine("You rolled not a six or five");
            }
            else if(roll == 3)
            {
                Console.WriteLine("Its a three");
            }
            else if(roll > 1)
            {
                Console.WriteLine( "Towo");
            }
            else
            {
                Console.WriteLine("Uno");
            }
        }
    }
}
