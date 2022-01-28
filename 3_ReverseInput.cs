using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _3_ReverseInput
    {
        static void Main()
        {
            int num, r, sum = 0;

            Console.WriteLine("Display the number in reverse order:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n");

            //------------ with a mathematical method ----------------------------------

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int t = num; t != 0; t = t / 10)       // this works for each digit on the input (column for denary number)
            {
                r = t % 10;             // gets the remainder 
                sum = sum * 10 + r;     // adds that to the total sum
            }
            Console.Write("The number in reverse order is : {0} \n", sum);

            //------------ with a string instead ----------------------------------

            string number = "", reversed = "";      // declare two strings, one for now and one for the result

            Console.Write("Input a number: ");
            number = Console.ReadLine();

            int len = number.Length;

            for (int i = len-1; i >= 0; i--)        // FOR loop - to go from right to left of the string.
            {
                reversed = reversed + number[i];    // concatenate (add together) so the end character is added to the opposite end of the new string.
            }
            Console.Write("The number in reverse order is : {0} \n", reversed);
        }
    }
}
