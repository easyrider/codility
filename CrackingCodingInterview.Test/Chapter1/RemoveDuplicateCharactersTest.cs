using System;
using System.Collections;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{
    [TestFixture]
    public class RemoveDuplicateCharactersTest : TestBase
    {
        [Test]
        [TestCaseSource("TestCases")]
        public string Test(string @string)
        {
            var cut = new RemoveDuplicateCharacters();
            return RunTest(new CStyleString(@string), cut).ToString();
        }

        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData(null).Throws(typeof(ArgumentNullException)).SetName("Null argument");
                yield return new TestCaseData(string.Empty).Returns(string.Empty).SetName("Empty string");
                yield return new TestCaseData("aaaa").Returns("a").SetName("All duplicates");
                yield return new TestCaseData("abcd").Returns("abcd").SetName("Any duplicate");
                yield return new TestCaseData("aaabbb").Returns("ab").SetName("Continiuos duplicates");
                
            }
        }


    }

}
