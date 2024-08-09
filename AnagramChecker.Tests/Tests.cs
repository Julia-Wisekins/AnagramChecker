namespace AnagramChecker.Tests
{
    [TestFixture(typeof(AnagramsLinq))]
    [TestFixture(typeof(AnagramsRegex))]
    public class AnagramTests<T> where T : IAnagrams, new()
    {
        private T _anagram;

        [SetUp]
        public void Setup()
        {
            _anagram = new T();

        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.ValidAnagram))]
        public void Valid_Anagram_Returns_True(Tuple<string, string> words)
        {
            Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.True);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.ValidAnagramWithDifferentCase))]
        public void Valid_Anagram_Different_Cases_Returns_True(Tuple<string, string> words)
        {
            Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.True);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.AnagramWithWhiteSpace))]
        public void Anagram_With_Contains_Whitespace_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.NullAndWhiteSpace))]
        public void Anagram_Null_Or_Whitespace_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentNullException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.AnagramWithNumericValues))]
        public void Anagram_With_Numeric_Values_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.AnagramWithSpecialCharacter))]
        public void Anagram_With_Special_Character_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramDifferentCharacterCount))]
        public void Invalid_Anagram_Different_Character_Count_Returns_False(Tuple<string, string> words)
        {
                Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramSameWord))]
        public void Invalid_Anagram_Same_Word_Returns_False(Tuple<string, string> words)
        {
                Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramSameWordDifferentCase))]
        public void Invalid_Anagram_Same_Word_Different_Case_Returns_False(Tuple<string, string> words)
        {
                Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramDifferentLength))]
        public void Invalid_Anagram_Different_Length_Returns_False(Tuple<string, string> words)
        {
                Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramSameLenght))]
        public void Invalid_Anagram_Same_Length_Returns_False(Tuple<string, string> words)
        {
                Assert.That(_anagram.WordsAreAnagrams(words.Item1, words.Item2), Is.False);
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramContainingWhiteSpace))]
        public void Invalid_Anagram_Containing_Whitespace_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramWithSpecialCharacters))]
        public void Invalid_Anagram_With_Special_Characters_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        [TestCaseSource(typeof(Tests), nameof(Tests.InvalidAnagramhWithNumericValues))]
        public void Invalid_Anagram_With_Numeric_Values_Throws(Tuple<string, string> words)
        {
                Assert.Throws<ArgumentException>(() => _anagram.WordsAreAnagrams(words.Item1, words.Item2));
        }

        [Test]
        public void Null_Values_Throws()
        {
                Assert.Throws<ArgumentNullException>(() => _anagram.WordsAreAnagrams(null, null));
        }
    }
}