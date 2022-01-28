using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class HARD_12_TwosComplement
    {
        static void Main()
        {
            int column = 1;
            string binaryNum = "", twosComp = "";
            bool flip = false;

            Console.WriteLine("Convert a positive Binary number to its negative (Twos Complement) equivalent:");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            Console.Write("Input a binary number:  ");
            binaryNum = Console.ReadLine();

            // add a positive sign bit here...
            binaryNum = "0" + binaryNum;

            // now measure it for the purpose of the loop
            int len = binaryNum.Length;

            // for loop - iterates from the right end of the string towards the left by 1 each time.
            // as if reading binary...

            for (int i = len - 1; i >= 0; i--)
            {
                if (flip != true)   // flip is based on finding the first 1 bit working from right to left...
                {
                    if (binaryNum[i] == '0')    
                    {
                        twosComp = '0' + twosComp;      // if a '0' then keep its as a '0'
                    }
                    else if (binaryNum[i] == '1')
                    {
                        twosComp = '1' + twosComp;      // if a '1' then keep it as '1' but change the boolena flag to true.
                        flip = true;        // set the flip to true as you have found the first '1' in the binaryNum now
                    }
                }
                else if (flip == true)  // flip has now been triggered so every other bit simply gets flipped to its opposite.
                {
                    if (binaryNum[i] == '0')
                    {
                        twosComp = '1' + twosComp;
                    }
                    else if (binaryNum[i] == '1')
                    {
                        twosComp = '0' + twosComp;
                    }
                }

            }
            Console.WriteLine("\nThe Binary Number : {0}\nThe equivalent Twos Complement Number : {1} \n", binaryNum, twosComp);

        }
    }
}
