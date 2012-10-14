using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class AreStringsAnagramsTests : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public bool Test(string string1, string string2)
        {
            var cut = new AreStringsAnagrams();
            return RunTest(new Tuple<string, string>(string1, string2), cut);
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("", "").Returns(false).SetName("Empty strings");
                yield return new TestCaseData("a", "ab").Returns(false).SetName("Different lengths");
                yield return new TestCaseData("mary", "army").Returns(true).SetName("Anagrams");
                yield return new TestCaseData("mary", "kate").Returns(false).SetName("Not anagrmas");
                yield return new TestCaseData(null, null).Throws(typeof(ArgumentException)).SetName("Nulls");

            }
        }
    }
}