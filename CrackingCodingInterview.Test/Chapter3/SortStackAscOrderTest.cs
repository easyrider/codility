using System.Collections;
using System.Collections.Generic;
using CrackingCodingInterview.Chapter3;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter3
{
    [TestFixture]
    public class SortStackAscOrderTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public Stack<int> Test(Stack<int> unsorted)
        {
            return RunTest(unsorted, new SortStackAscOrder());
        }

        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(new Stack<int>(new[] { 2 })).Returns(new Stack<int>(new[] { 2 })).SetName("Some cases");
                yield return new TestCaseData(new Stack<int>(new[] { 1, 2, 3 })).Returns(new Stack<int>(new[] { 1, 2, 3 })).SetName("Some cases");
                yield return new TestCaseData(new Stack<int>(new[] { 3, 2, 1 })).Returns(new Stack<int>(new[] { 1, 2, 3 })).SetName("Some cases");
                yield return new TestCaseData(new Stack<int>(new[] { 3, 1, 2 })).Returns(new Stack<int>(new[] { 1, 2, 3 })).SetName("Some cases");
                yield return new TestCaseData(new Stack<int>()).Returns(new Stack<int>()).SetName("Some cases");                                                
            }
        }
    }
}
