using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class IsTreeBalancedTest : TestBase
    {
        public static IEnumerable TestCases
        {
            get
            {
                var balancedTree = new TreeNode<int> {Value = 777};
                yield return new TestCaseData(balancedTree).Returns(true).SetName("One node balanced tree");

                balancedTree = new TreeNode<int>
                                   {
                                       Value = 777
                                       ,
                                       Left = new TreeNode<int>()
                                       ,
                                       Right = new TreeNode<int>()
                                   };
                yield return new TestCaseData(balancedTree).Returns(true).SetName("Three node balanced tree");


                balancedTree = new TreeNode<int>
                                   {
                                       Value = 777
                                       ,
                                       Left = new TreeNode<int>()
                                       ,
                                       Right = new TreeNode<int> {Left = new TreeNode<int>()}
                                   };
                yield return new TestCaseData(balancedTree).Returns(true).SetName("Four node balanced tree");


                balancedTree = new TreeNode<int>
                                   {
                                       Value = 777
                                       ,
                                       Left = new TreeNode<int>()
                                       ,
                                       Right =
                                           new TreeNode<int> {Left = new TreeNode<int> {Right = new TreeNode<int>()}}
                                   };
                yield return new TestCaseData(balancedTree).Returns(false).SetName("Five node unbalanced tree");
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool Test(TreeNode<int> tree)
        {
            return RunTest(tree, new IsTreeBalanced());
        }
    }
}