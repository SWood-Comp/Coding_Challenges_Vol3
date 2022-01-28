using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _1_SumNaturalNumbers
    {
        static void Main()
        {
            int i, n, sum = 0;

            Console.WriteLine("Calculate 'n' terms of even natural number and their sum:");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input number of terms : ");      // input how many terms
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe even numbers are : \n");

            for (i = 1; i <= n; i++)        // FOR loop - that number of terms is looped over.
            {
                Console.Write("{0} \t", 2 * i);     // output that value * 2
                sum += 2 * i;       // add the value calculated to the running total.
            }
            Console.Write("\nThe Sum of even Natural Number upto {0} terms : {1} \n", n, sum);

        }
    }
}
