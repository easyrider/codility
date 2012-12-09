using System;

namespace CrackingCodingInterview.Chapter5
{
     [Reference(
        Page = 58
        , Number = "5.1"
        , Description = "You are given two 32-bit numbers, N and M, and two bit positions, i and j. Write a " +
                        "method to set all bits between i and j in N equal to M(e.g., M becomes a substring of" +
                        "N located at i and starting at j.")]
    public class SetBits : Algorithm<Tuple<int, int, int, int>, int>
    {
        protected override int OnExecute(Tuple<int, int, int, int> arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            int n = arg.Item1;
            int m = arg.Item2;
            int i = arg.Item3;
            int j = arg.Item4;

            const int allOnes = ~0;
            int left = allOnes -((1 << j) - 1);
            int right = ((1 << i) - 1);
            int mask = left | right;
            return (n & mask) | (m << i);
        }
    }
}
