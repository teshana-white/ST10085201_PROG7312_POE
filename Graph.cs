using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class Graph
    {
        private readonly Dictionary<string, List<(string to, int weight)>> adjacencyList = new Dictionary<string, List<(string to, int weight)>>();


        public void AddVertex(string id)
        {
            if (!adjacencyList.ContainsKey(id))
                adjacencyList[id] = new List<(string to, int weight)>();
        }

        public void AddEdge(string from, string to, int weight)
        {
            if (!adjacencyList.ContainsKey(from))
                AddVertex(from);

            if (!adjacencyList.ContainsKey(to))
                AddVertex(to);

            adjacencyList[from].Add((to, weight));
            adjacencyList[to].Add((from, weight)); // Assuming undirected graph
        }

        public List<string> GetNeighbors(string vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                // Return only the neighbor IDs (the first item of each tuple)
                return adjacencyList[vertex].Select(t => t.Item1).ToList();
            }
            else
            {
                return new List<string>(); // Return an empty list if vertex is not found
            }
        }

        public List<(string From, string To, int Weight)> GenerateMST()
        {
            var mstEdges = new List<(string From, string To, int Weight)>();
            var visited = new HashSet<string>();
            var priorityQueue = new SortedSet<(int Weight, string From, string To)>();

            string startNode = adjacencyList.Keys.First();
            visited.Add(startNode);

            foreach (var (to, weight) in adjacencyList[startNode])
                priorityQueue.Add((weight, startNode, to));

            while (priorityQueue.Count > 0 && visited.Count < adjacencyList.Count)
            {
                var (weight, from, to) = priorityQueue.First();
                priorityQueue.Remove(priorityQueue.First());

                if (visited.Contains(to)) continue;

                visited.Add(to);
                mstEdges.Add((from, to, weight));

                foreach (var (neighbor, neighborWeight) in adjacencyList[to])
                {
                    if (!visited.Contains(neighbor))
                        priorityQueue.Add((neighborWeight, to, neighbor));
                }
            }

            return mstEdges;
        }
    }

}

