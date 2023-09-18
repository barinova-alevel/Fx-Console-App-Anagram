using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Anagram
{
    internal class Anagram
    {
        public string PrintText()
        {
            string userInput = "";

            Console.WriteLine("Enter the initial text:");
            userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Please enter text");
                //or press Esc to terminate running
                //handle empty user input
                return userInput = "";
            }
            return userInput;

        }


        public string[] Split(string userInput)
        {
            string[] words = userInput.Split(' ');
            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
            foreach (var word in words)
            {
                char[] toBeReversed = word.ToCharArray();
                Array.Reverse(toBeReversed);
                //add logic to avoid not alphabetical symbols
                foreach (var item in toBeReversed)
                {
                    Console.Write(item);
                }
               
            }
            return words;
        }
    }
}
