using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {

        
        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

        }
        

        //contstants 
        private const double MaxLength = 30;
        private const double MinLength = 6;
        private const double MaxWidth = 50;
        private const double MinWidth = 5;
        private const double MaxHeight = 100;
        private const double MinHeight = 5;

        //fields
        private double _length;
        private double _width;
        private double _height;

        //Properties
        public double Length
        {
            get { return _length; }
           
          private  set
            {
                if (value < MinLength || value > MaxLength)
                {

                    throw new ArgumentException($"Length must be between {MinHeight} and {MaxHeight}!");
                }
                else
                    _length = value;

            }
        }

        public double Width
        {
            get { return _width; }
           private set
            {
                if (value < MinWidth && value > MaxWidth)
                {

                    throw new ArgumentException($"Width must be between {MinHeight} and {MaxHeight}!");
                }
                else
                    _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
           private set 
            {
                if (value < MinHeight && value > MaxHeight)
                {
                    throw new ArgumentException($"Height must be between {MinHeight} and {MaxHeight}!");
                }
                else
                    _height = value;

            }
        }

        //Methods 
        public double SquFoo()
        {
            return Length * Width;



        }

        public double LatSurA()

        {
            double v1 = _length * _height * 2;
            double v2 = _width * _height * 2;
            return v1 + v2;
        }
        // need to add surface area 

    }
}
