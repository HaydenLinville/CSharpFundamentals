using _07_Inheritence.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_Inheritence
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void Animal()
        {

           

            Snake snake = new Snake();
            snake.Move();
            Console.WriteLine(snake.NumberOfLegs);

            GardenSnake gSnake = new GardenSnake();
            gSnake.Move();
            Console.WriteLine(gSnake.Color);

            CerastesSnake cSnake = new CerastesSnake();
            cSnake.Move();
            Console.WriteLine(cSnake.IsMamal);

        }

        [TestMethod]
        public void Bear()
        {

            Bear bear = new Bear();
            bear.Roar();
            bear.Move();

            PolorBear pBear = new PolorBear();
            pBear.Roar();
            pBear.Move();

        }


    }
}
