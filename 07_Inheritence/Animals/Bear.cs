using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Bear : Animal
    {
        public Bear()
        {
            Console.WriteLine("Creating bear");
            IsMamal = true;
            Diet = DietType.Carnivore;
            HasFut = true;
            NumberOfLegs = 4;

        }
        public bool IsAngry { get; set; }
        public bool IsHibernting { get; set; }
        public string FurColor { get; set; }


        public virtual void Roar()
        {
            Console.WriteLine("The bear roars!");
        }


    }
    public class PolorBear : Bear
    {
        public PolorBear()
        {
            Console.WriteLine("Adding ice");
            FurColor = "White";
        }

        public override void Roar()
        {
            //base.Roar();

            Console.WriteLine("The Polar bear roars and you can see it's breath!");
        }
        

    }


}
