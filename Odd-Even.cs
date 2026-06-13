using System;

namespace Sample
{
    class Program
    {
        public static void Main(string[] args)
        {
            // tell if odd or even
            int number;

            Console.WriteLine("Odd or Even");
            Console.Write("Input a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("The number you entered is Even");
            }
            else
            {
                Console.WriteLine("The number you entered is Odd");
            }
            Console.ReadKey();
        }
    }
 }


