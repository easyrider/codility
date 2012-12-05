using System;
using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
 
    [TestFixture]
    public class IsTreeSubtreeOfAnotherTreeTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                var a = new TreeNode<int> { Value = 1 };
                var b = new TreeNode<int> { Value = 2 };
                var c = new TreeNode<int> { Value = 3 };
                var d = new TreeNode<int> { Value = 4 };
                var e = new TreeNode<int> { Value = 5 };
                var f = new TreeNode<int> { Value = 6 };
                var g = new TreeNode<int> { Value = 7 };
                var h = new TreeNode<int> { Value = 8 };
                var i = new TreeNode<int> { Value = 9 };

                f.Left = b;
                f.Right = g;
                b.Left = a;
                b.Right = d;
                d.Left = c;
                d.Right = e;
                g.Right = i;
                
                yield return new TestCaseData(f, b).Returns(true).SetName("Is subtree");
                yield return new TestCaseData(f, d).Returns(true).SetName("Is subtree");
                yield return new TestCaseData(f, h).Returns(false).SetName("Is not subtree");
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool Test(TreeNode<int> tree, TreeNode<int> subTree )
        {
            return RunTest(Tuple.Create(tree, subTree), new IsTreeSubtreeOfAnotherTree<int>());
        }
    }
}
