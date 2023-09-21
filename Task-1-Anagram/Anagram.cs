using System.Text;

namespace Task_1_Anagram
{
    internal class Anagram
    {
        public void Reverse()
        {
            StringBuilder result = new StringBuilder();

            string[] words = PrintText().Split(' ');
            foreach (var word in words)
            {
                char[] toBeReversed = word.ToCharArray();
                ReverseWord(toBeReversed);
                result.Append(toBeReversed);
                result.Append(' ');
            }

            Console.WriteLine(result.ToString());
        }

        private string PrintText()
        {
            Console.WriteLine("Enter the initial text:");
            string userInput = Console.ReadLine();
            // return EmptyStringCheck(userInput);
            return userInput;
        }

        private void ReverseWord(char[] str)
        {
            // Initialize left and right pointers
            int r = str.Length - 1, l = 0;

            while (l < r)
            {
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;
                else
                {
                    char tmp = str[l];
                    str[l] = str[r];
                    str[r] = tmp;
                    l++;
                    r--;
                }
            }
        }


        //private string EmptyStringCheck(string s)
        //{
        //    do
        //    {
        //        //s = Console.ReadLine();
        //        if (string.IsNullOrEmpty(s))
        //        {
        //            Console.WriteLine("Empty input, please try again");
        //        }
        //    } while (string.IsNullOrEmpty(s));
        //    return s;
        //}
    }
}
