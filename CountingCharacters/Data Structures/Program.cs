using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //input a string and count all charaters in it using dictionary
            //varables
            Dictionary<char, long> charCounts = new Dictionary<char, long>();
            //string input = "";
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            /*//input
            Console.WriteLine("Please input the desired string to be tested: ");
            input = Console.ReadLine();*/

            //process
            foreach (char letter in input)
            {
                if (charCounts.ContainsKey(letter))
                {
                    charCounts[letter] = charCounts[letter] + 1;
                }
                else
                {
                    charCounts.Add(letter, 1);
                }
            }

            //output
            foreach (KeyValuePair<char,long> charCount in charCounts)
            {
                Console.WriteLine(charCount.Key + ": " + charCount.Value);
            }
        }
    }
}
