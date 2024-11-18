using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    internal class Issues
    {

        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; }

        public Issues(string location, string category, string description, List<string> attachments)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachments = attachments;
        }

        public override string ToString()
        {
            return
                $"Location: {Location}, " +
                $"Category: {Category}, " +
                $"Description: {Description}, " +
                $"Attachments: {Attachments.Count}";
        }
    }
}
