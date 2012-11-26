using System;

namespace CrackingCodingInterview.Chapter2
{
     [Reference(
        Page = 50
        , Number = "2.3"
        , Description = "Implement an algorithm to delete " +
                        "a node in the middle of a single linked " +
                        "list, given only access to that node")]
    public class DeleteNodeInTheMiddleOfListHavingOnlyAccessToIt : Algorithm<LinkedListNode<int>, LinkedListNode<int>>
    {
        protected override int? OnInitComplexity(LinkedListNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            return arg.GetLength();
        }

        protected override LinkedListNode<int> OnExecute(LinkedListNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            var linkedListNode = arg.Next;
            if (linkedListNode == null) throw new ArgumentException("Node should have a next element", "arg");
            arg.Data = linkedListNode.Data;
            arg.Next = linkedListNode.Next;
            return arg;
        }
    }
}
