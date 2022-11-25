using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; 
            long result;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            result = CalculateFatorial(number);

            Console.WriteLine($"{number}! = {result}");

            Console.ReadKey();
        }

        static int CalculateFatorial(int number)
        {
            if (number == 0)
                return 1;

            else
                return number * CalculateFatorial(number - 1);
        }
    }
}
