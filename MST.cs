using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class MST
    {
        public List<Edge> PrimMST(Dictionary<string, List<Edge>> graph, string start)
        {
            var mst = new List<Edge>();
            var visited = new HashSet<string>();
            var pq = new MinHeap<Edge>();

            foreach (var edge in graph[start])
                pq.Insert(edge);

            visited.Add(start);

            while (pq.Count > 0)
            {
                Edge minEdge = pq.ExtractMin();

                if (!visited.Contains(minEdge.To))
                {
                    visited.Add(minEdge.To);
                    mst.Add(minEdge);

                    foreach (var edge in graph[minEdge.To])
                        if (!visited.Contains(edge.To))
                            pq.Insert(edge);
                }
            }

            return mst;
        }
    }
}
