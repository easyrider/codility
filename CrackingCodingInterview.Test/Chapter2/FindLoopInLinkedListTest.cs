using CrackingCodingInterview.Chapter2;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter2
{

    [TestFixture]
    public class FindLoopInLinkedListTest : TestBase
    {
        [Test]
        public void Test()
        {
            var a = new LinkedListNode<int> {Data = 1};
            var b = new LinkedListNode<int> {Data = 2};
            var c = new LinkedListNode<int> {Data = 3};
            var d = new LinkedListNode<int> {Data = 4};
            var e = new LinkedListNode<int> {Data = 5};
            var f = new LinkedListNode<int> {Data = 6};
            var g = new LinkedListNode<int> {Data = 7};
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = c;
            var linkedListNode = RunTest(a, new FindLoopInLinkedList());
            Assert.AreEqual(c, linkedListNode);
        }
    }
}
