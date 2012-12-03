using System;
using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class FindCommonAncestorTest : TestBase
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

                yield return new TestCaseData(new[] { f, c, e }).Returns(d).SetName("d");
                yield return new TestCaseData(new[] { f, e, h }).Returns(f).SetName("f");
                yield return new TestCaseData(new[] { f, a, d }).Returns(b).SetName("b");
                yield return new TestCaseData(new[] { f, a, h }).Returns(f).SetName("f2");
                yield return new TestCaseData(new[] { f, a, b }).Returns(f).SetName("f3");
                yield return new TestCaseData(new[] { f, b, h }).Returns(f).SetName("f4");

                
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public TreeNode<int> Test(TreeNode<int> root, TreeNode<int> first, TreeNode<int> second)
        {
            var tuple = Tuple.Create(root, first, second);
            return RunTest(tuple, new FindCommonAncestor<int>());
        }
    }
}
