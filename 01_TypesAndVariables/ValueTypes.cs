using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        //Comment Ctrl + K C
        /* Long Comment ctrl + shift + /  */

        //PascalCaseCapitialization
        //camelCaseCapitization


        [TestMethod]
        public void Booleans()
        {
            // Declaring a variable
            bool declared;

            // Assigning a variable, becomes initilized 
            declared = true;

            // Declare and Initiliz a variable

            bool declarationandInitilized = false;

            // Assiging after declaration
            declarationandInitilized |= true;

        }

        [TestMethod]
        public void Characters()
        {
            //char hold a single character 
            char Character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';

        }
        [TestMethod]
        public void WholeNumbers()
        {
            //small to big 

            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            //most common
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            //ctr k+d lineup everything

            int a = 15;
            int b = -10;


        }
        [TestMethod]
        public void Decimals()
        {

            // 7 digits of precision
            float floatExample = 1.120012f;

            // 15-16 digits of precision (bigger min and max but not as accurate)
            double doubleExample = 12.1212309324d;

            // 28-29 digits of precision
            decimal decimalExample = -123.2231244m;
        }

        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Crossant};


        [TestMethod]
        public void Enums()
        {
            //used to build your own type
            PastryType myPastry = PastryType.Crossant;


        }

        [TestMethod]
        public void Structs()
        {

            //Seems like it uses data inside to fetch other data?

            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1993, 9, 20);


        }
    }

}
