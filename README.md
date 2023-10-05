# StringManipulation
Repository to practice some string manipulation algorithms


#1 - InversionCapitalization
Exercise: 
String Inversion and Capitalization

Description:
Write a function that takes a string as an argument and returns that string inverted and with the first letter of each word capitalized.

For example:
     Input: "hello world"
     Output: "Dlrow Olleh"


#2 - PalindromesAnagrams
Exercise: 
Palindromes and Anagrams

Part 1 - Palindrome:
Write a function in C# that accepts a string as an argument and returns true if the string is a palindrome and false otherwise. A palindrome is a word, phrase, or any other sequence of characters that reads the same forward and backward (ignoring spaces, punctuation, and capitalization).

For example, "madam", "level", and "radar" are palindromes.

Part 2 - Anagram:
Write another function in C# that accepts two strings and returns true if one string is an anagram of the other and false if it is not. An anagram is a word or phrase formed by rearranging the letters of another word or phrase.

For example, "listen" and "silent" are anagrams.


#3 - RunLength
Exercise: Run-Length Coding
Run-Length encoding is a simple form of data compression that transforms strings of characters into a new, shorter string.

Task:
Write a function in C# that implements Run-Length encoding. The function must receive a string and return another compressed string.

Example:
For the string "aaaabbbccdaaa", the output will be "4a3b2c1d3a".

Rules:
     The algorithm must count the occurrences of each letter in sequence and write the count followed by the letter.
     If a character appears only once, the count "1" must be included.

Tips:
     Consider that the input string contains only alphabetic characters.
     The function must be case sensitive, i.e. "A" and "a" must be considered different characters.