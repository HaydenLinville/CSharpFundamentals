using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VechicleType { Car, Truck, Van, Motorcyle, Spaceship, Planes, Boat }
    //Accessor Types:
    //Public: available throughout the full assembly (00_MorningChallenges - 05_Classes)
    //Private: only available in the same class or struct
    //Protected: like private but accessible by derived classes
    //Internal: Accessible in this assembly only
    //Protected Internal: accessible in this assembly only and derived classes in other assemblies
    //Private Protected: Only in this class, by code in the same class, and derived 


    public class Vechicle //(Noun)
    {
        //Constructor It is empty 
        public Vechicle() //Implicit Only here if no other constrocter 

        {
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();

        } 
        public Vechicle(string make, string model, double mileage, VechicleType vechicleType)
        {
            //What are these?
            Make = make;
            Model = model;
            Mileage = mileage;
            VehicleType = vechicleType;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }


        // All inside of class Fields, Properties (adjetives), and Methods (Verbs) 

        //Properties change values 

        //1 Access modifer + where can this be seen"
        //2 Type = what type of property is it?
        //3 name what it called?
        //4 getters and setters = how do I set it how do I get it?


        //1      2      3      4
        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; }
       
        public VechicleType VehicleType { get; set; }

        public bool IsRunning { get; private set; } //proprities

        public Indicator RightIndicator { get; set; }

        public Indicator LeftIndicator { get; set; }


        // methodes are below proprities (engine 

        public void TurnOn() //methodes 
        {
            IsRunning = true;
            Console.WriteLine("You turn on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("you start driving the vehicle");
            }
            else
            {
                Console.WriteLine("Turn the thing on you dummy!");
            }
        }

        public void IndicateRigh()
        {
            RightIndicator.LightsOn();
            LeftIndicator.LightsOff();
        }
        public void IndicateLeft()
        {
            RightIndicator.LightsOff();
            LeftIndicator.LightsOn();
        }
        public void ClearIndicators()
        {
            RightIndicator.LightsOff();
            LeftIndicator.LightsOff();
        }

        public void TurnOnHazards()
        {
            RightIndicator.LightsOn();
            LeftIndicator.LightsOn();

        }


    }


    public class Indicator
    {

        public bool IsFlashing { get; private set; }

        public void LightsOn()
        {
            IsFlashing = true;
            
        }

        public void LightsOff()
        {
            IsFlashing = false;
            
        }
    }

}
