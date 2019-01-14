using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i;
            bool isInvalidInput, shouldContinue;
            string y;
           
            Console.WriteLine("Please enter your name.");
            var name = Console.ReadLine();
            do
            {
                do
                {
                    Console.WriteLine(name + ", Please enter a number between 1 and 100");
                    string integer = Console.ReadLine();
                    i = int.Parse(integer);
                    isInvalidInput = i < 1 || i > 100;
                }
                while (isInvalidInput);
                if (i % 2 == 0)
                {
                    if (i % 2 == 0 && i <= 25)
                    {
                        Console.WriteLine(name + ", This number is even and less than 25");
                    }

                    if (i % 2 == 0 && i >= 60)
                    {
                        Console.WriteLine(i + ", That's even " + name);
                    }

                    if (i % 2 == 0 && i >= 26 && i <= 60)
                    {
                        Console.WriteLine(name + ", Even");
                    }
                }
                else
                {
                    Console.WriteLine(i + ", That number is odd " + name);
                }

                Console.WriteLine("Continue? y/n");
                input = Console.ReadLine();
                shouldContinue = input == "y";
            }
            while (shouldContinue);
        }
    }
}
