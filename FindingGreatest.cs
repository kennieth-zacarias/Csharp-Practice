using System;

namespace Sample
{
    class Program
    {
        public static void Main(string[] args)
        {

            /* Greatest Numbers using if else */
            double firstnum;
            double secnum;
            double thirdnum;
    
            Console.Write("Enter your First Number: ");
            firstnum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Second Number: ");
            secnum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Third Number: ");
            thirdnum = Convert.ToDouble(Console.ReadLine());

            if (firstnum > secnum && firstnum > thirdnum)
            {
                Console.WriteLine("First number is the greatest.");
            }
            else if (secnum > firstnum && secnum > thirdnum)
            {
                Console.WriteLine("Second number is the greatest.");
            }
            else if (thirdnum > firstnum && thirdnum > secnum)
            {
                Console.WriteLine("Third number is the greatest.");
            }
            else if (firstnum == secnum && firstnum > thirdnum)
            {
                Console.WriteLine("First and Second numbers are both greatest numbers.");
            }
            else if (firstnum == thirdnum && firstnum > secnum)
            {
                Console.WriteLine("First and Third numbers are both greatest numbers.");
            }
            else if (secnum == thirdnum && secnum > firstnum)
            {
                Console.WriteLine("Second and Third numbers are both greatest numbers.");
            }
            else
            {
                Console.WriteLine("All three numbers are equal.");
            }


            Console.ReadKey();
        }
    }
}


