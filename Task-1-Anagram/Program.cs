using Task_1_Anagram;

Anagram anagram = new Anagram();
UserInput userInputInstance = new UserInput();

string userInput = userInputInstance.ReadUserInput();
string result = anagram.Reverse(userInput);
Console.WriteLine();
Console.WriteLine("Result:");
Console.WriteLine(result);
Console.ReadKey();
