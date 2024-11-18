using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ST10085201_PROG7312_POE
{
    public partial class LocalEventsForm : Form
    {
        private EventHandler eventHandler;

        public LocalEventsForm()
        {
            InitializeComponent();
            eventHandler = new EventHandler();
            LoadEvents();
            DisplayEvents();

            // Attach event handlers for the list boxes
            lbAllEvents.SelectedIndexChanged += lbAllEvents_SelectedIndexChanged;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            lbSearchResults.SelectedIndexChanged += lbSearchResults_SelectedIndexChanged;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadEvents()
        {
            // Load sample events
            eventHandler.AddEvent(new Events("CPT Jazz, Festival", "Cultural", new DateTime(2025, 04, 04), "Kaapse Klopse", false));
            eventHandler.AddEvent(new Events("AESIS 2024", "Professional", new DateTime(2024, 11, 28), "African Early Stage Investor Summit 2024", true));            
            eventHandler.AddEvent(new Events("France Olympics", "Sports", new DateTime(2024, 07, 26), "Olympic games held in France", false));
            eventHandler.AddEvent(new Events("Budget speech", "Political", new DateTime(2024, 02, 21), "Discussion on national budget and allocation of tax funds", true));
            eventHandler.AddEvent(new Events("BRICS Parliament Forum", "Political", new DateTime(2023, 09, 27), "9th BRICS Parliament Forum 2023: South Africa", true));
            eventHandler.AddEvent(new Events("Teshana Day", "Other", new DateTime(2025, 05, 20), "Teshana's birthday", false));
            eventHandler.AddEvent(new Events("Niel Diamond Tribute", "Cultural", new DateTime(2024, 11, 01), "Niel Diamond Tribute ft Johan Liebenberg at the Music Kitchen", false));
            eventHandler.AddEvent(new Events("Golf Day", "Sports", new DateTime(2024, 11, 01), "St John's Centre of Concern Golf Day at Walmer Golf Club", false));
            eventHandler.AddEvent(new Events("NMB 10km", "Other", new DateTime(2024, 11, 02), "NMB Choose to Challenge 10km Non-Profit Event", true));
            eventHandler.AddEvent(new Events("LSSATS", "Professional", new DateTime(2024, 10, 28), "Leadership in Shaping South Africa's Transport Sector conference event", true));
            eventHandler.AddEvent(new Events("Final Submission", "Professional", new DateTime(2024, 11, 18), "Final submission for PROG7312", true));
            eventHandler.AddEvent(new Events("Life's a Circus", "Cultural", new DateTime(2024, 11, 01), "Nineteen33 Speakeasy", false));
            eventHandler.AddEvent(new Events("The Magnificent 80's", "Cultural", new DateTime(2024, 11, 01), "Following on from the beloved Magnificent 7, Centrestage ventures into the 80's.", false));
            eventHandler.AddEvent(new Events("Charity Hike for Rhinos", "Sports", new DateTime(2024, 11, 02), "Charity Hike for Rhinos", true));
            eventHandler.AddEvent(new Events("Sister to Sister (Women Empowerment)", "Professional", new DateTime(2024, 11, 09), "Transformative gathering focused on empowering young ladies and mothers in our community", true));
            eventHandler.AddEvent(new Events("South Africa vs India", "Sports", new DateTime(2024, 11, 10), "South Africa vs India Wonder Cement T20 International cricket match", false));
            eventHandler.AddEvent(new Events("Deep Brew Sundaze", "Other", new DateTime(2024, 11, 24), "Sundaze celebrates progression by inspiring a cosmopolitan of cultural diversity and a romance with sound", true));
            eventHandler.AddEvent(new Events("Sip & Paint Affair", "Other", new DateTime(2024, 11, 30), "Enjoy 3 different wines, paint your own canvas, and indulge in a cheeseboard while enjoying good music", true));
            eventHandler.AddEvent(new Events("Spoken word", "Cultural", new DateTime(2024, 11, 25), "Poetry performance event that is set to promote entrepreneurship and artists", true));
        }

        private void DisplayEvents()
        {
            lbAllEvents.Items.Clear();
            lbAnnouncements.Items.Clear();
            lbSearchHistory.Items.Clear();

            // Display all events
            foreach (var ev in eventHandler.GetAllEvents())
            {
                lbAllEvents.Items.Add($"{ev.Name} - {ev.Date:MM/dd/yyyy}");
            }

            // Display announcements
            foreach (var ev in eventHandler.GetAnnouncements())
            {
                lbAnnouncements.Items.Add($"{ev.Name} - {ev.Date:MM/dd/yyyy}");
            }

            // Display search history
            foreach (var query in eventHandler.GetSearchHistory())
            {
                lbSearchHistory.Items.Add(query);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;

            lbSearchResults.Items.Clear();

            // Search by name only
            var results = eventHandler.SearchEvents(name).ToList();

            if (results.Any())
            {
                foreach (var ev in results)
                {
                    lbSearchResults.Items.Add($"{ev.Name} - {ev.Date:yyyy/MM/dd}");
                }
            }
            else
            {
                MessageBox.Show("No results found.", "Search Results");
            }

            // Update search history
            lbSearchHistory.Items.Clear();
            foreach (var query in eventHandler.GetSearchHistory())
            {
                lbSearchHistory.Items.Add(query);
            }
        }


        private void DisplayEventDetails(string selectedEvent)
        {
            if (string.IsNullOrWhiteSpace(selectedEvent)) return;

            string selectedEventName = selectedEvent.Split('-')[0].Trim();
            var ev = eventHandler.GetAllEvents().FirstOrDefault(e => e.Name == selectedEventName);

            if (ev != null)
            {
                MessageBox.Show($"Name: {ev.Name}\n" +
                                $"Category: {ev.Category}\n" +
                                $"Date: {ev.Date:MM/dd/yyyy}\n" +
                                $"Description: {ev.Description}", "Event Details");
            }
        }

        private void lbAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbAllEvents.SelectedItem?.ToString());
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbAnnouncements.SelectedItem?.ToString());
        }

        private void lbSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventDetails(lbSearchResults.SelectedItem?.ToString());
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {
            DisplayEvents();
        }
    }
}