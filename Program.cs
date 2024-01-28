using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again;

            do
            {
                Console.WriteLine("Enter any number to get the Fibonacci sequence: ");
                int num;

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number : ");
                }

                Console.WriteLine("The Fibonacci sequence that starts with your entered number is:");
                Display(num);

                Console.Write("Do you want to get the sequence for another number? (Y/N) ");
                again = Console.ReadLine();

                while (!(again.ToUpper() == "Y" || again.ToUpper() == "N"))
                {
                    Console.Write("Invalid input. Please enter Y or N: ");
                    again = Console.ReadLine();
                }

            } while (again.ToUpper() == "Y");

            if (again.ToUpper() == "N")
            {
                Console.WriteLine("Please press enter key to end...");
                Console.ReadLine();
            }
        }

        static void Display(int num)
        {
            int a = num, b = a;

            Console.Write(a + " ");

            int temp;
            do
            {
                Console.Write(b + " ");

                temp = a;
                a = b;
                b = temp + b;

            } while (b <= int.MaxValue - a);

            Console.WriteLine();
        }
    }
}

