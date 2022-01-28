using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _9_StringInString
    {
        public static void Main()
        {
            string messageString;
            string findstring;
            int start = 0;
            int count = -1;
            int index = -1;

            Console.WriteLine("\nFind the number of times a specific string appears in a string :");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Input the original string : ");
            messageString = Console.ReadLine().ToUpper();       // convert both strings to uppercase to make the tests easier later on
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine().ToUpper();


            // 'start' will be the first character in the string being searched for.
            // The condition on the WHILE loop will be based on 'NO' start being found, hence it would return -1.
            // While a start is found it will not equal -1, so the loop will continue to run.
            while (start != -1)
            {
                start = messageString.IndexOf(findstring, index + 1);       // IndexOf used to find the word to be found in the bigger string
                count += 1;         // count increased by one when the word is found
                index = start;      // index is updated to the start of the word found, so it cannot be found again.
            }
            Console.Write("The string '{0}' occurs " + count + " times.\n", findstring);
        }

    }
}
