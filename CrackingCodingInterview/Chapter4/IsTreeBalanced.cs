using System;

namespace CrackingCodingInterview.Chapter4
{
    [Reference(
        Page = 54
        , Number = "4.1"
        , Description = "Implement a function to check if a tree is balanced. For the purposes of this question," +
                        "a balanced tree is defined to be a tree such that no two leaf nodes differ in distance" +
                        "from the root by more than one.")]
    public class IsTreeBalanced : Algorithm<TreeNode<int>, bool>
    {
        protected override int OnInitComplexity(TreeNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            return -1;
        }

        protected override bool OnExecute(TreeNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            return ((GetMaxDepthOfTreeNode(arg) - GetMinDepthOfTreeNode(arg)) <= 1);
        }

        public static int GetMaxDepthOfTreeNode(TreeNode<int> node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetMaxDepthOfTreeNode(node.Left), GetMaxDepthOfTreeNode(node.Right));
        }

        public static int GetMinDepthOfTreeNode(TreeNode<int> node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Min(GetMinDepthOfTreeNode(node.Left), GetMinDepthOfTreeNode(node.Right));
        }
    }
}