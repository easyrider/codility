using System;
using System.Collections;
using CrackingCodingInterview.Chapter5;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter5
{
    [TestFixture]
    public class SwapOddAndEventBitsTest : TestBase
    {
        private static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData("0101").Returns("1010");
                yield return new TestCaseData("1010").Returns("0101");
                yield return new TestCaseData("1100").Returns("1100");
            }
        }

        
        [Test]
        [TestCaseSource("TestData")]
        public string Test(string arg)
        {
            uint input = Convert.ToUInt32(arg, 2);
            uint result = RunTest(input, new SwapOddAndEventBits());
            return Convert.ToString(result, 2).PadLeft(arg.Length, '0');
        }
    }
}
