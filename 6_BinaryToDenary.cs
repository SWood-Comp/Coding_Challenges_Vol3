using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _6_BinaryToDenary
    {
        static void Main()
        {
            int column = 1;
            string binaryNum = "";
            int denaryNum = 0;

            Console.WriteLine("Convert a Binary number to a Denary number using for loop and without using array:");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input a binary number:  ");
            binaryNum = Console.ReadLine();
            int len = binaryNum.Length;

            // for loop - iterates from the right end of the string towards the left by 1 each time.
            // as if reading binary...

            for (int i = len - 1; i >= 0; i--)  // FOR loop is high to low, so effectively right ot left of the string
            {
                if (binaryNum[i] == '1')        // test against a char from the string (right to left)
                {
                    denaryNum = denaryNum + (1 * column);       // add on the current column heading to the total number
                }

                column *= 2;    // multiply the column by 2 to keep in with binary column headings
            }
            Console.WriteLine("\nThe Binary Number : {0}\nThe equivalent Denary Number : {1} \n", binaryNum, denaryNum);

        }
    }
}
