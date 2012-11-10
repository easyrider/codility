using CrackingCodingInterview.Chapter3;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter3
{
    [TestFixture]
    public class QueueBasedOnTwoStacksTest
    {
        [Test]
        public void One_Element()
        {
            var queue = new QueueBasedOnTwoStacks<int>();
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Dequeue());
        }

        [Test]
        public void Two_Elements()
        {
            var queue = new QueueBasedOnTwoStacks<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);        
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());            
        }

        [Test]
        public void Three_Elements()
        {
            var queue = new QueueBasedOnTwoStacks<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
        }
    }
}
