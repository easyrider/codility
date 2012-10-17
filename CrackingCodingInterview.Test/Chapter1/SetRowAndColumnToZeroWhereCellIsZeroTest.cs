using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class SetRowAndColumnToZeroWhereCellIsZeroTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public int[,] Test(int[,] matrix)
        {
            var cut = new SetRowAndColumnToZeroWhereCellIsZero();
            return RunTest(matrix, cut);
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(null).Throws(typeof (ArgumentNullException)).SetName("Null");
                yield return new TestCaseData(new int[0,0]).Returns(new int[0,0]).SetName("Empty");

                var matrix = new int[2,2];
                matrix[0, 0] = 0;
                matrix[0, 1] = 1;
                matrix[1, 0] = 2;
                matrix[1, 1] = 2;

                var returns = new int[2,2];
                matrix[0, 0] = 0;
                matrix[0, 1] = 0;
                matrix[1, 0] = 0;
                matrix[1, 1] = 2;

                yield return new TestCaseData(matrix).Returns(returns).SetName("One zero");
            }
        }
    }


}