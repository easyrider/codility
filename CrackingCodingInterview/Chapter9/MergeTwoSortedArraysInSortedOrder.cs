using System;

namespace CrackingCodingInterview.Chapter9
{
    [Reference(
        Page = 66
        , Number = "9.1"
        , Description = "You are given two sorted arrats, write a method to merge one array into another in sorted manner"
        )]
    public class MergeTwoSortedArraysInSortedOrder : Algorithm<Tuple<int[], int[]>, int[]>
    {
        protected override int[] OnExecute(Tuple<int[], int[]> arg)
        {
            int[] arrayA = arg.Item1;
            int[] arrayB = arg.Item2;
            int[] arrayResult = new int[arrayA.Length + arrayB.Length];

            int arrayResultPointer = arrayResult.Length - 1;
            int arrayAPointer = arrayA.Length - 1;
            int arrayBPointer = arrayB.Length - 1;

            while (arrayAPointer >= 0 && arrayBPointer >= 0)
            {
                if (arrayA[arrayAPointer] > arrayB[arrayBPointer])
                {
                    arrayResult[arrayResultPointer--] = arrayA[arrayAPointer--];
                }
                else
                {
                    arrayResult[arrayResultPointer--] = arrayB[arrayBPointer--];
                }
            }

            while (arrayBPointer >= 0)
            {
                arrayResult[arrayResultPointer--] = arrayB[arrayBPointer--];
            }

            while (arrayAPointer >= 0)
            {
                arrayResult[arrayResultPointer--] = arrayA[arrayAPointer--];
            }

            return arrayResult;
        }
    }
}
