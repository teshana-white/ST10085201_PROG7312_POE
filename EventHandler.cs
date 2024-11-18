using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
        public class EventHandler
        {
            private SortedDictionary<DateTime, Stack<Events>> allEvents;
            private HashSet<Events> announcements;
            private Dictionary<string, Queue<Events>> eventsByCategory;
            private Hashtable searchResults;
            private Queue<string> searchHistory;

            public EventHandler()
            {
                allEvents = new SortedDictionary<DateTime, Stack<Events>>();
                announcements = new HashSet<Events>();
                eventsByCategory = new Dictionary<string, Queue<Events>>
        {
            { "Cultural", new Queue<Events>() },
            { "Political", new Queue<Events>() },
            { "Professional", new Queue<Events>() },
            { "Sports", new Queue<Events>() },
            { "Other", new Queue<Events>() }
        };
                searchResults = new Hashtable();
                searchHistory = new Queue<string>();
            }

            // Event sorting and storing
            public void AddEvent(Events ev)
            {
                if (!allEvents.ContainsKey(ev.Date))
                    allEvents[ev.Date] = new Stack<Events>();
                allEvents[ev.Date].Push(ev);

                if (ev.Announcement)
                    announcements.Add(ev);

                if (!eventsByCategory.ContainsKey(ev.Category))
                    eventsByCategory[ev.Category] = new Queue<Events>();
                eventsByCategory[ev.Category].Enqueue(ev);
            }

            // Sorts all events by date with the event nearest to today's date being first
            public IEnumerable<Events> GetAllEvents()
            {
                foreach (var dateEvents in allEvents)
                {
                    foreach (var ev in dateEvents.Value)
                        yield return ev;
                }
            }

            // Get and return Announcements
            public IEnumerable<Events> GetAnnouncements()
            {
                return announcements;
            }

            // Search function
            public IEnumerable<Events> SearchEvents(string name)
            {
                searchResults.Clear();

                // Add to search history
                string searchQuery = $"Name: {name}";
                searchHistory.Enqueue(searchQuery);
                if (searchHistory.Count > 10) searchHistory.Dequeue();  // Limit history to 10 entries

                // Perform search
                foreach (var dateEvents in allEvents)
                {
                    foreach (var ev in dateEvents.Value)
                    {
                        if (string.IsNullOrEmpty(name) || ev.Name.ToLower().Contains(name.ToLower()))
                        {
                            searchResults[ev.Name] = ev;
                            yield return ev;
                        }
                    }
                }
            }


        public IEnumerable<string> GetSearchHistory()
            {
                return searchHistory;
            }

            // Clear search results after closing form
            public void ClearSearchResults()
            {
                searchResults.Clear();
            }
        }
}
