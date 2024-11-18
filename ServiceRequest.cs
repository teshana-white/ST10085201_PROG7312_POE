using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        // Properties
        public string ID { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        // Constructor
        public ServiceRequest(string id, string location, string category, string description, string status, string priority)
        {
            ID = id;
            Location = location;
            Category = category;
            Description = description;
            Status = status;
            Priority = priority;
        }

        // ToString override for easier display of information
        public override string ToString()
        {
            return $"ID: {ID}, Location: {Location}, Category: {Category}, Description: {Description}, Status: {Status}, Priority: {Priority}";
        }

        // CompareTo for MinHeap and Priority Queue
        public int CompareTo(ServiceRequest other)
        {
            if (other == null) return 1;

            // Define priority ranking: Critical > High > Moderate > Low
            var priorityOrder = new Dictionary<string, int>
            {
                { "Critical", 1 },
                { "High", 2 },
                { "Moderate", 3 },
                { "Low", 4 }
            };

            // Compare priorities using the defined ranking
            int priorityComparison = priorityOrder[Priority].CompareTo(priorityOrder[other.Priority]);
            if (priorityComparison != 0)
                return priorityComparison;

            // If priorities are equal, compare by ID for consistency
            return string.Compare(ID, other.ID, StringComparison.Ordinal);
        }

        // Additional methods for extensibility
        public bool IsCompleted()
        {
            return Status.Equals("Completed", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsPending()
        {
            return Status.Equals("Pending", StringComparison.OrdinalIgnoreCase);
        }

        public bool IsCritical()
        {
            return Priority.Equals("Critical", StringComparison.OrdinalIgnoreCase);
        }
    }
}