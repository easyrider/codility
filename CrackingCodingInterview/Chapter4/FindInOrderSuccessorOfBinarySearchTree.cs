using System;

namespace CrackingCodingInterview.Chapter4
{
     [Reference(
        Page = 54
        , Number = "4.5"
        , Description = "Write an algorithm to find the 'next' node (e.g., in-order successor) of a given node in" +
                        "a binary search tree where each node has a link to its parent")]
    public class FindInOrderSuccessorOfBinarySearchTree<T> : Algorithm<TreeNode<T>, TreeNode<T>>
    {
        protected override TreeNode<T> OnExecute(TreeNode<T> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            return GetInorderSuccessor(arg);
        }

        private static TreeNode<T> GetInorderSuccessor(TreeNode<T> node)
        {
            if (node == null)
            {
                return null;
            }

            TreeNode<T> successor;

            if ((node.Parent == null) || (node.Right != null))
            {
                successor = LeftMostChild(node.Right);
            }
            else
            {
                while ((successor = node.Parent) != null)
                {
                    if (successor.Left == node)
                    {
                        break;
                    }

                    node = successor;
                }
            }

            return successor;
        }

        private static TreeNode<T> LeftMostChild(TreeNode<T> node)
        {
            if (node == null)
            {
                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;    
        }
    }
}
