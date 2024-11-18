using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class Events
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Announcement { get; set; }

        public Events(string name, string category, DateTime date, string description, bool announcement)
        {
            Name = name;
            Category = category;
            Date = date;
            Description = description;
            Announcement = announcement;
        }
    }
}
