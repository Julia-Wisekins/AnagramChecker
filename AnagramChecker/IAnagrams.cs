namespace AnagramChecker
{
    /// <summary>
    /// Checks anagrams 
    /// </summary>
    public interface IAnagrams
    {
        /// <summary>
        /// checks if two words are anagrams of each other.
        /// </summary>
        /// <param name="word1">word to be compared</param>
        /// <param name="word2">word to be compared</param>
        /// <returns>true if words are anagrams of each other</returns>
        /// <exception cref="InvalidDataException">thrown if the arguments contain numeric characters, special characters or whitespace.</exception>
        public bool WordsAreAnagrams(string word1, string word2);
    }
}
