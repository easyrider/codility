using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter8
{

    [Reference(
        Page = 64
        , Number = "8.3"
        , Description = "Write a method that returns all subsets of a set."
        , Variant = 2)]
    public class ReturnAllSubsetsOfSetIterative : Algorithm<int[], List<List<int>>>
    {
        protected override List<List<int>> OnExecute(int[] arg)
        {
            List<List<int>> allSubsets = new List<List<int>>();

            int max = 1 << arg.Length;

            for (int i = 0; i < max; i++)
            {
                List<int> subset = new List<int>();
                int k = i;
                int index = 0;

                while (k > 0)
                {
                    if ((k & 1) > 0)
                    {
                        subset.Add(arg[index]);
                    }

                    k >>= 1;
                    index++;
                }

                allSubsets.Add(subset);
            }

            return allSubsets;
        }
    }
}