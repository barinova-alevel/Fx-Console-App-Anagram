# Task-1-Anagram
Create a console application for reverse each word* in the input line

Example: "abcd efgh" => "dcba hgfe"; "Test" => "tseT"



All non-alphabetic symbols should stay in their original places.

Examples:

"a1bcd efg!h" => "d1cba hgf!e"

" a1bcd efg!h" => " d1cba hgf!e" **



* Space is the divider for words in a line.

** Spaces (as one of non alphabetic symbols) should not be deleted from the result string.



Create a test project for checking the algorithm of the reverse.


What to do if you stuck (instructions for newbies):

Implement the method ReverseWord, which will reverse a single word. Do not use built-in functions/methods, like Array.Reverse or similar.
Implement one more method Reverse, which will reverse all words in the input string. This method should use the previous method.
Create a new class Anagram and move there all created methods, change main to follow new class implementation.
Check program works correctly as before moving.
Add a new project for Unit tests. Cover Anagram with tests. Tests should include alternatives for non-valid values (null etc).
Rewrite method ReverseWord to keep all non-alphabetic characters in their original position.
Add new unit tests to check words with non-alphabetic characters

Useful links:

String Class (System) | Microsoft Docs

Char Struct (System) | Microsoft Docs

StringBuilder Class (System.Text) | Microsoft Docs

C# unit test tutorial - Visual Studio (Windows) | Microsoft Docs
