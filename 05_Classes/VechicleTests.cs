using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class VechicleTests
    {


        [TestMethod]
        public void PropertiesTest()
        {

            Vechicle firstVehicle = new Vechicle();
            firstVehicle.Make = "Chevy";

            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Model = "Sonic";
            firstVehicle.Mileage = 50000;
            firstVehicle.VehicleType = VechicleType.Car;

            Console.WriteLine($"I own a {firstVehicle.Make} {firstVehicle.Model}, it has {firstVehicle.Mileage} miles on it. It is a sweet {firstVehicle.VehicleType}");


        }

        [TestMethod]
        public void EngineTests()
        {
            Vechicle trasnsport = new Vechicle();

            trasnsport.TurnOn();
            Console.WriteLine(trasnsport.IsRunning);
            trasnsport.TurnOff();



            trasnsport.RightIndicator = new Indicator();
            trasnsport.LeftIndicator = new Indicator();

            trasnsport.IndicateLeft();
            Console.WriteLine("Indicate left");

            Console.WriteLine($"Right: {trasnsport.RightIndicator.IsFlashing}");
            Console.WriteLine($"Left: {trasnsport.LeftIndicator.IsFlashing}");


            trasnsport.IndicateLeft();
            Console.WriteLine("Indicating left");
            CheckIndicators(trasnsport);

            trasnsport.IndicateRigh();
            Console.WriteLine("Indicating Right");
            CheckIndicators(trasnsport);

        }

        [TestMethod]
        public void Constructors()
        {

            Vechicle car = new Vechicle();

            Vechicle rocket = new Vechicle("SpaceX", "Falcon Heavy", 3000, VechicleType.Spaceship);

        }

        //Helper method
        private void CheckIndicators(Vechicle vechicle)
        {
            Console.WriteLine($"Right: {vechicle.RightIndicator.IsFlashing}");
            Console.WriteLine($"Left: {vechicle.RightIndicator.IsFlashing}");

        }




    }
}
