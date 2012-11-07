using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CrackingCodingInterview.Chapter3;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter3
{
    [TestFixture]
    public class SetOfStacksTest
    {
        [Test]
        [TestCaseSource("TestCases")]
        public void Test(IEnumerable<int> valuesForStack)
        {
            var stackArray = valuesForStack as int[] ?? valuesForStack.ToArray();
            Trace.WriteLine(stackArray.Aggregate(new StringBuilder(), (builder, i) => builder.AppendFormat("{0} ", i)));

            var stack = new SetOfStacks<int>(2);

            foreach (var i in stackArray)
            {
                stack.Push(i);
            }

            foreach (var i in stackArray.Reverse())
            {
                var peek = stack.Peek();
                var pop = stack.Pop();
                Assert.AreEqual(i, peek);
                Assert.AreEqual(i, pop);
            }
        }

        public static IEnumerable TestCases
        {
            get
            {  
                var random = new Randomizer();
                for (int i = 0; i < 10; i++)
                {
                    var ints = random.GetInts(-100, 100, random.Next(1, 10));

                    yield return new TestCaseData(ints)
                        .SetName(string.Format("Random count of {0}", ints.Length));    
                }
            }
        }
    }
}
