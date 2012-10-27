using System.Collections.Generic;

namespace CrackingCodingInterview.Test.Chapter2
{
    static internal class LinkedListHelper
    {
        public static LinkedListNode<int> ConvertToLinkedList(IEnumerable<int> array1)
        {
            LinkedListNode<int> previous = null;
            LinkedListNode<int> head = null;
            foreach (var t in array1)
            {
                var tmp = new LinkedListNode<int> {Data = t};
                if (previous != null)
                {
                    previous.Next = tmp;
                }
                else
                {
                    head = tmp;
                }

                previous = tmp;
            }
            return head;
        }

        public static int[] ConvertToArray(LinkedListNode<int> result)
        {
            var list = new List<int>();
            if (result != null)
                do
                    list.Add(result.Data); while ((result = result.Next) != null);

            return list.ToArray();
        }
    }
}