using System;
using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class CreateTreeWithMinHeightFromAscOrderAlgorithmTest : TestBase
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData((int[]) null).Throws(typeof (ArgumentNullException)).SetName("Null Exception");

                yield return 
                    new TestCaseData(new []{ 2, 1 }).Throws(typeof(ArgumentException)).SetName("Unsorted");

                yield return
                    new TestCaseData(new int[] { }).Returns(null).SetName("Empty");


                yield return
                    new TestCaseData(new[] { 1, 2, 3, 4, 5 }).Returns(true).SetName("Odd amount of elements");

                yield return
                    new TestCaseData(new[] { 1, 2, 3, 4, 5, 6 }).Returns(true).SetName("Even amount of elements");

            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool? Is_Min_Height_Produced(int[] @array)
        {
            TreeNode<int> treeNode = RunTest(@array, new CreateTreeWithMinHeightFromAscOrderAlgorithm());

            if (treeNode == null)
                return null;

            var isTreeBalanced = new IsTreeBalanced();
            return isTreeBalanced.Execute(treeNode);
        }
    }
}