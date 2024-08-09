
namespace AnagramChecker.Tests
{
    internal class Tests
    {
        static internal IEnumerable<Tuple<string, string>> ValidAnagram()
        {

            Tuple<string, string>[] testData = { Tuple.Create("brag", "grab"), Tuple.Create("lamp", "palm"), Tuple.Create("note", "tone") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        #region ValidAnagrams

        static internal IEnumerable<Tuple<string, string>> ValidAnagramWithDifferentCase()
        {

            Tuple<string, string>[] testData = { Tuple.Create("braG", "grab"), Tuple.Create("lAmp", "paLm"), Tuple.Create("Note", "Tone") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> AnagramWithWhiteSpace()
        {
            Tuple<string, string>[] testData = { Tuple.Create("true lady","adultery"), Tuple.Create("forty five", "over fifty"), Tuple.Create("funeral", "real fun") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }
        static internal IEnumerable<Tuple<string, string>> NullAndWhiteSpace()
        {
            Tuple<string, string>[] testData = {  Tuple.Create(string.Empty,string.Empty), Tuple.Create("", " ") , Tuple.Create(" ", " ") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> AnagramWithNumericValues()
        {
            Tuple<string, string>[] testData = { Tuple.Create("b2ag", "g2ab"), Tuple.Create("1amp", "pa1m"), Tuple.Create("note3", "tone3") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }
        static internal IEnumerable<Tuple<string, string>> AnagramWithSpecialCharacter()
        {
            Tuple<string, string>[] testData = { Tuple.Create("br@g", "gr@b"), Tuple.Create("[amp", "pa[m"), Tuple.Create("note$", "$tone") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }
        #endregion

        #region InvalidAnagram
        static internal IEnumerable<Tuple<string, string>> InvalidAnagramSameWord()
        {
            Tuple<string, string>[] testData = { Tuple.Create("abc", "abc"), Tuple.Create("lamp", "lamp"), Tuple.Create("xyz", "xyz") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }        
        static internal IEnumerable<Tuple<string, string>> InvalidAnagramSameWordDifferentCase()
        {
            Tuple<string, string>[] testData = { Tuple.Create("ABC", "abc"), Tuple.Create("Lamp", "lamp"), Tuple.Create("xyZ", "xyz") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramSameLenght()
        {
            Tuple<string, string>[] testData = { Tuple.Create("abc", "abd"), Tuple.Create("lamp", "plams"), Tuple.Create("xyz", "abc") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramDifferentCharacterCount()
        {
            Tuple<string, string>[] testData = { Tuple.Create("cheeeater", "teacher"), Tuple.Create("Santas", "Satan"), Tuple.Create("coork", "rockk") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramDifferentLength()
        {
            Tuple<string, string>[] testData = { Tuple.Create("Satan", "adultery"), Tuple.Create("examples", "three"), Tuple.Create("rearranged", "Shakespeare") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramContainingWhiteSpace()
        {
            Tuple<string, string>[] testData = { Tuple.Create("blue red", "yellowed"), Tuple.Create("re write", "un write"), Tuple.Create("forty five", "over fives") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramWithSpecialCharacters()
        {
            Tuple<string, string>[] testData = { Tuple.Create("@bc", "@bd"), Tuple.Create("damp", "-p1ams"), Tuple.Create("xyz.", "abc") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }

        static internal IEnumerable<Tuple<string, string>> InvalidAnagramhWithNumericValues()
        {
            Tuple<string, string>[] testData = { Tuple.Create("123", "456"), Tuple.Create("67899", "99676"), Tuple.Create("1111", "0000") };

            foreach (var test in testData)
            {
                yield return test;
            }
        }
        #endregion
    }
}
