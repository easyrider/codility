using System;
using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class MergeTwoSortedArraysInSortedOrderTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData(new int[] {4, 5, 6}, new int[] {1, 2, 3}).Returns(new int[] {1, 2, 3, 4, 5, 6});
                yield return
                    new TestCaseData(new int[] { 1, 3, 6 }, new int[] { 2, 4, 5, 7 }).Returns(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public int[] Test(int[] arrayA, int[] arrayB)
        {
            int[] result = RunTest(Tuple.Create(arrayA, arrayB), new MergeTwoSortedArraysInSortedOrder());
            return result;
        }
    }
}
