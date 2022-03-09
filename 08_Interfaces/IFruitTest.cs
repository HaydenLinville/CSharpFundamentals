using _08_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTest
    {
        [TestMethod]
        public void CallingInterfaceMethods_ShouldReturnCorrectString()
        {

            IFruit banana = new Banana();
            string output = banana.Peel();
            Console.WriteLine(output);
            Console.WriteLine("The banana is peeled " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);


        }

        [TestMethod]
        public void InterfacesInCollections_ShouldWork()
        {
            var orange = new Orange(); //var grabs the type on the otherside 

            var fruitSalad = new List<IFruit>
            {
                orange,
                new Banana(),
                new Grape(),
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));

                if(fruit is Orange)
                {
                    Console.WriteLine(((Orange)fruit).Squeeze());
                }

            }

        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfaceinMethods()
        {
            var grape = new Grape();

            var output = GetFruitName(grape);
            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is called Grape"));


        }

        //pattern matching 
        [TestMethod]
        public void PatternMatching()
        {
            var fruitSalad = new List<IFruit>
            {
                new Grape(),
                new Orange(),
                new Banana(true),
                new Orange(true),
            };

            Console.WriteLine("Is the orange peeled?");
            foreach (var fruit in fruitSalad)
            {
                if(fruit is Orange orange)//pattermatching
                {
                    if(orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange");
                        orange.Squeeze();
                    }
                    else
                        Console.WriteLine("Is an orange");
                }
                else if(fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Is a grape.");

                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It's a peeled banana!");
                }
                else
                {
                    Console.WriteLine("Its a banana!");
                }
            }

        }

    }
}
