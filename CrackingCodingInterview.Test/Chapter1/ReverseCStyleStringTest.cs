using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class ReverseCStyleStringTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public string Test(string @string)
        {
            var cut = new ReverseCStyleString();
            return RunTest(new CStyleString(@string), cut).ToString();
        }

        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(null).Throws(typeof(ArgumentNullException)).SetName("Null argument");
                yield return new TestCaseData(string.Empty).Returns(string.Empty).SetName("Empty string");
                yield return new TestCaseData("a").Returns("a").SetName("One char string");
                yield return new TestCaseData("abc").Returns("cba").SetName("Abc string");
            }
        }


    }

}
