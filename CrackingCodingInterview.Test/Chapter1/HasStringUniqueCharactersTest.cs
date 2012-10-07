using System.Collections;
using System.Diagnostics;
using System.Text;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{

    [TestFixture]
    public class HasStringUniqueCharactersTest
    {
        [Test]
        [TestCaseSource("TestCases")]
        public bool WoDataStrcutures_Test(string @string)
        {
            var cut = new HasStringUniqueCharactersWoDataStructures();
            return RunTest(@string, cut);
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool WithArray_Test(string @string)
        {
            var cut = new HasStringUniqueCharactersWithArray();
            return RunTest(@string, cut);
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool WithHashSet_Test(string @string)
        {
            var cut = new HasStringUniqueCharactersWithHashSet();
            return RunTest(@string, cut);
        }

        private static bool RunTest(string @string, Algorithm<string, bool> cut)
        {
            var withHashSetTest = cut.Execute(@string);
            Trace.TraceInformation("Execution Time: {0}", cut.ExecutionTime);
            Trace.TraceInformation("Complexity: {0}", cut.Complexity);
            return withHashSetTest;
        }

        public static IEnumerable TestCases
        {
            get 
            {
                yield return new TestCaseData("asdfgh").Returns(true).SetName("Unique characters");
                yield return new TestCaseData("aasdfgh").Returns(false).SetName("Doubled chars at the start");
                yield return new TestCaseData("asdfghh").Returns(false).SetName("Doubled chars at the end");
                yield return new TestCaseData("asddfgh").Returns(false).SetName("Double chars in the middle");
                yield return new TestCaseData("aasdfghh").Returns(false).SetName("Double chars on both sides");

                var sb = new StringBuilder();
                for(var i = 'a'; i < 6500; i++)
                {
                    sb.Append(i);
                }
                yield return new TestCaseData(sb.ToString()).Returns(true).SetName("Benchmarking");
            }
        }


    }

}
