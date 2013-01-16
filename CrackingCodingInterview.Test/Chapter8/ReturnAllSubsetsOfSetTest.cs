using System.Collections.Generic;
using System.Linq;
using CrackingCodingInterview.Chapter8;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter8
{
    [TestFixture]
    public class ReturnAllSubsetsOfSetTest: TestBase
    {  
        [Test]
        public void Recursive()
        {
            int[] @array = new[] {1, 56};
            List<List<int>> runTest = RunTest(@array, new ReturnAllSubsetsOfSetRecursive());
            CollectionAssert.AreEquivalent(new []{1, 56, 1, 56},runTest.SelectMany(x => x));
        }

        [Test]
        public void Iterative()
        {
            int[] @array = new[] { 1, 56 };
            List<List<int>> runTest = RunTest(@array, new ReturnAllSubsetsOfSetIterative());
            CollectionAssert.AreEquivalent(new[] { 1, 56, 1, 56 }, runTest.SelectMany(x => x));
        }
    }
}
