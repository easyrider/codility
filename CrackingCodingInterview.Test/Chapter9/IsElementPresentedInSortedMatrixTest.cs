using System;
using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class IsElementPresentedInSortedMatrixTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                var matrix = new[,]
                    {
                        {1,2,3,4},
                        {2,3,4,5},
                        {3,4,5,6},
                        {4,5,6,7}
                    };

                yield return
                    new TestCaseData(matrix, 7).Returns(true);

                yield return
                    new TestCaseData(matrix, 1).Returns(true);


                yield return
                    new TestCaseData(matrix, 2).Returns(true);

                yield return
                    new TestCaseData(matrix, 0).Returns(false);


                yield return
                    new TestCaseData(matrix, 8).Returns(false);

            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public bool Test(int[,] matrix, int value)
        {
            return RunTest(Tuple.Create(matrix, value), new IsElementPresentedInSortedMatrix());
        }
    }
}
