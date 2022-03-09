using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Snake : Animal
    {
        public Snake()
        {
            Console.WriteLine("Constructing a snake");
            HasFut = false;
            IsMamal = false;
            Diet = DietType.Carnivore;
            NumberOfLegs = 0;
        }

        public string Color { get; set; }
        public override void Move ()
        {
            Console.WriteLine("The snake slithers");
        }


    }
    public class GardenSnake : Snake
    {
        public GardenSnake()
        {
            Console.WriteLine("It's from a garden");
            Color = "Green";
        }

        public override void Move()
        {
            //  base.Move(); This will call the move from above 
            Console.WriteLine("The snake slithers through the graden");
        }

    }

    public class CerastesSnake : Snake
    {
        public CerastesSnake()
        {
            Console.WriteLine("It's from the desert");
            Color = "Brown";
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine(" through the desert.");
        }

    }
}
