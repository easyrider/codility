using System;
using System.Collections;
using System.Diagnostics;
using CrackingCodingInterview.Chapter5;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter5
{
    [TestFixture]
    public class GetNumberOfBitsRequiredToConvertTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(2, 24).Returns(3);
                yield return new TestCaseData(3, 140).Returns(5);
                yield return new TestCaseData(22, 23).Returns(1);
                yield return new TestCaseData(8, 5).Returns(3);
            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public int Test(int a, int b)
        {
            return RunTest(Tuple.Create(a, b), new GetNumberOfBitsRequiredToConvert());
        }
    }
}
