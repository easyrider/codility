using System;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.1"
        , Description = "Implement an algorithm to determine " +
                      "if a string has all unique characters. " +
                      "What if you can not use additional data structures?"
        , Variant = 2
        , Comments = "TimeComplexity of this algorithm is O(n) in the worst case. But its memory is additional O(2^16 - 1)")]
    public class HasStringUniqueCharactersWithArray : Algorithm<string, bool>
    {
        protected override bool OnExecute(string @string)
        {
            if (@string == null) throw new ArgumentNullException("string");

            if (@string == string.Empty) return true;

            var length = @string.Length;

            var flagSet = new bool[(int)Math.Pow(2, sizeof (char) * 8) - 1];

            var result = true;

            For(0, length, ctx =>
                                {

                                    var @char = @string[ctx.Seed];
                                    var flag = flagSet[@char];

                                    if (flag)
                                    {
                                        result = false;
                                        ctx.Break = true;
                                        return;
                                    }

                                    flagSet[@char] = true;
                                });

            return result;
        }
    }
}