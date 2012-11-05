using System;

namespace CrackingCodingInterview.Chapter3
{
    public interface IStackWithMin<T> where T : IComparable<T>
    {
        T Peek();
        T Pop();
        void Push(T value);
        T Min();
    }
}