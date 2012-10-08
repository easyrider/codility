using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.1"
        , Description = "Implement an algorithm to determine " +
                        "if a string has all unique characters. " +
                        "What if you can not use additional data structures?"
        , Variant = 3
        , Comments = "Complexity of this algorithm is O(n) + Hashset insert add complexity in the worst case. Memory is consumed on geometric progression")]
    public class HasStringUniqueCharactersWithHashSet : Algorithm<string, bool>
    {
        protected override bool OnExecute(string @string)
        {
            if (@string == null) throw new ArgumentNullException("string");

            if (@string == string.Empty) return true;

            var length = @string.Length;

            var flagSet = new  HashSet<char>();

            var result = true;

            For(0, length, ctx =>
                                {
                                    var @char = @string[ctx.Seed];
                                    if (flagSet.Add(@char)) return;
                                    result = false;
                                    ctx.Break = true;
                                });

            return result;
        }
    }
}