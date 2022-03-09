using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console.UI
{

    


    public class MockConsole : IConsole
    {
        private readonly Random _random;
        public MockConsole()
        {
            _random = new Random();
        }


        public void Clear()
        {
            Console.Clear();
            Console.BackgroundColor = RndColor();
        }

        public ConsoleColor RndColor()
        {
            
            int colorIndex = _random.Next(0, 16);
            return (ConsoleColor)colorIndex;
        }

        public ConsoleKeyInfo ReadKey()
        {
            Console.Beep(100, 1);
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Umm...");
            Thread.Sleep(100);
            Console.WriteLine("You Sure...?");
            Thread.Sleep(150);
            Console.WriteLine(".....Okay");

            return input;
        }

        public void Write(string s)
        {
            foreach(char letter in s)
            {
                Console.ForegroundColor = RndColor();
                Console.Write(letter);
            }
      
        }

        public void WriteLine(string s)
        {
            //sArCaStIc
            Console.ForegroundColor = RndColor();
            bool captialize = false;
            foreach (char letter in s)
            {

                if (captialize)
                {
                    Console.Write(char.ToUpper(letter));
                    captialize = false;
                }
                else
                {
                    Console.Write(char.ToLower(letter));
                    captialize = true;
                }
            }
            Thread.Sleep(50);
            Console.Write("\n");

        }

        public void WriteLine(object o)
        {
            Console.ForegroundColor = RndColor();
            Console.WriteLine(o);
        }

        public void WriteLine()
        {
            Console.WriteLine("vvvvvvvvvvvvvvvvvvvvvvvvvvvvv\n" +
                "\n" +
                "\n");
        }
    }
}
