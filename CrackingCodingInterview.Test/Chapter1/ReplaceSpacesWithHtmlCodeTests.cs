using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class ReplaceSpacesWithHtmlCodeTests : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public string Test(string @string, int length)
        {
            var cut = new ReplaceSpacesWithHtmlCode();
            return RunTest(new Tuple<CStyleString, int>(new CStyleString(@string), @string.Length), cut).ToString();
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(null, 0).Throws(typeof(ArgumentNullException)).SetName("Nulls");
                yield return new TestCaseData("", 0).Returns("").SetName("Empty strings");
                
                yield return new TestCaseData(" a", 2).Returns("%20a").SetName("In the start");
                yield return new TestCaseData("a ", 2).Returns("a%20").SetName("In the end");
                yield return new TestCaseData("a", 1).Returns("a").SetName("No space");
                yield return new TestCaseData("a b", 3).Returns("a%20b").SetName("In the middle");
                yield return new TestCaseData(" a b ", 5).Returns("%20a%20b%20").SetName("Three spaces");



            }
        }
    }
}