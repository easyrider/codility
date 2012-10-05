using System;
using System.Diagnostics;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{

    [TestFixture]
    public class HasStringUniqueCharactersTest
    {
        [Test]
        [TestCase("asdfgh", true)]
        [TestCase("aasdfgh", false)]
        [TestCase("asdfghh", false)]
        [TestCase("asddfgh", false)]
        [TestCase("aasdfghh", false)]
        public void Test(string @string, bool result)
        {
            var cut = new HasStringUniqueCharacters();
            Assert.AreEqual(result, cut.Execute(@string));
            Trace.TraceInformation("Complexity: {0}", cut.Complexity);
        }
    }

}
