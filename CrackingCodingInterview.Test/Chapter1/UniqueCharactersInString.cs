using System;
using CrackingCodingInterview.Chapter1;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter1
{

    [TestFixture]
    public class UniqueCharactersInStringTest
    {
        [Test]
        public void Test()
        {
            var cut = new UniqueCharactersInString();
            Assert.IsFalse(cut.HasAllUniqueCharactersWithoutDataStructures("asdavmamv"));
        }
    }

}
