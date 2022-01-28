using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _8_CountTheCapitals
    {
        static void Main()
        {
            string message = "";

            Console.Write("Please enter your message:  ");
            message = Console.ReadLine();

            List<int> result = new List<int>();     // create a List of integers to store the results
            List<char> caps = new List<char>();     // create a Lisyt of characters to store the capitals.

            for (int i = 0; i < message.Length; i++)    // for the length of the message
            {
                if (char.IsUpper(message[i]))       // test if the current character is Uppercase?
                {
                    result.Add(i);                  // if it is Upper then add the current index to the List of results.
                    caps.Add(message[i]);           // also add the Capital itself into the List of caps.
                }
            }

            Console.Write("Found Capitals:  ");
            foreach (char Capital in caps)          // output all the Capitals found in the string
            {
                Console.Write("{0}\t", Capital);
            }

            Console.Write("\nFound Positions:  ");  
            foreach (int index in result)           // output all the indices/positons where they were found.
            {
                Console.Write("{0}\t", index);
            }

        }

        // Below is a separate subroutine that would take in a string and it would simply return an array of integers
        public static int[] IndexOfCapitals(string str)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    result.Add(i);
            }

            return result.ToArray();
        }
    }
}
