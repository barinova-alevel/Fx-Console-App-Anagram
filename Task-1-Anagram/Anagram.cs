using System.Text;

namespace Task_1_Anagram
{
    public class Anagram
    {
     
        public string Reverse(string userInput)
        {
            List<string> result = new List<string>();

            string[] words = userInput.Split(' ');
            foreach (var word in words)
            {
                string reversed = ReverseWord(word);
                result.Add(reversed);
            }

            string stringResult = string.Join(" ", result);
            return stringResult;
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
