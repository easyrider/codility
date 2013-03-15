using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingCodingInterview.Chapter9
{
     [Reference(
        Page = 66
        , Number = "9.5"
        , Description = "Given a sorted array of strings which is interspersed with empty strings, " +
                        "write a method to find the location of a given string."
        )]
    public class FindStringInSortedInterspersedWithEmptyStringArray : Algorithm<Tuple<String[], string>, int>
    {
        protected override int OnExecute(Tuple<string[], string> arg)
        {
            String[] array = arg.Item1;
            string value = arg.Item2;

            if ((array == null) || (value == null))
            {
                return -1;
            }

            if (value == string.Empty)
            {
                return SearchLinear(array, value);
            }

            return SearchBinary(array, value);
        }

        private int SearchBinary(string[] array, string value)
        {
            int first = 0, last = array.Length - 1;

            while(first <= last)
            {
                while (first <= last && array[last] == string.Empty)
                {
                    last--;
                }

                if (last < first)
                {
                    return -1;
                }

                int mid = (last + first) >> 1;

                while (array[mid] == string.Empty)
                {
                    mid++;
                }

                int diff = array[mid].CompareTo(value);

                if (diff == 0)
                {
                    return mid;
                }
                else if (diff < 0)
                {
                    first = mid + 1;
                }
                else if (diff > 0)
                {
                    last = mid - 1;
                }
            }

            return -1;
        }

        private int SearchLinear(string[] array, string value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
