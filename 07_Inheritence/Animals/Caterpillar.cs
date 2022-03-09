using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Caterpillar : Animal
    {

        public Caterpillar()
        {
            Console.WriteLine("A caterpillar is born");
            NumberOfLegs = 20;
            IsMamal = false;
            Diet = DietType.Herbivore;
            HasFut = false;
            CanCrawl = true;
        }

        public bool CanCrawl { get; set; }
        public bool CanFly
        {
            get
            {
                return false;
            }

        }
        public void PukeSilk()
        {
            Console.WriteLine($"The {GetType().Name} puke silk");
        }



        public class Cacoon : Caterpillar
        {

            public Cacoon()
            {
                Console.WriteLine("It is in silk now");
                NumberOfLegs = 0;

            }

            public bool CanCrawl
            {
                get
                {
                    return false;
                }
            }

        }



        public class Butterfly : Cacoon
        {
            public Butterfly()
            {
                Console.WriteLine("It is reborn a butterfly");
                NumberOfLegs = 12;
                CanFly = true;
                CanCrawl = true;

            }
            public bool CanFly { get; set; }
            public bool CanCrawl { get; set; }
            public void Fly()
            {
                Console.WriteLine("It is in the air?");
            }

        }

    }
}



