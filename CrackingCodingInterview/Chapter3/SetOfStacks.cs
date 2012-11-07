using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter3
{
     [Reference(
        Page = 52
        , Number = "3.3"
        , Description = "Imagine a literal stack of plates. If the stack gets too high it might topple" +
                        "Therefore in real life we would likely start a new stack when the previous" +
                        "stack exceeds some threshold. Implement a data  structure SetOfStacks that mimics this. " +
                        "(See more text in the book. I didn't do follow up part)")]
    public class SetOfStacks<T> : IStack<T>
    {
        readonly Stack<Stack<T>> _set = new Stack<Stack<T>>();
 
        public int Capacity { get; private set; }

        public SetOfStacks(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException();
            Capacity = capacity;
        }

        public T Peek()
        {
            var last = GetLastStack();
            if (last == null)
                throw new InvalidOperationException();
            return last.Peek();
        }

        public T Pop()
        {
            Stack<T> last = GetLastStack();
            var pop = last.Pop();
            if (last.Count == 0) RemoveStack();
            return pop;
        }

        public void Push(T value)
        {
            Stack<T> last = GetLastStack();

            if (last != null && (last.Count < Capacity))
            {
                last.Push(value);
            }
            else
            {
                CreateNewStack().Push(value);
            }
        }

        private Stack<T> CreateNewStack()
        {
            var stack = new Stack<T>(Capacity);
            _set.Push(stack);
            return stack;
        }

        private void RemoveStack()
        {
            _set.Pop();
        }

        private Stack<T> GetLastStack()
        {
            return _set.Count == 0 ? null : _set.Peek();
        }
    }
}
