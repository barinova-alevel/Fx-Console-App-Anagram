using System.Text;
using Task_1_Anagram;

Anagram anagram = new Anagram();
string userInput = anagram.ReadUserInput();
anagram.Reverse(userInput);
Console.ReadKey();
