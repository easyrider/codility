using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter4
{ 

    [Reference(
        Page = 54
        , Number = "4.3"
        , Description = "Given a sorted (increasing order) array, write an algoithm to create a binary tree with " +
                        "minimal height")]
    public class CreateTreeWithMinHeightFromAscOrderAlgorithm : Algorithm<int[], TreeNode<int>>
    {
        protected override int OnInitComplexity(int[] arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            return arg.Length;
        }

        protected override TreeNode<int> OnExecute(int[] arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");

            for (int i = 1; i < arg.Length; i++)
                if (arg[i] < arg[i - 1])
                    throw new ArgumentException("Array is not sorted in ascending order", "arg");

            return AddToTree(arg, 0, arg.Length - 1);
        }

        private TreeNode<int> AddToTree(IList<int> @array, int start, int end)
        {   
            if (end < start)
                return null;

            IncrementIteration();

            int mid = (start + end)/2;
            var treeNode = new TreeNode<int>
                               {
                                   Value = @array[mid],
                                   Left = AddToTree(@array, start, mid - 1),
                                   Right = AddToTree(@array, mid + 1, end)
                               };
            return treeNode;
        }

    }
}
