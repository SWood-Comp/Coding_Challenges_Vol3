using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class DictionaryTest
    {
        static void Main()
        {
            string message = "";
            Dictionary<char, int> charDict = new Dictionary<char, int> { };   // declare Dictionary for <char, value> pairings

            charDict.Add('a', 10);
            charDict.Add('b', 11);
            charDict.Add('c', 12);
            charDict.Add('d', 13);
            charDict.Add('e', 14);
            charDict.Add('f', 15);


            // Read whole dictionary for each Key & Value pairing
            foreach (KeyValuePair<char, int> pair in charDict)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);       // outputs each Key and Value of that pair.
            }


            /*
             * 
             * Console.WriteLine("Find maximum frequency character in a string :");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Input the string: ");

            message = Console.ReadLine();

            foreach (char c in message)  //Set frequency of all characters to 1 when they have been found
            {
                if (charDict.ContainsKey(c) == false)  // if the Dictionary does NOT contain the Key (character) of 'c' then add it
                {
                    charDict.Add(c, 1);       // add each character in with a value of 1
                }
            }
            */



        }
    }
}
