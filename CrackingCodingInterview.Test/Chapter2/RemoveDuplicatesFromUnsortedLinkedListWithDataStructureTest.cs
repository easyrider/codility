using System.Collections;
using System.Collections.Generic;
using CrackingCodingInterview.Chapter2;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter2
{
    [TestFixture]
    public class RemoveDuplicatesFromUnsortedLinkedListTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public int[] With_Data_Structure(int[] @array)
        {
            var cut = new RemoveDuplicatesFromUnsortedLinkedListWithDataStructure();
            return Test(cut, @array);
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int[] Without_Data_Structure(int[] @array)
        {
            var cut = new RemoveDuplicatesFromUnsortedLinkedListWithoutDataStructure();
            return Test(cut, @array);
        }

        private static int[] Test(Algorithm<LinkedListNode<int>, LinkedListNode<int>> cut,IList<int> @array)
        {
            LinkedListNode<int> previous = null;
            LinkedListNode<int> head = null;
            for (var index = 0; index < @array.Count; index++)
            {
                var t = @array[index];
                var tmp = new LinkedListNode<int> { Data = t };
                if (previous != null)
                {
                    previous.Next = tmp;
                }
                else
                {
                    head = tmp;
                }

                previous = tmp;
            }

            var result = RunTest(head, cut);

            var list = new List<int>();
            if (result != null)
                do
                    list.Add(result.Data);
                while ((result = result.Next) != null);

            return list.ToArray();
        }

        public static IEnumerable TestCases
        {
            get 
            { 
                yield return new TestCaseData(new int[] {2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1}).Returns(new int[]{2,1}).SetName("Two doubles");
                yield return new TestCaseData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}).Returns(new int[] { 1}).SetName("One double");
                yield return new TestCaseData(new int[] { 3, 2, 1, 4, 5, 6, 7, 8, 9, 0 }).Returns(new int[] { 3, 2, 1, 4, 5, 6, 7, 8, 9, 0 }).SetName("No double");
            }
        }
    }


}