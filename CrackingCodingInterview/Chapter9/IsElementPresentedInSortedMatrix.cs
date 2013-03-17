using System;

namespace CrackingCodingInterview.Chapter9
{

    [Reference(
        Page = 66
        , Number = "9.6"
        , Description = "Given a matrix in which each row and each column is sorted write a method to find an element in it"
        )]
    public class IsElementPresentedInSortedMatrix : Algorithm<Tuple<int[,], int>, bool>
    {
        protected override bool OnExecute(Tuple<int[,], int> arg)
        {
            int[,] matrix = arg.Item1;
            int value = arg.Item2;

            int row = 0;
            int col = matrix.GetLength(1) - 1;

            while (row < matrix.GetLength(0) && col >= 0)
            {
                int item = matrix[row, col];

                if (item == value)
                {
                    return true;
                }
                
                if (item > value)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return false;
        }
    }
}
