using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class HARD_11_MorseEncoder
    {
        static void Main()
        {
            Console.WriteLine("Please enter your string to convert to Morse Code:");

            string PlainText = Console.ReadLine();

            string MorseMessage = EncodeMorse(PlainText);       // fetch the Morse message from the new function.

            Console.WriteLine(MorseMessage);                    // output the MorseMessage that was returned.
        }


        public static string EncodeMorse(string incomingMessage)
        {
            StringBuilder stringB = new StringBuilder();     // enables you to use a string but with helpful methods built into this class.

            // Below is what is a powerful command as it does a lot of work in just one line of code.

            char[] messageTxt = incomingMessage.ToLower().ToCharArray();        // takes the string input, converts it all to Lowercase and then splits it up into individual characters in an Array.

            Dictionary<char, string> _dictionary = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},       // {'d', string.Concat(dash, dot, dot)},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {',', "--..--"},
                {'!', "-.-.--"},
                {'?', "..--.."},
                {':', "---..."},
                {'\'', ".----."},       // Note the extra ' after the backslash '\'' this is because a backslash is a metacharacter and has special abilities (to nullify or enhance the following character)
                {'.', ".-.-.-"}
            };

            foreach (char txtChar in messageTxt)        // for each character in the message
            {
                foreach (KeyValuePair<char, string> item in _dictionary)    // scan the full dictionary and find a macth for that character.
                {
                    if (item.Key == txtChar)
                        stringB.Append(item.Value + " ");       // add the morse string and a space to the StringBuilder string
                }
                if (char.IsWhiteSpace(txtChar))     // if you find a space,  instead add several spaces to determine the end of each word clearly.
                    stringB.Append("  ");           // Append: simply means 'Apply to the End'
            }
            return string.Join(" ", stringB).TrimEnd();     // TrimEnd() simply cuts off the spaces from the end of the message if no characters follow on from this.
        }


    }
}
