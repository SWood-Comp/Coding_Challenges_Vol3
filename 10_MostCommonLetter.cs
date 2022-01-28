using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _10_MostCommonLetter
    {
        static void Main()
        {
            //------------- Using a Dictionary (key, value) setup --------------------------------------------------

            string message = "";
            Dictionary<char, int> charsFrequency = new Dictionary<char, int> { };   // declare Dictionary for <char, value> pairings

            Console.WriteLine("Find maximum frequency character in a string :");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input the string: ");

            message = Console.ReadLine();

            foreach (char c in message)  //Set frequency of all characters to 1 when they have been found
            {
                if (charsFrequency.ContainsKey(c) == false)  // if the Dictionary does NOT contain the Key (character) of 'c' then add it
                {
                    charsFrequency.Add(c, 1);       // add each character in with a value of 1
                }
                else
                {
                    charsFrequency[c]++;        // if the dictionary already contains that character, increase the value by 1.
                }
            }

            // Read whole dictionary for each Key & Value pairing
            foreach(KeyValuePair<char, int> pair in charsFrequency)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);       // outputs each Key and Value of that pair.
            }

            // Declare MaxFreq value and MaxChar to be set to the most frequently found
            int MaxFreq = 0;
            char MaxChar = '0';

            foreach (KeyValuePair<char, int> pair in charsFrequency)        // scans full dictionary
            {
                if(pair.Value > MaxFreq)        // if the value of this entry is greater than maximum 
                {
                    if (pair.Key != ' ')        // and not a space
                    {
                        MaxFreq = pair.Value;   // replace the MaxFreq value here
                        MaxChar = pair.Key;     // replace the MaxChar character here
                    }
                }
            }

            Console.WriteLine("The Highest Frequency character(s) is:");

            foreach (KeyValuePair<char, int> pair in charsFrequency)
            {
                if(pair.Value == MaxFreq)       // this deals with multiple letter appearing the same amount of times.
                {
                    Console.WriteLine("Character '{0}' - Appears {1} times.", pair.Key, pair.Value);    // outputs each max pair.
                }
            }


            // ---------------------- Older method - NO Dictionary used -------------------------------------------
            
            //string str;
            //int[] charFreq = new int[255];
            //int i = 0, max, len = 0;
            //int ascii;

            //Console.WriteLine("\nFind maximum occurring character in a string :");
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Input the string: ");

            //str = Console.ReadLine();
            //len = str.Length;

            //for (i = 0; i < 255; i++)  //Set frequency of all characters to 0
            //{
            //    charFreq[i] = 0;
            //}

            ///* Read for frequency of each characters */
            //i = 0;
            //while (i < len)
            //{
            //    ascii = (int)str[i];
            //    charFreq[ascii] += 1;

            //    i++;
            //}

            //// Console.Write("{0}  ",(char)65);
            //max = 0;
            //for (i = 0; i < 255; i++)
            //{
            //    if (i != 32)
            //    {
            //        if (charFreq[i] > charFreq[max])
            //            max = i;
            //    }
            //}
            //Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, charFreq[max]);


        }

    }
}

