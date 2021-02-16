using System;

namespace FundamentalsOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            //     Console.WriteLine("Hello World!");

            //Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (!(i % 3 == 0 && i % 5 == 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //     // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }

            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            int j = 1;
            while (j <= 100)
            // for (int j = 1; j <= 100; j++)
            {
                if(j % 15 == 0)
                {
                    j++;
                    continue;
                }

                if(j % 3 == 0 || j % 5 == 0)
                {
                    Console.WriteLine(j);
                }
                j = j + 1;
            }

        }
    }
}
