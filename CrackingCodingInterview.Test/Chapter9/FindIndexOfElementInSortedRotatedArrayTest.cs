using System;
using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class FindIndexOfElementInSortedRotatedArrayTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData(new int[] {15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14}, 5).Returns(8);
            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public int Test(int[] array, int value)
        {
            int result = RunTest(Tuple.Create(array, value), new FindIndexOfElementInSortedRotatedArray());
            return result;
        }
    }
}
