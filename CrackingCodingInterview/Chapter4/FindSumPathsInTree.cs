using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingCodingInterview.Chapter4
{
    [Reference(
        Page = 54
        , Number = "4.8"
        , Description = "You are given a binary tree in which each node contains a value. Design an algorithm" +
                        "to print all paths which sum up to that value. Note that it can be any path in the tree" +
                        "- it does not have to start at the root")]
    public class FindSumPathsInTree : Algorithm<Tuple<TreeNode<int>, int>, string>
    {
        protected override string OnExecute(Tuple<TreeNode<int>, int> arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            TreeNode<int> treeNode = arg.Item1;
            
            if (treeNode == null)
            {
                throw new ArgumentException("Item1", "arg");
            }

            int sum = arg.Item2;

            return FindSum(treeNode, sum, new List<int>(),  0);

        }

        private static string FindSum(TreeNode<int> treeNode, int sum, List<int> buffer, int level)
        {
            if (treeNode == null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();

            int tmp = sum;
            buffer.Add(treeNode.Value);
            for (int i = level; i > -1; i--)
            {
                tmp -= buffer[i];
                if (tmp == 0)
                {
                    sb.Append(Print(buffer, i, level));
                }
            }

            List<int> copy1 = new List<int>(buffer);
            List<int> copy2 = new List<int>(buffer);
            level++;
            sb.Append(FindSum(treeNode.Left, sum, copy1, level));
            sb.Append(FindSum(treeNode.Right, sum, copy2, level));

            return sb.ToString();
        }

        private static string Print(IList<int> buffer, int level, int i2)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = level; i <= i2; i++)
            {
                sb.AppendFormat("[{0}]", buffer[i]);
            }

            sb.Append(";");

            return sb.ToString();
        }
    }
}
