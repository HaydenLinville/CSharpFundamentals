using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{

    public enum DietType { Herbivore = 1, Carnivore, Omivore}

    public abstract class Animal
    {// Cannot be intatiated on it's own 
        //can only be derived by child classes 

        public Animal()
        {
            Console.WriteLine("this is the animal constructor");
        
        }


        public int NumberOfLegs { get; set; }
        public bool IsMamal { get; set; }
        public bool HasFut { get; set; }

        public DietType Diet { get; set; }
        //Virtual: Can be overriden by a derived class. (A child class can over write it)
        public virtual void Move()
        {
            Console.WriteLine($"this {GetType().Name} moves");
        }


    }
}
