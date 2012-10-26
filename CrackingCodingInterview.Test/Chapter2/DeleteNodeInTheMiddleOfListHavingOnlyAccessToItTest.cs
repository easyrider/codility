using System;
using System.Collections;
using CrackingCodingInterview.Chapter2;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter2
{
    [TestFixture]
    public class DeleteNodeInTheMiddleOfListHavingOnlyAccessToItTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public LinkedListNode<int> Test(LinkedListNode<int> node)
        {
            var cut = new DeleteNodeInTheMiddleOfListHavingOnlyAccessToIt();
            return RunTest(node, cut);
        }
        
        public static IEnumerable TestCases
        {
            get 
            { 

                yield return new TestCaseData(null).Throws(typeof(ArgumentNullException)).SetName("Null");
                yield return new TestCaseData(new LinkedListNode<int>{Data = 1, Next = null}).Throws(typeof(ArgumentException)).SetName("Next Null(Last One)");
                yield return new TestCaseData(new LinkedListNode<int> { Data = 2, Next = new LinkedListNode<int> { Data = 3, Next = null } }).Returns(new LinkedListNode<int> { Data = 3, Next = null }).SetName("one next");
                
            }
        }
    }


}