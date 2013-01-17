using System.Collections.Generic;
using CrackingCodingInterview.Chapter8;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter8
{

    [TestFixture]
    public class GetPermutationsOfStringTest : TestBase
    {
        [Test]
        public void Test()
        {
            const string originalString = "abc";
            List<string> expectedPermuted = new List<string>
                                                {
                                                    "abc",
                                                    "bac",
                                                    "bca",
                                                    "acb",
                                                    "cab",
                                                    "cba"
                                                };

            GetPermutationsOfString getPermutationsOfString = new GetPermutationsOfString();
            List<string> permuted = getPermutationsOfString.Execute(originalString);
            CollectionAssert.AreEquivalent(expectedPermuted, permuted);
        }
    }
}
