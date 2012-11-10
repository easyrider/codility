using System.Collections.Generic;


namespace CrackingCodingInterview.Chapter3
{
    [Reference(
        Page = 52
        , Number = "3.5"
        , Description = "Implement a queue which implemens a queue using two stacks")]
    public class QueueBasedOnTwoStacks<T>
    {
        public QueueBasedOnTwoStacks()
        {
            _popPeekStack = new Stack<T>();
            _pushStack = new Stack<T>();
        }

        public QueueBasedOnTwoStacks(int count)
        {
            _popPeekStack = new Stack<T>(count);
            _pushStack = new Stack<T>(count);
        }

        public void Enqueue(T item)
        {
            _pushStack.Push(item);
        }

        public T Dequeue()
        {
            if (_popPeekStack.Count == 0)
                while (_pushStack.Count > 0)
                    _popPeekStack.Push(_pushStack.Pop());

            return _popPeekStack.Pop();
        }

        private readonly Stack<T> _popPeekStack;
        private readonly Stack<T> _pushStack;
    }
}
