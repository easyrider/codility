using System;

namespace CrackingCodingInterview.Chapter2
{

    [Reference(
        Page = 50
        , Number = "2.5"
        , Description = "Given a circular linked list, implement an algorithm" +
                        "which returns node at the beginning of the loop")]
    public class FindLoopInLinkedList : Algorithm<LinkedListNode<int>, LinkedListNode<int>>
    {
        protected override int OnInitComplexity(LinkedListNode<int> arg)
        { 
            if (arg == null) throw new ArgumentNullException("arg");
            return -1;
        }

        protected override LinkedListNode<int> OnExecute(LinkedListNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            LinkedListNode<int> slow = arg;
            LinkedListNode<int> fast = arg;

            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (Equals(slow, fast))
                    break;
            }
            
            if (fast.Next == null)
            {
                return null;
            }

            fast = arg;

            while(!Equals(fast, slow))
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return fast;
        }
    }
}
