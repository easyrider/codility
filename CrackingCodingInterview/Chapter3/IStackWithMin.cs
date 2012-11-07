using System;

namespace CrackingCodingInterview.Chapter3
{
    public interface IStackWithMin<T> : IStack<T> where T : IComparable<T>
    {
        T Min();
    }
}