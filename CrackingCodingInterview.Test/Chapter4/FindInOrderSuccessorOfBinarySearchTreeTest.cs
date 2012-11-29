using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
 
    [TestFixture]
    public class FindInOrderSuccessorOfBinarySearchTreeTest : TestBase
    {
        public static IEnumerable TestCases
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
                i.Left = h;

                yield return new TestCaseData(a).Returns(b).SetName("a");
                yield return new TestCaseData(b).Returns(c).SetName("b");
                yield return new TestCaseData(c).Returns(d).SetName("c");
                yield return new TestCaseData(d).Returns(e).SetName("d");
                yield return new TestCaseData(e).Returns(f).SetName("e");
                yield return new TestCaseData(f).Returns(g).SetName("f");
                yield return new TestCaseData(g).Returns(h).SetName("g");
                yield return new TestCaseData(h).Returns(i).SetName("h");

            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public TreeNode<int> Test(TreeNode<int> node)
        {
            return RunTest(node, new FindInOrderSuccessorOfBinarySearchTree<int>());
        }
    }
}
