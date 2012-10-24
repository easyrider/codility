using System;

namespace CrackingCodingInterview.Chapter2
{

    [Reference(
        Page = 50
        , Number = "2.1"
        , Description = "Write code to remove duplicates from an unsorted linked list",
        Variant = 2)]
    public class RemoveDuplicatesFromUnsortedLinkedListWithoutDataStructure : RemoveDuplicatesFromUnsortedLinkedListBase
    {
        protected override LinkedListNode<int> OnExecute(LinkedListNode<int> arg)
        {
            if (arg == null) 
                throw new ArgumentNullException("arg");

            var head = arg;

            LinkedListNode<int> previous = head;
            LinkedListNode<int> current = previous.Next;

            while(current != null)
            {
                IncrementIteration();
                LinkedListNode<int> runner = head;

                while (runner != current)
                {
                    IncrementIteration();

                    if (runner.Data == current.Data)
                    {
                        LinkedListNode<int> tmp = current.Next;
                        previous.Next = tmp;
                        current = tmp;
                        break;
                    }

                    runner = runner.Next;
                }

                if (runner == current)
                {
                    previous = current;
                    current = current.Next;
                }
                
            }


            return head;
        }
    }
}
