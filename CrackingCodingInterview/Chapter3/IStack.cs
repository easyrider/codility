namespace CrackingCodingInterview.Chapter3
{
    public interface IStack<T>
    {
        T Peek();
        T Pop();
        void Push(T value);
    }
}