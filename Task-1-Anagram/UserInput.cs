using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Anagram
{
    internal class UserInput
    {
        public string ReadUserInput()
        {
            string s;
            Console.WriteLine("Enter the initial text:");
            do
            {
                s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("Empty input, please try again");
                }
            } while (string.IsNullOrEmpty(s));
            return s;
        }
    }
}
