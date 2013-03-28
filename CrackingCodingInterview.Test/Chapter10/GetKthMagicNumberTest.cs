using System.Collections;
using System.Linq;
using CrackingCodingInterview.Chapter10;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter10
{
    [TestFixture]
    public class GetKthMagicNumberTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                int[] magics = {0, 1, 3, 5, 7, 9, 15, 21, 25, 27, 35, 45, 49, 63};

                return magics.Select((x, i) => new TestCaseData(i).Returns(x));
            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public int Test(int value)
        {
            int result = RunTest(value, new GetKthMagicNumber());
            return result;
        }
    }
}
