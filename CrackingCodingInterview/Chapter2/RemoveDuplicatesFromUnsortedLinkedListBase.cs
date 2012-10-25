namespace CrackingCodingInterview.Chapter2
{
    public abstract class RemoveDuplicatesFromUnsortedLinkedListBase : Algorithm<LinkedListNode<int>, LinkedListNode<int>>  
    {
        protected override int OnInitComplexity(LinkedListNode<int> arg)
        {
            return arg.GetLength();
        }
    }
}