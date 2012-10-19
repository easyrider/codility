using System;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.8"
        , Description = "Assume you have a method isSubstring which checks " +
                        "if one word is a substring of another. " +
                        "Given two strings, s1 and s2, " +
                        "write code to check if s2 is a rotation of s1 " +
                        "using only one call to isSubstring")]
    public class CheckWhetherStringsAreRotations : Algorithm<Tuple<string, string>, bool>
    {
        protected override int OnInitComplexity(Tuple<string, string> arg)
        {
            return arg.Item1.Length;
        }

        protected override bool OnExecute(Tuple<string, string> arg)
        {
            if (arg == null) 
                throw new ArgumentNullException("arg");
            
            var s1 = arg.Item1;
            var s2 = arg.Item2;

            if (s1 == null)
                throw new ArgumentException();

            if (s2 == null)
                throw new ArgumentException();


            if (s1.Length != s2.Length)
                return false;

            return (String.Concat(s1, s1).IndexOf(s2, StringComparison.Ordinal) != -1);

        }
    }
}
