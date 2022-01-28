using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class HARD_13_HexConverter
    {
            // Creates a Dictionary for all of the relevant Hex characters and Binary representations 
            // Each has its own match (Key, Value) ... e.g. ('a', "1010"), where 'a' is the Key and "1010" is the Value

            private static readonly Dictionary<char, string> HexCharToBinary = new Dictionary<char, string> {
                { '0', "0000" },    { '1', "0001" },    { '2', "0010" },    { '3', "0011" },
                { '4', "0100" },    { '5', "0101" },    { '6', "0110" },    { '7', "0111" },
                { '8', "1000" },    { '9', "1001" },    { 'a', "1010" },    { 'b', "1011" },
                { 'c', "1100" },    { 'd', "1101" },    { 'e', "1110" },    { 'f', "1111" }  };

            public static void Main()
            {
                Console.WriteLine("Please enter a Hexadecimal String: ");
                string Hex = Console.ReadLine();

                string Binary = HexStringToBinary(Hex);     // uses the second subroutine to pass in the Hex string and it returns with the Binary version.
                Console.WriteLine("Binary equivalent is: {0}", Binary);

                int Denary = BinaryToDenary(Binary);        // uses the final subroutine to pass in the Binary string and it returns with the Denary number.
                Console.WriteLine("Denary equivalent is: {0}", Denary);
            }

            public static string HexStringToBinary(string hex)
            {
                StringBuilder result = new StringBuilder();     // StringBuilder - works just like a string would but it has helpful methods you can use such as 'Append', 'Add', 'Remove' etc...
                foreach (char c in hex)
                {
                    // This will crash for non-hex characters. You may need to handle this in future (Try, Catch would suffice).
                    result.Append(HexCharToBinary[char.ToLower(c)]);
                }
                return result.ToString();
            }

            public static int BinaryToDenary(string binary)     // effectively the same program from Challenge #6
            {
                int column = 1;
                int denaryNum = 0;
                int len = binary.Length;

                for (int i = len - 1; i >= 0; i--)
                {
                    if (binary[i] == '1')        // test against a char from the string (right to left)
                    {
                        denaryNum = denaryNum + (1 * column);
                    }

                    column *= 2;    // multiply the column by 2 to keep in with binary column headings
                }

                return denaryNum;
            }
    }
}
