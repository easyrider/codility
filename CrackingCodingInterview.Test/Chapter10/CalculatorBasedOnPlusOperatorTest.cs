using System.Collections;
using CrackingCodingInterview.Chapter10;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter10
{
    [TestFixture]
    public class CalculatorBasedOnPlusOperatorTest : TestBase
    {
        private CalculatorBasedOnPlusOperator _cut;

        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(10, 2);
                yield return new TestCaseData(10, -2);
                yield return new TestCaseData(-10, 2);
                yield return new TestCaseData(-10,-2);
                yield return new TestCaseData(0, -2);
            }
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            _cut = new CalculatorBasedOnPlusOperator();
        }


        [TestCaseSource("TestCases")]
        [Test]
        public void Minus(int x, int y)
        {
            int result = _cut.Minus(x, y);
            Assert.AreEqual(x - y, result);
        }

        [TestCaseSource("TestCases")]
        [Test]
        public void Multiple(int x, int y)
        {
            int result = _cut.Multiple(x, y);
            Assert.AreEqual(x * y, result);
        }

        [TestCaseSource("TestCases")]
        [Test]
        public void Divide(int x, int y)
        {
            int result = _cut.Divide(x, y);
            Assert.AreEqual(x / y, result);
        }
    }
}
