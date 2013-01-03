using System.Collections;
using System.Globalization;
using System.Linq;
using CrackingCodingInterview.Chapter8;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter8
{
    [TestFixture]
    public class GetFibonacciNumberTest : TestBase
    {  
        private static IEnumerable TestCases
        {
            get
            {
                int[] fibonacci = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144};

                return fibonacci.Select((t, i) => new TestCaseData(i)
                                                      .Returns(t)
                                                      .SetName(t.ToString(CultureInfo.InvariantCulture)));
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int Recursive(int nth)
        {
            return RunTest(nth, new GetFibonacciNumberRecursive());
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int Iterative(int nth)
        {
            return RunTest(nth, new GetFibonacciNumberIterative());
        }
    }
}
