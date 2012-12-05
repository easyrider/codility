using System;

namespace CrackingCodingInterview.Chapter4
{

    [Reference(
        Page = 54
        , Number = "4.7"
        , Description = "You have two very large binary trees: T1, with millions of nodes, and T2, with" +
                        "hundreds of nodes. Create an algorithm to decide if T2 is a subtree of T1")]
    public class IsTreeSubtreeOfAnotherTree<T> : Algorithm<Tuple<TreeNode<T>, TreeNode<T>>, bool>
    {
        protected override bool OnExecute(Tuple<TreeNode<T>, TreeNode<T>> arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            TreeNode<T> tree = arg.Item1;

            if (tree == null)
            {
                throw new ArgumentException("Item1", "arg");
            }

            TreeNode<T> subTree = arg.Item2;

            if (subTree == null)
            {
                throw new ArgumentException("Item2", "arg");
            }

            return IsSubTree(tree, subTree);
        }

        private static bool IsSubTree(TreeNode<T> tree, TreeNode<T> subTree)
        {
            if (tree == null)
            {
                return false;
            }

            if (Equals(tree.Value, subTree.Value))
            {
                if (MatchTree(tree, subTree))
                {
                    return true;
                }
            }

            return (IsSubTree(tree.Left, subTree) || IsSubTree(tree.Right, subTree));
        }

        private static bool MatchTree(TreeNode<T> tree, TreeNode<T> subTree)
        {
            if ((tree == null) && (subTree == null))
            {
                return true;
            }

            if ((tree == null) || (subTree == null))
            {
                return false;
            }

            if (!Equals(tree.Value, subTree.Value))
            {
                return false;
            }

            return (MatchTree(tree.Left, subTree.Left) && MatchTree(tree.Right, subTree.Right));
        }
    }
}
