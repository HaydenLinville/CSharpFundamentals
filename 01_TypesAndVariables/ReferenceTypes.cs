using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void String()
        {
            //String is a collections of chars

            //Declarc

            string thisIsDeclared;

            // Initialized by assigning

            string declared;
            declared = "This is initialized";

            // Declared a value and initialized
            string declaredAndInitilized = "This is both declaring and initializing";

            string number = "80085";

            string nullString;
            string emptyString = "";

            string firstName = "Hayden";
            string lastName = "Linville";

            //Concatenation 

            string concatenetedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenetedFullName);

            //Compositing
            string compositeFullname = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullname);

            // Interpolation $ lets it know

            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);

            
        }


        [TestMethod]
        public void Collections()
        {

            string stringExample = "This is a collection of chars";

            //Once an array is set you have to take it all apart to change anything

            string[] stringArray = { "Hello", "World", "Why" };

            // Random note OOP everything is considered and object in the computers memeory

            Console.WriteLine(stringArray[2]);

            //Updating a value by it's index 
            stringArray[0] = "Who";

            stringArray[2] = "Changed";
            Console.WriteLine(stringArray[2]);

            // Like an array but more dynamic (Can add and remove things.)
            List<string> listofStrings = new List<string>();
            List<int> listOfIntergers = new List<int>();

            listofStrings.Add("A string");
            listOfIntergers.Add(12900);
            
            //First in first out, like getting in line
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");


            // A collection of key value pairs
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();


            //Have to give it a key, 7, and a value, "Agent"
            keyAndValue.Add(7, "Agent");

            Dictionary<string, string> realDictionary = new Dictionary<string, string>();

            realDictionary.Add("Know", "Be aware of through observation, inquiry, or information");

            Console.WriteLine(realDictionary["Know"]);

            // Extra collections types, not as useful but good to know they exist

            //Dictionary that is sorted so the value can be accessed by the key and the index
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();

            //"never used. Look up if you want to know.
            HashSet<int> uniqueList = new HashSet<int>();

            //like Stacking objects, last object added is first off the 'stack'
            Stack<string> lastInFirstOut = new Stack<string>();

       

        }

        [TestMethod]
        public void Classes()
        {
            //Heavey subject. Whole day one it later.
            
            //Use new to make a 'new' instance of a class
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);

        }
    }

}
