using System.Text;

namespace Task_1_Anagram
{
    public class Anagram
    {
        public string Reverse(string userInput)
        {
            StringBuilder result = new StringBuilder();

            string[] words = userInput.Split(' ');
            foreach (var word in words)
            {
                string reversed = ReverseWord(word);
                result.Append(reversed);
                result.Append(' ');
            }
            string stringWithRedundantSpace = result.ToString();
            string stringResult = stringWithRedundantSpace.Remove(stringWithRedundantSpace.Length - 1, 1);
            return stringResult;
        }

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

        private string ReverseWord(string str)
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
