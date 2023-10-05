using Task_1_Anagram;

Anagram anagram = new Anagram();
string userInput = anagram.ReadUserInput();
string result = anagram.Reverse(userInput);
Console.WriteLine();
Console.WriteLine("Result:");
Console.WriteLine(result);
Console.ReadKey();
