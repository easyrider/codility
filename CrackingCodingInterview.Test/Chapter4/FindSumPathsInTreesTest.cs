using System;
using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class FindSumPathsInTreesTest : TestBase
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
                i.Left = h;

                yield return new TestCaseData(f, 1).Returns("[1];").SetName("1");
                yield return new TestCaseData(f, 2).Returns("[2];").SetName("2");
                yield return new TestCaseData(f, 4).Returns("[4];").SetName("4");
                yield return new TestCaseData(f, 8).Returns("[6][2];[8];").SetName("8");
                yield return new TestCaseData(f, 16).Returns("[7][9];").SetName("16");
                yield return new TestCaseData(f, 32).Returns("").SetName("32");
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public string Test(TreeNode<int> root, int sum)
        {
            Tuple<TreeNode<int>, int> tuple = Tuple.Create(root, sum);
            return RunTest(tuple, new FindSumPathsInTree());
        }
    }
}
