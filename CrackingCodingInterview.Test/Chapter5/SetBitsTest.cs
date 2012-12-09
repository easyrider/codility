using System;
using System.Collections;
using CrackingCodingInterview.Chapter5;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter5
{
    [TestFixture]
    public class SetBitsTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("10000000000", "10101", 2, 6)
                    .Returns("10001010100")
                    .SetName("Example from the book");

                yield return new TestCaseData("10000000011", "110", 1, 3)
                     .Returns("10000001101")
                     .SetName("My example");

            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public string Test(string n, string m, int i, int j)
        {
            var result = RunTest(Tuple.Create(Convert.ToInt32(n, 2), Convert.ToInt32(m, 2), i, j), new SetBits());
            return Convert.ToString(result, 2);
        }
}
}
