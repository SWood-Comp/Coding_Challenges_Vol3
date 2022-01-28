using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _2_RangeOfPrimeNums
    {
        static void Main()
        {
            int num, i, start, end;
            bool isPrime = true;

            Console.WriteLine("Find the prime numbers within a range of numbers:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input start of range: ");
            start = Convert.ToInt32(Console.ReadLine());        // start and end values are declared here
            Console.Write("Input end of range: ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start, end);

            for (num = start; num <= end; num++)        // FOR loop - controlled by the start and end values used above.
            {
                isPrime = true;     // isPrime is reset to true for each new value tested.

                for (i = 2; i <= num / 2; i++)  // FOR loop - will work from 2 upto the current number / 2 to calculate all factors
                {
                    if (num % i == 0)       // if a factor is exactly divisible by the current value it will trigger the boolean to false
                    {
                        isPrime = false;    // set to false if it isn't a possible prime number.
                        break;              // break command effectively stops the loop as it can no longer be prime, so stops wasting time checking the rest.
                    }
                }

                if (isPrime == true && num != 1)    // if it isPrime and value isn't '1' then it outputs it.
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");

        }
    }
}
