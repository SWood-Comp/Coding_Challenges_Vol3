using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengesVol3
{
    class _7_AccessDenied
    {
        static void Main()
        {
            const string password = "C0mputer-Sc1ence";

            string guess = "";  // declare the guess they have had as a blank string to b
            int count = 5;      // declare the amount of guesses someone can have

            // DO WHILE loop has been used as they will need to enter their password a minimum of one time.
            do
            {
                Console.Write("Please enter your password:  ");
                guess = Console.ReadLine();                 // take in the users guess.

                if (guess == password && count > 0)         // if guess is correct and attempts left is greater than 0
                {
                    Console.WriteLine("Access Granted...");
                    break;
                }
                else if (guess != password && count > 0)    // if guess is incorrect and attempts left is greater than 0
                {
                    Console.WriteLine("Access Denied...");  // guess again message
                    count--;                                // take one guess from the total left.

                    if (count == 0)                         // if no guess left then reply with 'Out of Guesses'
                    {
                        Console.WriteLine("Out of guesses!");
                    }
                    else
                    {
                        Console.WriteLine("Please try again...");
                    }
                }

            } while (guess != password && count > 0);       // loop WHILE guess in not the password and attempts left > 0.
        }
    }
}
