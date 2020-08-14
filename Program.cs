using System;
using static System.Console;

namespace tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs are there?");
            int count;
            string input = Console.ReadLine();
            if(int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs");
            }
            else 
            {
                Console.WriteLine("Could not parse the input");
            } 

            WriteLine("before parsing");

            Write("What is your age?");
            string input1 = ReadLine();

            try
            {
                int age = int.Parse(input1);
                WriteLine($"You are {input1} years old");
            }
            catch(OverflowException)
            {
                WriteLine("The input was a number but it was either too large or too small");
            }
            catch(FormatException)
            {
                WriteLine("The age you entered is not a valid number");
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Write("After parsing");
        }
    }
}
