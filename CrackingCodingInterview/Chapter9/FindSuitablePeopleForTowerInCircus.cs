using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace CrackingCodingInterview.Chapter9
{
    [Reference(
        Page = 66
        , Number = "9.7"
        , Description = "A circus is designing a tower routine consisting of people standing atop one another’s shoulders. " +
                        "For practical and aesthetic reasons, each person must be both shorter and lighter than the person below him or her. " + 
                        "Given the heights and weights of each person in the circus, write a method to compute the largest possible number of people " +
                        "in such a tower."
        )]
    public class FindSuitablePeopleForTowerInCircus : Algorithm<Tuple<int, int>[], Tuple<int, int>[]>
    {
        protected override Tuple<int, int>[] OnExecute(Tuple<int, int>[] arg)
        {
            Array.Sort(arg, _comparer);
            int currentUnfit = 0;
            IEnumerable<Tuple<int, int>> maxSeq = Enumerable.Empty<Tuple<int, int>>();

            while (currentUnfit < arg.Length)
            {
                var sequence = new List<Tuple<int, int>>();
                int nextUnfit = FillSequence(currentUnfit, sequence, arg);
                maxSeq = GetSequenceWithMaxLength(sequence, maxSeq);
                
                if (nextUnfit == currentUnfit)
                {
                    break;
                }
                else
                {
                    currentUnfit = nextUnfit;
                }
            }
            return maxSeq.ToArray();
        }

        private int FillSequence(int currentUnfit, List<Tuple<int, int>> sequence, Tuple<int, int>[] items)
        {
            int firstUnfitItem = currentUnfit;

            if (currentUnfit < items.Length)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    Tuple<int, int> item = items[i];

                    if (i == 0 || (_comparer.Compare(items[i-1], item) < 0))
                    {
                        sequence.Add(item);
                    } 
                    else
                    {
                        firstUnfitItem = i;
                    }
                }
            }

            return firstUnfitItem;
        }

        private IEnumerable<Tuple<int, int>> GetSequenceWithMaxLength(IEnumerable<Tuple<int, int>> seq1, IEnumerable<Tuple<int, int>> seq2)
        {
            return seq1.Count() > seq2.Count() ? seq1 : seq2;
        }

        private static readonly SortByThen _comparer = new SortByThen();

        class SortByThen : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int> x, Tuple<int, int> y)
            {
                int diff = x.Item1.CompareTo(y.Item1);

                if (diff == 0)
                {
                    diff = x.Item2.CompareTo(y.Item2);
                }

                return diff;
            }
        }
    }
}
