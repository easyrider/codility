using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class CheckWhetherStringsAreRotationsTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public bool Test(Tuple<string, string> strings)
        {
            var cut = new CheckWhetherStringsAreRotations();
            return RunTest(strings, cut);
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(null).Throws(typeof (NullReferenceException)).SetName("Null");
                yield return new TestCaseData(Tuple.Create<string, string>(null, null)).Throws(typeof(NullReferenceException)).SetName("Nulls");
                yield return new TestCaseData(Tuple.Create("apple", "leapp")).Returns(true).SetName("Rotated");
                yield return new TestCaseData(Tuple.Create("apple", "leap")).Returns(false).SetName("Different length");
                yield return new TestCaseData(Tuple.Create("apple", "elapp")).Returns(false).SetName("Not rotated");
            }
        }
    }


}