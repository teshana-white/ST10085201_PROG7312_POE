using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class Edge : IComparable<Edge>
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Weight { get; set; }

        public Edge(string from, string to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            if (other == null) return 1;

            // Compare edges by their weight
            return this.Weight.CompareTo(other.Weight);
        }
    }
}
