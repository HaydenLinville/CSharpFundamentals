using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreeterMethodExecute()
        {
            Greeter greeter = new Greeter();
            // Semantic Satiation: Words no longer are words

            greeter.SayHello("Hayden");
            greeter.SayHello();


            greeter.GetRandomGreeting();
        }
        [TestMethod]
        public void CalculatorTest()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 3);
            Console.WriteLine(sum);



            int age = calculator.CalculateAge(new DateTime(1993, 9, 30));
            Console.WriteLine(age);
        }

        [TestMethod]
        public void PersonProperty()
        {
            Person person = new Person();
            person.FirstName = "Jacob";
            person.LastName = "Brown";
            person.FullName = "Jacob Brown";


            //assert helps test your project
        }

        [TestMethod]
        public void SquarFeetTester()
        {

            Room room = new Room(10d, 10d, 10d);

            

            double lSA = room.LatSurA();

            Console.WriteLine(lSA);

            Assert.AreEqual(400, room.LatSurA());

        }


        //Unit Testing Naaming: Functionality_Goal
        //Checking constructor is setting values
        [TestMethod]
        public void ConstructRoom_ShouldSetProperties()
        {
            Room room = new Room(8, 8, 10);

            Assert.AreEqual(8, room.Length);
            Assert.AreEqual(8, room.Width);
            Assert.AreEqual(10, room.Height);


        }

        //checking square footage output
        [TestMethod]
        public void CheckSquareFootage_ShouldReturnCorrectDouble()
        {

            Room room = new Room(10, 12, 12);

            double expected = 120;
            double actual = room.SquFoo();

            Assert.AreEqual(expected, actual);


        }
        //Checking lateral area output

        [TestMethod]
        public void CheckLateralSurfaceArea_ShouldReturnCorrectDouble()
        {

            Room room = new Room(10, 7, 10);

            // Assert.AreEqual(340, room.surar)

        }

        [DataTestMethod]
        [DataRow(4, 8, 12)] // checking minimum length failure
        [DataRow(40, 30, 11)] //check maximum length failure
        public void CreatingInvalidLength_ShouldThrowException(double l, double w, double h)
        {

            Exception throwException = null;

            try
            {
                //attempt this
                Room room = new Room(l, w, h);
            }
            //grab the exception
            catch (Exception err)
            {


                //run this code
                throwException = err;
            }

            Assert.IsNotNull(throwException);
            Assert.IsInstanceOfType(throwException, typeof(ArgumentException));



        }

        //Check invalid values
        [DataTestMethod]
        [DataRow(4, 8, 12)] // checking minimum width failure (Need to change values for width to make sure only a few fail 
        [DataRow(40, 30, 11)] //check maximum width failure
        public void CreateInvalidWidth_ShouldThrowExceptions(double l, double w, double h)
        {

            Exception throwException = null;

            try
            {
                //attempt this
                Room room = new Room(l, w, h);
            }
            //grab the exception
            catch (Exception err)
            {


                //run this code
                throwException = err;
            }
            finally //Will always run regardless of exception thrown or not (instructor has not found a reason for finally)
            {

                Console.WriteLine("I cannot be stopped");
                Assert.IsNotNull(throwException);
                Assert.IsInstanceOfType(throwException, typeof(ArgumentException));
            }




           

        }
        //Check invalid length

        [DataTestMethod]
        [DataRow (500, 500, 500)] //over max
        [ExpectedException(typeof(ArgumentException))]//I am expecting an expection and this test to fail so it passes
        public void CreateInvalidHeight_ShowThrowException( double l, double w, double h)
        {

            Room room = new Room(l, w, h);


        }

    }
}
