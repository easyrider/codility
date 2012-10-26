using System.Collections.Generic;

namespace CrackingCodingInterview
{
    public class LinkedListNode<T>
    {
        protected bool Equals(LinkedListNode<T> other)
        {
            return EqualityComparer<T>.Default.Equals(Data, other.Data) && Equals(Next, other.Next);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (EqualityComparer<T>.Default.GetHashCode(Data)*397) ^ (Next != null ? Next.GetHashCode() : 0);
            }
        }

        public T Data { get; set; }

        public LinkedListNode<T> Next 
        { 
            get; set;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LinkedListNode<T>) obj);
        }
    }
}
