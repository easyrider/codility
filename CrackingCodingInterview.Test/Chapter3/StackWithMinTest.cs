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
    public class StackWithMinTest
    {
        [Test]
        [TestCaseSource("TestCases")]
        public int Min_Kept_In_Node(IEnumerable<int> valuesForStack)
        {
            return TestInternal(valuesForStack, new StackWithMinKeptInNode<int>());            
        }
        
        [Test]
        [TestCaseSource("TestCases")]
        public int Min_Kept_In_Stack(IEnumerable<int> valuesForStack)
        {
            return TestInternal(valuesForStack, new StackWithMinKeptInStack<int>());
        }
        
        private static int TestInternal(IEnumerable<int> valuesForStack, IStackWithMin<int>  stack)
        {
            var stackArray = valuesForStack as int[] ?? valuesForStack.ToArray();
            Trace.WriteLine(stackArray.Aggregate(new StringBuilder(), (builder, i) => builder.AppendFormat("{0} ", i)));

            foreach (var i in stackArray)
            {
                stack.Push(i);
            }

            var value = stack.Peek();
            stack.Pop();
            stack.Push(value);

            return stack.Min();
        }

        public static IEnumerable TestCases
        {
            get
            {  
                var random = new Randomizer();
                for (int i = 0; i < 10; i++)
                {
                    var ints = random.GetInts(-100, 100, random.Next(1, 10));
                    var min = ints.Min();

                    yield return new TestCaseData(ints).Returns(min)
                        .SetName(string.Format("Random count of {0}, with min {1}", ints.Length, min));    
                }
            }
        }
    }
}
