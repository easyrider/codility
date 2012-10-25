using System;

namespace CrackingCodingInterview.Chapter2
{
     [Reference(
        Page = 50
        , Number = "2.2"
        , Description = "Implement algorithm to find the nth to last element of a singly linked list")]
    public class FindNthToLast : Algorithm<Tuple<LinkedListNode<int>, int>, LinkedListNode<int>>
    {
        protected override int OnInitComplexity(Tuple<LinkedListNode<int>, int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            return arg.Item1.GetLength();
        }

        protected override LinkedListNode<int> OnExecute(Tuple<LinkedListNode<int>, int> args)
        {
            if (args == null) throw new ArgumentNullException("args");

            var p1 = args.Item1;
            var p2 = p1;

            for(var j = 0; j < args.Item2; j++)
            {
                IncrementIteration();
                if (p2 == null)
                    throw new ArgumentOutOfRangeException("args");
                p2 = p2.Next;
            }
            
            while(p2.Next != null)
            {
                IncrementIteration();
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p1;
        }
    }
}
