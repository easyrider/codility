using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class SortClassWithAnagramsTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData((object)new[] { "foo", "rba", "bar", "baz", "zab", "ofo" })
                    .Returns(new string[] { "rba", "bar", "baz", "zab", "ofo", "foo"});
                
            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public string[] Test(string[] array)
        {
            string[] result = RunTest(array, new SortClassWithAnagrams());
            return result;
        }
    }
}
