using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter8
{
    [Reference(
        Page = 64
        , Number = "8.3"
        , Description = "Write a method that returns all subsets of a set."
        , Variant = 1)]
    public class ReturnAllSubsetsOfSetRecursive : Algorithm<int[], List<List<int>>>
    {
        protected override List<List<int>> OnExecute(int[] arg)
        {
            return GetSubsets(arg, 0);
        }

        private static List<List<int>> GetSubsets(int[] set, int index)
        {
            List<List<int>> allSubsets;

            if (set.Length == index)
            {
                allSubsets = new List<List<int>> {new List<int>()};
            }
            else
            {
                allSubsets = GetSubsets(set, index + 1);
                int item = set[index];
                List<List<int>> moreSubsets = new List<List<int>>();

                foreach (List<int> subset in allSubsets)
                {
                    List<int> newsubset = new List<int>();
                    newsubset.AddRange(subset);
                    newsubset.Add(item);
                    moreSubsets.Add(newsubset);
                }
                allSubsets.AddRange(moreSubsets);
            }

            return allSubsets;
        }
    }
}
