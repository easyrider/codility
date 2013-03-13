using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingCodingInterview.Chapter9
{
    [Reference(
        Page = 66
        , Number = "9.3"
        , Description = "Given a sorted array of n integers that has been rotated an unknown number of times, give an O(log n) " +
                        "algorithm that finds an element in the array. You may assume that the array was originally sorted in increasing order."
        )]
    public class FindIndexOfElementInSortedRotatedArray : Algorithm<Tuple<int[], int>, int>
    {
        protected override int OnExecute(Tuple<int[], int> arg)
        {
            int[] array = arg.Item1;
            return Search(arg.Item2, array, 0, array.Length - 1);
        }

        static int Search(int value, int[] inArray, int from, int to)
        {
            while (from <= to)
            {
                int mean = (from + to) / 2;

                if (value == inArray[mean])
                {
                    return mean;
                }
                else if(inArray[from] <= inArray[mean])
                {
                    if (value > inArray[mean])
                    {
                        from = mean + 1;
                    }
                    else if (value >= inArray[from])
                    {
                        to = mean - 1;
                    }
                    else
                    {
                        from = mean + 1;
                    }
                }
                else if (value < inArray[mean])
                {
                    to = mean - 1;
                }
                else if (value <= inArray[to])
                {
                    from = mean + 1;
                }
                else
                {
                    to = mean - 1;
                }
            }

            return -1;
        }
    }
}
