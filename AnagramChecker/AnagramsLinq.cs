using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnagramChecker
{
    public class AnagramsLinq : IAnagrams
    {
        /// <summary>
        /// checks if two words are anagrams of each other. using Linq
        /// </summary>
        /// <param name="word1">word to be compared</param>
        /// <param name="word2">word to be compared</param>
        /// <returns>true if words are anagrams of each other</returns>
        /// <exception cref="InvalidDataException">thrown if the arguments contain numeric characters, special characters or whitespace.</exception>
        public bool WordsAreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrWhiteSpace(word2) || string.IsNullOrWhiteSpace(word2))
                throw new ArgumentNullException("Invalid argument: does not accept null or whitespace.");

            if (!(word1.All(char.IsLetter) && word2.All(char.IsLetter))
                || (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)))
                throw new ArgumentException("Invalid data, does not allow numeric characters, special characters.");

            if (word1.Length != word2.Length)
                return false;

            if (string.Compare(word1, word2, StringComparison.CurrentCultureIgnoreCase) == 0)
                return false;

            var word1Chars = word1.ToLower().ToCharArray();
            var word2Chars = word2.ToLower().ToCharArray();

            Array.Sort(word1Chars);
            Array.Sort(word2Chars);

            return Enumerable.SequenceEqual(word1Chars, word2Chars);
        }

    }
}
