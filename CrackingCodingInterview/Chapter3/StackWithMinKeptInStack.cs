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
        , Variant = 2)]
    public class StackWithMinKeptInStack<T> : IStackWithMin<T> where T : IComparable<T>
    {
        public T Peek()
        {
            return _internal.Peek();
        }

        public T Pop()
        {
            var value = _internal.Peek();

            if (value.CompareTo(Min()) == 0)
            {
                _mins.Pop();
            }

            return _internal.Pop();
        }

        public void Push(T value)
        {
            var min = _internal.Count == 0 ? value : Min();
        
            if (value.CompareTo(min) <= 0)
            {
                _mins.Push(value);
            }

            _internal.Push(value);
        }

        public T Min()
        {
            if (_internal.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return _mins.Peek();
        }
        
        private readonly Stack<T> _internal = new Stack<T>();
        private readonly Stack<T> _mins = new Stack<T>(); 
    }
}
