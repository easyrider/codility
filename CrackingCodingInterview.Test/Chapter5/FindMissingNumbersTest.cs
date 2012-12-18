using System.Collections;
using CrackingCodingInterview.Chapter5;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter5
{

    [TestFixture]
    public class FindMissingNumbersTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] {0, 1, 2, 3, 4, 5, 7, 8, 9})
                    .Returns(6);
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int Test(int[] args)
        {
            return RunTest(args, new FindMissingNumbers());
        }
    }
}
