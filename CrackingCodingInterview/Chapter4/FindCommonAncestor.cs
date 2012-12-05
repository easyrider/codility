using System;

namespace CrackingCodingInterview.Chapter4
{

    [Reference(
        Page = 54
        , Number = "4.6"
        , Description = "Design algorithm and write code too find the first common ancestor of two nodes" +
                        "in a binary tree. Avoid  storing additional nodes in a data structure. NOTE: This is not" +
                        "necessarily a binary search tree")]
    public class FindCommonAncestor<T> : Algorithm<Tuple<TreeNode<T>, TreeNode<T>, TreeNode<T>>, TreeNode<T>>
    {
        protected override TreeNode<T> OnExecute(Tuple<TreeNode<T>, TreeNode<T>, TreeNode<T>> arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            TreeNode<T> root = arg.Item1;
            if (root == null)
            {
                throw new ArgumentException("arg.Item1 should not be null");
            }
            TreeNode<T> firstNode = arg.Item2;
            if (firstNode == null)
            {
                throw new ArgumentException("arg.Item2 should not be null");
            }
            TreeNode<T> secondNode = arg.Item3;
            if (secondNode == null)
            {
                throw new ArgumentException("arg.Item3 should not be null");
            }

            return GetCommonAncestor(root, firstNode, secondNode);
        }

        private static TreeNode<T> GetCommonAncestor(TreeNode<T> root, TreeNode<T> firstNode, TreeNode<T> secondNode)
        {
            TreeNode<T> left = root.Left;
            TreeNode<T> right = root.Right;

            if ((firstNode == secondNode) && ((left == firstNode) || (right == firstNode)))
            {
                return root;
            }

            NodesFound foundNodesFromLeft = GetChildNodesFoundForRoot(left, firstNode, secondNode);

            if (foundNodesFromLeft == NodesFound.Two)
            {
                if ((left == firstNode) || (left == secondNode))
                {
                    return root;
                }
                
                return GetCommonAncestor(left, firstNode, secondNode);
            }
            
            if (foundNodesFromLeft == NodesFound.One)
            {
                if (root == firstNode)
                {
                    return firstNode;
                }
                if (root == secondNode)
                {
                    return secondNode;
                }
            }

            NodesFound foundNodesFromRight = GetChildNodesFoundForRoot(right, firstNode, secondNode);

            if (foundNodesFromRight == NodesFound.Two)
            {
                if ((right == firstNode) || (right == secondNode))
                {
                    return root;
                }

                return GetCommonAncestor(right, firstNode, secondNode);
            }

            if (foundNodesFromRight == NodesFound.One)
            {
                if (root == firstNode)
                {
                    return firstNode;
                }

                if (root == secondNode)
                {
                    return secondNode;
                }
            }

            if ((foundNodesFromLeft == NodesFound.One) && (foundNodesFromRight == NodesFound.One))
            {
                return root;
            }
            
            return null;
        }

        private static NodesFound GetChildNodesFoundForRoot(TreeNode<T> root, TreeNode<T> first, TreeNode<T> second)
        {
            var nodesFound = NodesFound.None;
            
            if (root == null)
            {
                return nodesFound;
            }

            if ((root == first) || (root == second))
            {
                nodesFound++;
            }

            nodesFound += (byte)GetChildNodesFoundForRoot(root.Left, first, second);

            if (nodesFound == NodesFound.Two)
            {
                return nodesFound;
            }

            return nodesFound + (byte)GetChildNodesFoundForRoot(root.Right, first, second);
        }

        enum NodesFound : byte
        {
            None = 0,
            One = 1,
            Two = 2
        }
    }
}
