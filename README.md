# AnagramChecker
C# Programmer Test

Use best practice to create a C# library that has a non-static class with a single non-static public
method with the following signature:
bool WordsAreAnagrams(string word1, string word2)
NOTE: A word anagram is a word formed by rearranging the letters of a different word.
The method should return true if the words are anagrams of each other.
The method should return false if the words are not anagrams of each other.
The method should return false if the words are identical.
All checks should be case insensitive.
An exception should be thrown if either argument is null or empty.
An exception should be thrown if either argument contains a non-alpha character (i.e. only A to Z are
valid, whitespace is invalid).
Examples:
- “evil” is an anagram of “vile”.
- “cheater” is an anagram of “teacher”.
- “cheater” is an anagram of “TEACHER”.
- “vale” is not an anagram of “vile”.
- “evil” is not an anagram of “evil”.
- “real fun” is not considered an anagram of “funeral” for this implementation and would
throw an exception as one argument contains a space.
- “forty five” is not considered an anagram of “over fifty” for this implementation and would
throw an exception as both arguments contain spaces.
- null as either argument throws an exception.
- “” as either argument throws an exception.
- “dollar$” as either argument throws an exception.
- “number1fan” as either argument throws an exception.
- “contains a space” as either argument throws an exception.
Be prepared to discuss your implementation and choices you made.
Send us your zipped up solution (exclude binary files, bin and obj folders).
NOTE: We are looking for code you would be happy to submit for a code review as part of a git pull
request at work. Whether your code is the most efficient implementation is not important, we use
the test to understand the approaches you use when coding and follow what we would consider
best practice.
