using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter3
{

    [Reference(
        Page = 52
        , Number = "3.2"
        , Description = "How would you design a ctack which, in addition to push and pop, also" +
                        "has a function min which returns the minimum element?" +
                        "Push, pop and min should all operate in O(1) time"
        , Variant = 1)]
    public class StackWithMinKeptInNode<T> : IStackWithMin<T> where T : IComparable<T>
    {
        public T Peek()
        {
            return _internal.Peek().Value;
        }

        public T Pop()
        {
            return _internal.Pop().Value;
        }

        public void Push(T value)
        {
            var min = _internal.Count == 0 ? value : Min();
            min = value.CompareTo(min) < 0 ? value : min;
            _internal.Push(new NodeWithMin<T>(value, min));
        }

        public T Min()
        {
            if (_internal.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _internal.Peek().Min;
        }
        
        private readonly Stack<NodeWithMin<T>> _internal = new Stack<NodeWithMin<T>>(); 

        private sealed class NodeWithMin<T2>
        {
            public NodeWithMin(T2 value, T2 min)
            {
                Value = value;
                Min = min;
            }

            public T2 Min
            {
                get ;
                private set ;
            }

            public T2 Value
            {
                get ;
                private set ;
            }
        }
    }
}
