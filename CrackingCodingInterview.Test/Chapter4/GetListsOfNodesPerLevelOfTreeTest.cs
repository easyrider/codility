using System.Collections.Generic;
using System.Linq;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class GetListsOfNodesPerLevelOfTreeTest : TestBase
    {
        
        [Test]
        public void It_Just_Works()
        {
            TreeNode<int> root = new TreeNode<int>
                                     {
                                         Value = 0,
                                         Left = new TreeNode<int>
                                                    {
                                                        Value = 1,
                                                        Left = new TreeNode<int>
                                                                   {
                                                                       Value = 3
                                                                   },
                                                        Right = new TreeNode<int>
                                                                    {
                                                                        Value = 4
                                                                    }
                                                    },
                                         Right = new TreeNode<int>
                                         {
                                             Value = 2,
                                             Left = new TreeNode<int>
                                             {
                                                 Value = 5
                                             },
                                             Right = new TreeNode<int>
                                             {
                                                 Value = 6
                                             }
                                         }
                                     };

            List<TreeNode<int>>[] treeNodes = RunTest(root, new GetListsOfNodesPerLevelOfTree());
        
            Assert.That(treeNodes, Has.Length.EqualTo(3));
            CollectionAssert.AreEqual(treeNodes[0].Select(x => x.Value), new [] { 0 });
            CollectionAssert.AreEqual(treeNodes[1].Select(x => x.Value), new[] { 1, 2 });
            CollectionAssert.AreEqual(treeNodes[2].Select(x => x.Value), new[] { 3, 4, 5, 6 });

        }
    }
}