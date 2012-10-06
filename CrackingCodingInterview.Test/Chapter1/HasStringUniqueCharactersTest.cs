using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{

    [TestFixture]
    public class HasStringUniqueCharactersTest
    {
        [Test]
        [TestCase("asdfgh", Result = true)]
        [TestCase("aasdfgh", Result = false)]
        [TestCase("asdfghh", Result = false)]
        [TestCase("asddfgh", Result = false)]
        [TestCase("aasdfghh", Result = false)]
        public bool WoDataStrcutures_Test(string @string)
        {
            var cut = new HasStringUniqueCharactersWoDataStructures();
            return cut.Execute(@string);
        }

        [Test]
        [TestCase("asdfgh", Result = true)]
        [TestCase("aasdfgh", Result = false)]
        [TestCase("asdfghh", Result = false)]
        [TestCase("asddfgh", Result = false)]
        [TestCase("aasdfghh", Result = false)]
        public bool WithArray_Test(string @string)
        {
            var cut = new HasStringUniqueCharactersWithArray();
            return cut.Execute(@string);
        }


    }

}
