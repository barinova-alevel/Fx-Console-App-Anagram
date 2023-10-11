namespace Task_1_Anagram
{
    internal class InputOutput
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

        public void OutputResult(string result)
        {
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
