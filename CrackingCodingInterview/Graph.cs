using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    

    public sealed class Graph
    {
        public void AddNode(GraphNode node)
        {
            if (node == null) throw new ArgumentNullException("node");
            if (_nodes.Contains(node)) throw new ArgumentException("The node belongs already the graph", "node");
            _nodes.Add(node);
        }


        public void AddNodes(params GraphNode[] nodes)
        {
            foreach (var graphNode in nodes)
            {
                AddNode(graphNode);
            }
        }

        public void Connect(GraphNode from, GraphNode to)
        {
            if (@from == null) throw new ArgumentNullException("from");
            if (to == null) throw new ArgumentNullException("to");
            if (!_nodes.Contains(@from)) throw new ArgumentException("Node does not belong to the graph", "from");
            if (!_nodes.Contains(to)) throw new ArgumentException("Node does not belong to the graph", "to");

            from.Connect(to);
        }

        public IEnumerable<GraphNode> GetNodes()
        {
            return _nodes.AsReadOnly();
        }

        private readonly List<GraphNode> _nodes = new List<GraphNode>();
    }
}