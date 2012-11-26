using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter4
{ 

    [Reference(
        Page = 54
        , Number = "4.4"
        , Description = "Given a binary search tree, design an  algorithm which creates a linked list of all the " +
                        "nodes at each depth (e.g., if you have a tree with depth D, you'll have D linked lists)")]
    public class GetListsOfNodesPerLevelOfTree : Algorithm<TreeNode<int>, List<TreeNode<int>>[]>
    {
        protected override List<TreeNode<int>>[] OnExecute(TreeNode<int> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            int level = 0;

            List<TreeNode<int>>[] result = new List<TreeNode<int>>[IsTreeBalanced.GetMaxDepthOfTreeNode(arg)];

            List<TreeNode<int>> treeNodes = new List<TreeNode<int>> {arg};
            result[level] = treeNodes;

            while (true)
            {
                treeNodes = new List<TreeNode<int>>();

                for (int i = 0; i < result[level].Count; i++)
                {
                    TreeNode<int> treeNode = result[level][i];

                    if (treeNode == null) continue;
                    AddNode(treeNode.Left, treeNodes);
                    AddNode(treeNode.Right, treeNodes);
                }

                if (treeNodes.Count > 0)
                {
                    result[++level] = treeNodes;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        private static void AddNode(TreeNode<int> node, List<TreeNode<int>> treeNodes)
        {
            if (node != null)
            {
                treeNodes.Add(node);
            }
        }
    }
}
