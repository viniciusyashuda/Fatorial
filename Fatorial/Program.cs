using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number; long result;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            result = fatorial(number);

            Console.WriteLine($"{number}! = {result}");

            static int fatorial(int number)
            {

                if(number == 0)
                {

                    return 1;

                }
                else
                {

                    return ((number) * (fatorial(number - 1)));

                }
            }

            Console.ReadKey();

        }
    }
}
