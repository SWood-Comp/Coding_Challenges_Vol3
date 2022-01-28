using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _5_FullTriangle
    {
        static void Main()
        {
            // declare variables here:
            int spaces, rows;   // need to know how many rows and spaces we are dealing with
            int num = 1;        // 'num' is set to be the number that will actually be writtten on the tree

            Console.WriteLine("Display the pattern like pyramid with numbers increased by 1:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n");

            Console.Write("input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());     // user enters how many rows to work for

            spaces = rows + 4 - 1;      // spaces worked out based on how many rows we have.

            for (int i = 1; i <= rows; i++)     // OUTER FOR loop controls how many rows to do this for
            {
                // FOR LOOP - do the spaces on that row first
                for (int k = spaces; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                // FOR LOOP - do the numbers on that row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", num++);
                }

                Console.Write("\n");    // write a new line command after each row is complete.
                spaces--;       // subtract 1 from spaces for the next row to work properly.
            }

        }
    }
}
