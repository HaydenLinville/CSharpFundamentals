using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            //Good for bools and for spacific "cases"
            //Can also be used for other types

            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                case 45:
                case 93:
                    Console.WriteLine("What's up");
                    break;
                default:
                    Console.WriteLine("This is the default, it will execute if not case matches the value");
                    break;
            }
            

        }
    }
}
