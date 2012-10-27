using System;
using System.Collections;
using CrackingCodingInterview.Chapter2;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter2
{

    [TestFixture]
    public class SumTwoLinkedListTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public static int[] Test(int[] @array1, int[] @array2 )
        {
            var head1 = LinkedListHelper.ConvertToLinkedList(array1);
            var head2 = LinkedListHelper.ConvertToLinkedList(array2);
            var result = RunTest(Tuple.Create(head1, head2), new SumTwoLinkedList());
            return LinkedListHelper.ConvertToArray(result);
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1 }, new [] {5, 2}).Returns(new int[] { 6, 2 }).SetName("1 + 25 = 26");
                yield return new TestCaseData(new int[] { 2, 1}, new [] {5, 4, 3}).Returns(new int[] { 7, 5, 3 }).SetName("12 + 345 = 357");
                yield return new TestCaseData(new int[] { 9, 9, 1 }, new [] {1, 1, 1}).Returns(new int[] { 0, 1, 3 }).SetName("199 + 111 = 310");
            }
        }
    }
}
