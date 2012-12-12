using System;
using System.Collections;
using System.Diagnostics;
using CrackingCodingInterview.Chapter5;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter5
{

    [TestFixture]
    public class GetNextSmallerAndBiggerNumsWithSameAmountOfBitsTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData((uint)10);
                yield return new TestCaseData((uint)33);
                yield return new TestCaseData((uint)57);
                yield return new TestCaseData((uint)99);

            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public void Test(uint num)
        {
            var result = RunTest(num, new GetNextSmallerAndBiggerNumsWithSameAmountOfBits());
            Trace.TraceInformation("num: b{0} => {1}", Convert.ToString(num, 2), num);
            Trace.TraceInformation("result.Item1: b{0} => {1}", Convert.ToString(result.Item1, 2), result.Item1);
            Trace.TraceInformation("result.Item2: b{0} => {1}", Convert.ToString(result.Item2, 2), result.Item2);
        }
    }
}
