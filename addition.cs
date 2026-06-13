using System;

namespace Sample
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Adding 2 numbers*/
            int firstnum;
            int secnum;
            int sum;

            Console.Write("Enter your First Number: ");
            firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Second Number: ");
            secnum = Convert.ToInt32(Console.ReadLine());

            sum  = firstnum + secnum;

            Console.Write("The sum of the two number is : " + sum);



            Console.ReadKey();
        }
    }
 }


