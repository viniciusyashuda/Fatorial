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

            result = fat(number);

            Console.WriteLine($"{number}! = {result}");

            static int fat(int number)
            {

                if(number == 0)
                {

                    return 1;

                }
                else
                {

                    return ((number) * (fat(number - 1)));

                }
            }

            Console.ReadKey();

        }
    }
}
