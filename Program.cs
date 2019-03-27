using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello user what are you in the mood for?");
            Console.WriteLine("1. Action 2. Chilling 3.Danger 4. Good Food");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Stock Car Racing");
                //Console.Read();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("HIking");
                //Console.Read();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Skydiving");
                //Console.Read();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Go to Taco Bell");
                //Console.Read();
            }

            Console.WriteLine("How many people are you bringing with you?");
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());

            if (numberOfPeople == 0)
            {
                Console.WriteLine("Wear some sneakers");
                Console.Read();
            }
            else if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                Console.WriteLine("Rent a sedan");
                Console.Read();
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 10)
            {
                Console.WriteLine("Take the bus");
                Console.Read();
            }
            else if (numberOfPeople >= 11)
            {
                Console.WriteLine("Take an airplane");
                Console.Read();
            }

            Console.WriteLine("see you later!");
            Console.Read();
        }
    }
}