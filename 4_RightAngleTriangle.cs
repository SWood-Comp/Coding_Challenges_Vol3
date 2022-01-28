using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _4_RightAngleTriangle
    {
        static void Main()
        {
            int rows;       // declare tha variable for row amount

            Console.WriteLine("Display the pattern as right angle triangle using number:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input number of rows : ");
            rows = int.Parse(Console.ReadLine());       // take number of rows from the user.

            for (int i = 1; i <= rows; i++)     // OUTER LOOP - controls the number of rows
            {
                for (int j = 1; j <= i; j++)    // INNER LOOP - controls the values on each separate row.
                {
                    Console.Write("{0}", j);
                }
                Console.Write("\n");
            }

        }
    }
}
