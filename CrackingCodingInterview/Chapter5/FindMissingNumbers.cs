using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter5
{
    [Reference(
        Page = 58
        , Number = "5.7"
        , Description = "An array [1...n] contains all the integers from 0 to n except for one number which is" +
                        "missing. In this problem, we cannot access an entire integer in A with a single operation." +
                        "The elements of A are represented in binary, and the only operation we can use to access" +
                        "them is 'fetch the jth bit of A[i]', which takes constant time. Write code to find the missing integer." +
                        "Can you do it in O(n) time?")]
    public class FindMissingNumbers : Algorithm<int[], int>
    {
        protected override int OnExecute(int[] arg)
        {
            return FindMissing(arg, sizeof (int) * 8 - 1);
        }

        private static int FindMissing(IEnumerable<int> ints, int position)
        {
            if (position < 0)
            {
                return 0;
            }

            List<int> odds = new List<int>();
            List<int> evens = new List<int>();

            uint mask = (0x80000000 >> position);
            
            foreach (int i in ints)
            {   
                if ((i & mask) == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            if (odds.Count >= evens.Count)
            {
                return FindMissing(evens, position - 1) << 1 | 0;
            }
            
            return FindMissing(odds, position - 1) << 1 | 1;
        }
    }
}
