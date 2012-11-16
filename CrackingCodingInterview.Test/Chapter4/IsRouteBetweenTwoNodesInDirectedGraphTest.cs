using System;
using System.Collections;
using CrackingCodingInterview.Chapter4;
using NUnit.Framework;

namespace CrackingCodingInterview.Test.Chapter4
{
    [TestFixture]
    public class IsRouteBetweenTwoNodesInDirectedGraphTest : TestBase
    {
        public static IEnumerable TestCases
        {
            get
            {
                var graph = new Graph();
                var a = new GraphNode();
                var b = new GraphNode();
                var c = new GraphNode();
                var d = new GraphNode();
                graph.AddNodes(a, b, c, d);
                graph.Connect(a, b);
                graph.Connect(c, a);
                graph.Connect(c, d);
                graph.Connect(d, b);

                yield return new TestCaseData(graph, a, d).Returns(false).SetName("No route");
                yield return new TestCaseData(graph, c, b).Returns(true).SetName("Has route");

            }
        }

        [Test]
        [TestCaseSource("TestCases")]
        public bool Test(Graph graph, GraphNode start, GraphNode end)
        {
            return RunTest(Tuple.Create(graph, start, end), new IsRouteBetweenTwoNodesInDirectedGraph());
        }
    }
}