using System;
using System.Collections;
using CrackingCodingInterview.Chapter9;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter9
{
    [TestFixture]
    public class FindStringInSortedInterspersedWithEmptyStringArrayTest : TestBase
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return
                    new TestCaseData(new string[] {"at", "", "", "", "ball", "", "", "car", "", "", "dad", "", ""}, "ball")
                    .Returns(4);
                yield return
                    new TestCaseData(new string[] { "at", "", "", "", "", "ball", "car", "", "", "dad", "", "" }, "ballcar")
                        .Returns(-1);
            }
        }


        [TestCaseSource("TestCases")]
        [Test]
        public int Test(string[] array, string value)
        {
            int result = RunTest(Tuple.Create(array, value), new FindStringInSortedInterspersedWithEmptyStringArray());
            return result;
        }
    }
}
