using System;

namespace CrackingCodingInterview.Chapter2
{
    [Reference(
        Page = 50
        , Number = "2.4"
        , Description = "You have two numbers represented by a linked list, where each node contains a single digit." +
                        "The digits are stored in reverse order, such that the 1's digit is at the head of the list." +
                        "Write a function that adds the two numbers and returns the sum as a linked list.")]
    public class SumTwoLinkedList : Algorithm<Tuple<LinkedListNode<int>, LinkedListNode<int>>, LinkedListNode<int>>
    {
        protected override int? OnInitComplexity(Tuple<LinkedListNode<int>, LinkedListNode<int>> arg)
        {
            if (arg == null) 
                throw new ArgumentNullException("arg");

            var item1 = arg.Item1;
            if (item1 == null) 
                throw new ArgumentException("arg.Item1");

            var item2 = arg.Item2;
            if (item2 == null) 
                throw new ArgumentException("arg.Item2");
            
            var max = Math.Max(item1.GetLength(), item2.GetLength());
            return max;
        }

        protected override LinkedListNode<int> OnExecute(Tuple<LinkedListNode<int>, LinkedListNode<int>> arg)
        {
            return Sum(arg.Item1, arg.Item2, 0);
        }

        private LinkedListNode<int> Sum(LinkedListNode<int> a, LinkedListNode<int> b, int carry)
        {
            if ((a == null) && (b == null))
                return null;

            if ((a != null) && (a.Data > 9 || a.Data < 1))
                throw new ArgumentException("a.Data");

            if ((b != null) && (b.Data > 9 || b.Data < 1))
                throw new ArgumentException("b.Data");

            IncrementIteration();

            var result = new LinkedListNode<int>();

            int value = carry;

            if (a != null)
                value += a.Data;

            if (b != null)
                value += b.Data;

            result.Data = value%10;
            
            var next = Sum(a == null ? null : a.Next, b == null ? null : b.Next, value > 9 ? 1 : 0);
            result.Next = next;
            return result;
        }
    }
}
