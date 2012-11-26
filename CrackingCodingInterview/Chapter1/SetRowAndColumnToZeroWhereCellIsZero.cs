using System;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.7"
        , Description = "Write an algorithm such that " +
                        "if an element in an MxN matrix is 0" +
                        ", its entire row and column is set to 0"
        )]
    public class SetRowAndColumnToZeroWhereCellIsZero : Algorithm<int[,], int[,]>
    {
        protected override int? OnInitComplexity(int[,] arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            return arg.Length;
        }

        protected override int[,] OnExecute(int[,] arg)
        {
            if (arg == null)
                throw new ArgumentNullException("arg");

            var rowsCount = arg.GetLength(0);
            var columnsCount = arg.GetLength(1);

            var zeroRows = new bool[rowsCount];
            var zeroColumns = new bool[columnsCount];

            for (var i = 0; i < rowsCount; i++)
            {
                IncrementIteration();
                for (var j = 0; j < columnsCount; j++)
                {
                    IncrementIteration();
                    if (arg[i, j] != 0) continue;
                    zeroRows[i] = true;
                    zeroColumns[j] = true;
                }
            }

            for (var i = 0; i < rowsCount; i++)
            {
                IncrementIteration();
                for (var j = 0; j < columnsCount; j++)
                {
                    IncrementIteration();
                    if (zeroRows[i] || zeroColumns[j])
                    {
                        arg[i, j] = 0;
                    }
                }
            }

            return arg;
        }
    }
}
