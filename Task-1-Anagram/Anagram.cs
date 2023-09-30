using System.Text;

namespace Task_1_Anagram
{
    public class Anagram
    {
        public void Reverse()
        {
            StringBuilder result = new StringBuilder();

            string userInput = ReadUserInput();
            string[] words = userInput.Split(' ');
            foreach (var word in words)
            {
                string reversed = ReverseWord(word);
                result.Append(reversed);
                result.Append(' ');
            }
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result.ToString());
        }

        private string ReadUserInput()
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

        public string ReverseWord(string str)
        {
            char[] toBeReversed = str.ToCharArray();
            int rightPointer = str.Length - 1, leftPointer = 0;
            while (leftPointer < rightPointer)
            {
                if (!char.IsLetter(toBeReversed[leftPointer]))
                {
                    leftPointer++;
                }
                else if (!char.IsLetter(toBeReversed[rightPointer]))
                {
                    rightPointer--;
                }
                else
                {
                    char tmp = toBeReversed[leftPointer];
                    toBeReversed[leftPointer] = toBeReversed[rightPointer];
                    toBeReversed[rightPointer] = tmp;
                    leftPointer++;
                    rightPointer--;
                }
            }
            string result = new string(toBeReversed);
            return result;
        }
    }
}
