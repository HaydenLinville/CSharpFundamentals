using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nascar
{
    public class Car
    {



        public enum Gears { One, Two, Three, Four, Five, Six, N, R}


        public bool IsRunning { get; set; }

        public double Fuel { get; set; }

        public int Number { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        //might need to change the type
        public string FrontDriverTire   { get; set; }

        public string FrontPassengerTire { get; set; }

        public string RearDriverTire { get; set; }

        public string RearPassengerTire { get; set; }

        //methods

        public void TurnOn()
        {
            IsRunning = true;
            Gears start = Gears.One;
            
            Console.WriteLine("The Car is On and in First Gear");

        }

        public void TurnOff()
        {
            IsRunning = false;
            Gears stop = Gears.N;
            Console.WriteLine("The Car is Off and in Neutral");

        }

        //not correct need to come back to it 
        public Gears ShiftUp(Gears starting)
        {
            if (starting < Gears.Two)
            {
                starting = Gears.Two;
                Console.WriteLine("You are now in second gear");
            }
            else if (starting < Gears.Three)
            {
                starting = Gears.Three;
                Console.WriteLine("You are now in third gear");
            }
            else if (starting < Gears.Four)
            {
                starting = Gears.Four;
                Console.WriteLine("You are now in fourth gear");
            }
            else if (starting < Gears.Five)
            {
                starting = Gears.Five;
                Console.WriteLine("You are now in 5th gear");
            }
            else if (starting < Gears.Six)
            {
                starting = Gears.Six;
                Console.WriteLine("You cannot go higher than 6th gear");
            }
 

            return starting;

            


        }

        public Gears ShiftDown(Gears starting)

        {

            if (starting > Gears.Two)
            {
                starting = Gears.One;
                Console.WriteLine("You cannot go any lower than 1st gear");
            }
            else if (starting > Gears.Three)
            {
                starting = Gears.Three;
                Console.WriteLine("You are now in third gear");
            }
            else if (starting > Gears.Four)
            {
                starting = Gears.Four;
                Console.WriteLine("You are now in fourth gear");
            }
            else if (starting > Gears.Five)
            {
                starting = Gears.Five;
                Console.WriteLine("You are now in 5th gear");
            }
            else if (starting > Gears.Six)
            {
                starting = Gears.Six;
                Console.WriteLine("You cannot go higher than 6th gear");
            }
            return starting;
        }

    }
}
