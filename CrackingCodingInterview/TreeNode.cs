namespace CrackingCodingInterview
{
    public sealed class TreeNode<T>
    {
        private TreeNode<T> _left;
        private TreeNode<T> _right;
        public TreeNode<T> Right
        {
            get { return _right; }
            set
            {
                _right = value;
                SetParentSafely(_right);
            }
        }

        public TreeNode<T> Left
        {
            get { return _left; }
            set
            {
                _left = value;
                SetParentSafely(_left);
            }
        }

        public T Value { get; set; }
        public TreeNode<T> Parent { get; private set; }

        private void SetParentSafely(TreeNode<T> node)
        {
            if (node != null)
            {
                node.Parent = this;
            }
        }
    }
}