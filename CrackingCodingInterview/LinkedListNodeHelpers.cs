using System;

namespace CrackingCodingInterview
{
    public static class LinkedListNodeHelpers
    {
        public static int GetLength<T>(this LinkedListNode<T> arg)
        {
            if (arg == null)
                throw new ArgumentNullException();

            var size = 0;

            do size++; while ((arg = arg.Next) != null);

            return size;
        }
    }
}