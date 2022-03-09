using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Nascar
{
    [TestClass]
    public class UnitTest1
    {




        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car();

            car.ShiftUp(Car.Gears.One);

            car.ShiftUp(Car.Gears.Three);


        }
    }
}
