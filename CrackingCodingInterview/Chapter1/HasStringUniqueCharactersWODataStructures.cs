using System;

namespace CrackingCodingInterview.Chapter1
{
 
    [Reference(
        Page = 48
        , Number = "1.1"
        , Description = "Implement an algorithm to determine " +
                      "if a string has all unique characters. " +
                      "What if you can not use additional data structures?"
        , Variant = 1
        , Comments = "This algorithm does not use additional datastructures, " +
                     "its complexity maybe O(n^2) in the worst case though")]
    public class HasStringUniqueCharactersWoDataStructures : HasStringUniqueCharactersBase
    {
        protected override bool OnExecute(string @string)
        {
            if (@string == null) throw new ArgumentNullException("string");

            if (@string == string.Empty) return true;

            var length = @string.Length;

            var result = true;

            For(0, length - 1, ctx =>
                                    {
                                        var current = @string[ctx.Seed];

                                        For(ctx.Seed + 1, length, innerCtx =>
                                                                {
                                                                    if (current != @string[innerCtx.Seed]) return;
                                                                    ctx.Break = innerCtx.Break = true;                                                                   
                                                                    result = false;
                                                                });
                                    });

            return result;
        }
    }
}
