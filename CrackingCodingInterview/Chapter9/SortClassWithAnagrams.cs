using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter9
{

    [Reference(
        Page = 66
        , Number = "9.2"
        , Description = "Write an algorithm to sort an array of strings so that all anagrams are next to each other."
        )]
    public class SortClassWithAnagrams : Algorithm<string[], string[]>
    {
        protected override string[] OnExecute(string[] arg)
        {
            Array.Sort(arg, new AnagramComparer());
            return arg;
        }

        class AnagramComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return String.Compare(SortString(x), SortString(y), StringComparison.Ordinal);
            }

            private static string SortString(string str)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                return new string(charArray);
            }
        }
    }
}
