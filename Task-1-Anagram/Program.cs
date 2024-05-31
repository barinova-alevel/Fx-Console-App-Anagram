using Task_1_Anagram;

Anagram anagram = new Anagram();
InputOutput inputOutputInstance = new InputOutput();

string userInput = inputOutputInstance.ReadUserInput();
string result = anagram.Reverse(userInput);
inputOutputInstance.OutputResult(result);
