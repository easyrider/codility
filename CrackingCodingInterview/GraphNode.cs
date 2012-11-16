using System;
using System.Collections.Generic;

namespace CrackingCodingInterview
{
    public sealed class GraphNode
    {
        public GraphNodeState State { get; set; }

        public IEnumerable<GraphNode> GetAdjacent()
        {
            return _adjacent.AsReadOnly();
        }

        internal void Connect(GraphNode to)
        {
            if (to == null) throw new ArgumentNullException("to");
            _adjacent.Add(to);
        }

        private readonly List<GraphNode> _adjacent = new List<GraphNode>();
    }
}