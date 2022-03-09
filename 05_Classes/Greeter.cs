using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {


        Random rando = new Random();

        // Parts of method
        // 1 access modifier
        // 2 Return type = What does this method give me?
        // 3 Method Name
        // 4 Method Parameters.
        // 3/4 Name+Parameters=Method Signature name(Parameters)
        // 5 Body, What's being executed when called?

        public void SayHello(string name)
        {

            Console.WriteLine($"Hello, {name}");
        }


        // Overload method 
        //Same name, different parameters
        public void SayHello()
        {
            Console.WriteLine("What's up homie");
        }

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "What up", "Yo" };
            int randomNumber = rando.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);

            Console.WriteLine($"{randomGreeting}");
        }
        public string RandomGreeting()
        {
            string[] availableGreetings = new string[] { "Hello", "What up", "Yo" };
            int randomNumber = rando.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);

            return randomGreeting;

            Console.WriteLine($"{randomGreeting}");
        }
    }

}
