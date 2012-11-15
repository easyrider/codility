namespace CrackingCodingInterview
{
    public sealed class TreeNode<T>
    {
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Left { get; set; }
        public T Value { get; set; }
    }
}