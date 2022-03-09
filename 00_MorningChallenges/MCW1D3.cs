using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges
{
    [TestClass]
    public class MCW1D3
    {
        [TestMethod]
        public void ConditionsLoops()
        {

            string super = "supercalifragilisticexpialidocious";


            for (int letter = 0; letter < super.Length; letter++)

            {

                Console.WriteLine(super[letter]);
            }


          

        }
        [TestMethod]
        public void MCW1D3p2()
        {

            string super = "supercalifragilisticexpialidocious";
            int letterCount = 0;
            foreach (char letter in super) 
            {
                if(letter == 'i')
                { 
                
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
                letterCount++;
            }
            Console.WriteLine(letterCount);
         
        }
    }
}
