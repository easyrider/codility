using System;
using System.Collections.Generic;
using System.Linq;

namespace CrackingCodingInterview.Chapter4
{

     [Reference(
        Page = 54
        , Number = "4.2"
        , Description = "Given a directed graph, design an algorithm to find out " +
                        "whether there is a route between two nodes")]
    public sealed class IsRouteBetweenTwoNodesInDirectedGraph : Algorithm<Tuple<Graph, GraphNode, GraphNode>, bool>
    {
        protected override int OnInitComplexity(Tuple<Graph, GraphNode, GraphNode> arg)
        {
            return -1;
        }

        protected override bool OnExecute(Tuple<Graph, GraphNode, GraphNode> arg)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            Graph graph = arg.Item1;
            if (graph == null) throw new ArgumentException("Item1 is null", "arg");
            GraphNode start = arg.Item2;
            if (start == null) throw new ArgumentException("Item2 is null", "arg");
            GraphNode end = arg.Item3;
            if (start == null) throw new ArgumentException("Item3 is null", "arg");

            Queue<GraphNode> visitingList = new Queue<GraphNode>();
            foreach (GraphNode graphNode in graph.GetNodes())
            {
                graphNode.State = GraphNodeState.Unvisited;
            }


            start.State = GraphNodeState.Visiting;
            visitingList.Enqueue(start);

            while (visitingList.Count > 0)
            {
                GraphNode node = visitingList.Dequeue();

                if (node == null) continue;

                foreach (GraphNode graphNode in node.GetAdjacent()
                                                    .Where(graphNode => graphNode.State == GraphNodeState.Unvisited))
                {
                    if (graphNode.Equals(end))
                    {
                        return true;
                    }
                        
                    graphNode.State = GraphNodeState.Visiting;
                    visitingList.Enqueue(graphNode);
                }

                node.State = GraphNodeState.Visited;
            }

            return false;
        }
    }
}
