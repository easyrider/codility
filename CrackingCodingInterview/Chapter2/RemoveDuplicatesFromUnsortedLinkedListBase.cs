using System;

namespace CrackingCodingInterview.Chapter2
{
    public abstract class RemoveDuplicatesFromUnsortedLinkedListBase : Algorithm<LinkedListNode<int>, LinkedListNode<int>>
    {
        protected override int OnInitComplexity(LinkedListNode<int> arg)
        {
            if (arg == null)
                throw new ArgumentNullException();

            var size = 0;

            do size++; while ((arg = arg.Next) != null);

            return size;
        }
    }
}