using System;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.4"
        , Description = "Write a method to decide whether strings are anagrams or not"
        , Variant = 1
        )]
    
    public class AreStringsAnagrams : Algorithm<Tuple<string, string>, bool>
    {
        protected override int OnInitComplexity(Tuple<string, string> arg)
        {
            if (arg == null)
                throw new ArgumentNullException();
            if (arg.Item1 == null || arg.Item2 == null)
                throw new ArgumentException();

            return Math.Max(arg.Item1.Length, arg.Item2.Length);
        }

        protected override bool OnExecute(Tuple<string, string> strings)
        {
            if (strings == null) throw new ArgumentNullException("strings");

            var a = strings.Item1;
            var b = strings.Item2;

            if ((a == null) || (b == null))
                throw new ArgumentException("One of the tuple items is null");

            var aLen = a.Length;
            var bLen = b.Length;

            if (aLen != bLen) return false;

            var chars = new int[char.MaxValue + 1];
            var countOfUniqueChars = 0;
            var countOfFoundChars = 0;

            for (var i = 0; i < aLen; i++)
            {
                IncrementIteration();
                var c = a[i];
                if (chars[c] == 0)
                    countOfUniqueChars++;
                chars[c]++;
            }

            for (var i = 0; i < bLen; i++)
            {
                IncrementIteration();
                var c = b[i];
                if (chars[c] == 0) return false;
                chars[c]--;
                if (chars[c] == 0)
                {
                    countOfFoundChars++;
                    if (countOfUniqueChars == countOfFoundChars)
                    {
                        return (i == (bLen - 1));
                    }
                }
            }

            return false;
        }
    }
}