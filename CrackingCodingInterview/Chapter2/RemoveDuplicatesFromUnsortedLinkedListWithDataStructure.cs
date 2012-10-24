using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter2
{
    [Reference(
        Page = 50
        , Number = "2.1"
        , Description = "Write code to remove duplicates from an unsorted linked list",
        Variant = 1)]
    public class RemoveDuplicatesFromUnsortedLinkedListWithDataStructure : RemoveDuplicatesFromUnsortedLinkedListBase
    {
        protected override LinkedListNode<int> OnExecute(LinkedListNode<int> arg)
        {
            if (arg == null)
                throw new ArgumentNullException("arg");
            LinkedListNode<int> head = arg;
            var set = new HashSet<int>();
            LinkedListNode<int> previous = arg;

            while (arg != null)
            {
                IncrementIteration();

                if (set.Add(arg.Data))
                {
                    previous = arg;
                }
                else
                {
                    previous.Next = arg.Next;
                }

                arg = arg.Next;
            }

            return head;
        }
    }
}