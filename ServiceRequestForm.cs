using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10085201_PROG7312_POE
{
    public partial class ServiceRequestForm : Form
    {
        private AVLTree<ServiceRequest> avlTree = new AVLTree<ServiceRequest>();
        private List<ServiceRequest> allRequests = new List<ServiceRequest>();
        private Graph dependencyGraph = new Graph();
        private MinHeap<ServiceRequest> priorityQueue = new MinHeap<ServiceRequest>();
        private MST mstSolver = new MST();

        public ServiceRequestForm()
        {
            InitializeComponent();
            PopulateData();
            LoadListBox();

            btnRequests.Click += btnRequests_Click;
            pnlGraph.Paint += pnlGraph_Paint;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateData()
        {
            allRequests = new List<ServiceRequest>
            {
                new ServiceRequest("pPoZd7U5", "Walmer Heights", "Sanitation", "Blocked sewage systems", "Pending", "Moderate"),
                new ServiceRequest("6BVwkfzi", "Kabega Park", "Health", "Ambulance needed on the N2 near Kabega Park Primary", "In Progress", "Critical"),
                new ServiceRequest("QigXkvLf", "Lorraine", "Storm Water Drainage", "Storm water drains flooding", "Completed", "High"),
                new ServiceRequest("U9Yf45s2", "Hillside", "Housing", "Squatter camp in open field", "Pending", "Low"),
                new ServiceRequest("NhJf8hli", "Motherwell", "Roads", "Excessive potholes in main road", "In Progress", "Moderate"),
                new ServiceRequest("n3JDvqdK", "Gelvandale", "Water", "Water off for over 5 hours", "Pending", "High"),
                new ServiceRequest("tOqMqdmA", "Booysens Park", "Electricity", "Electricity off for 2 hours", "Completed", "Moderate"),
                new ServiceRequest("gqUvS2ud", "Salsoneville", "Weather", "Extreme flooding due to rain", "In Progress", "Critical"),
                new ServiceRequest("ij3Tdc0j", "Newton Park", "Safety", "Armed robbery in Hurd Street", "Pending", "High"),
                new ServiceRequest("m9rBUCLN", "Hunters Retreat", "Fire", "Bush on fire", "Completed", "Critical"),
                new ServiceRequest("nMeji0MJ", "Walmer Downs", "Other", "Road blocks near the dip due to waste", "In Progress", "Low"),
                new ServiceRequest("bra190fh", "Westering", "Sanitation", "Sewage leaking into residential area", "Pending", "Moderate"),
                new ServiceRequest("T86idBxq", "Bridgemead", "Health", "Ambulance needed on bridge due to accident", "In Progress", "Critical"),
                new ServiceRequest("ph6fXpEk", "Westering", "Storm Water Drainage", "Drains overflowing mildly", "Completed", "Low"),
                new ServiceRequest("gJU8j48p", "Malabar", "Housing", "Squatter camp near Malabar Town Hall", "Pending", "Low"),
                new ServiceRequest("xUMiocnG", "Malabar", "Roads", "Traffic at the intersection between Malabar and Westering", "In Progress", "Moderate"),
                new ServiceRequest("25851xLS", "Parkside", "Water", "Water pipe burst near Spar", "Completed", "High"),
                new ServiceRequest("533i3BQa", "Newton Park", "Electricity", "Electricity cables stolen", "Pending", "High"),
                new ServiceRequest("yUf4KEBV", "Overbaakens", "Weather", "Extreme rain and wind causing floods", "In Progress", "Critical"),
                new ServiceRequest("K97oPyL9", "Fairview", "Safety", "Break-in near Willow Road", "Completed", "High"),
                new ServiceRequest("i7OBXsV0", "Fairview", "Fire", "House fire near Fairview Flats", "Pending", "Critical"),
                new ServiceRequest("p4goP1qO", "Korsten", "Other", "Excessive waste on curbsides", "In Progress", "Low"),
            };

            // Initialize the dependency graph
            dependencyGraph = new Graph();

            foreach (var request in allRequests)
            {
                avlTree.Insert(request);        // Insert into AVL tree
                priorityQueue.Insert(request); // Insert into MinHeap
                dependencyGraph.AddVertex(request.ID);

                dependencyGraph.AddEdge("pPoZd7U5", "6BVwkfzi", 5);   // Example weight
                dependencyGraph.AddEdge("6BVwkfzi", "QigXkvLf", 3);
                dependencyGraph.AddEdge("QigXkvLf", "U9Yf45s2", 4);
                dependencyGraph.AddEdge("U9Yf45s2", "NhJf8hli", 2);
                dependencyGraph.AddEdge("NhJf8hli", "n3JDvqdK", 6);
                dependencyGraph.AddEdge("n3JDvqdK", "tOqMqdmA", 1);
                dependencyGraph.AddEdge("tOqMqdmA", "gqUvS2ud", 7);
                dependencyGraph.AddEdge("gqUvS2ud", "ij3Tdc0j", 3);
                dependencyGraph.AddEdge("ij3Tdc0j", "m9rBUCLN", 4);
                dependencyGraph.AddEdge("m9rBUCLN", "nMeji0MJ", 5);
                dependencyGraph.AddEdge("nMeji0MJ", "bra190fh", 8);
                dependencyGraph.AddEdge("bra190fh", "T86idBxq", 3);
                dependencyGraph.AddEdge("T86idBxq", "ph6fXpEk", 9);
                dependencyGraph.AddEdge("ph6fXpEk", "gJU8j48p", 2);
                dependencyGraph.AddEdge("gJU8j48p", "xUMiocnG", 4);
                dependencyGraph.AddEdge("xUMiocnG", "25851xLS", 3);
                dependencyGraph.AddEdge("25851xLS", "533i3BQa", 5);
                dependencyGraph.AddEdge("533i3BQa", "yUf4KEBV", 7);
                dependencyGraph.AddEdge("yUf4KEBV", "K97oPyL9", 6);
                dependencyGraph.AddEdge("K97oPyL9", "i7OBXsV0", 4);
                dependencyGraph.AddEdge("i7OBXsV0", "p4goP1qO", 3);
            }
        }

        private void LoadListBox()
        {
            lbServiceRequests.Items.Clear();

            foreach (var request in allRequests)
            {
                lbServiceRequests.Items.Add($"{request.ID} in {request.Location} (Priority: {request.Priority}, Status: {request.Status})");
            }
        }

        private void lbServiceRequests_DoubleClick(object sender, EventArgs e)
        {

            if (lbServiceRequests.SelectedItem != null)
            {
                var selectedText = lbServiceRequests.SelectedItem.ToString();
                var id = selectedText.Split('-')[0].Trim();
                var request = allRequests.FirstOrDefault();

                if (request != null)
                {
                    ShowRequestDetails(request);
                    //var relatedRequests = new List<string>();
                    //DFS(id, new HashSet<string>(), relatedRequests);

                    //MessageBox.Show($"Related Requests: {string.Join(", ", relatedRequests)}", "Related Requests");
                }
            }
        }

        private void btnShowMST_Click(object sender, EventArgs e)
        {
            // Generate the MST
            var mstEdges = dependencyGraph.GenerateMST();

            // Display MST in ListBox
            lbMST.Items.Clear();
            foreach (var edge in mstEdges)
            {
                lbMST.Items.Add($"{edge.From} → {edge.To} (Weight: {edge.Weight})");
            }

            if (dependencyGraph != null)
            {
                // Refresh the panel to trigger the Paint event
                pnlGraph.Invalidate();
            }
            else
            {
                MessageBox.Show("The graph is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            // Get MST edges
            var mstEdges = dependencyGraph.GenerateMST();

            // Set up drawing
            Graphics g = e.Graphics;
            var nodePositions = new Dictionary<string, Point>();

            int radius = 20;
            int panelWidth = pnlGraph.Width;
            int panelHeight = pnlGraph.Height;

            // Place nodes in a circular layout
            for (int i = 0; i < allRequests.Count; i++)
            {
                double angle = 2 * Math.PI * i / allRequests.Count;
                int x = (int)(panelWidth / 2 + 200 * Math.Cos(angle));
                int y = (int)(panelHeight / 2 + 200 * Math.Sin(angle));
                nodePositions[allRequests[i].ID] = new Point(x, y);
            }

            // Draw edges
            foreach (var edge in mstEdges)
            {
                var fromPos = nodePositions[edge.From];
                var toPos = nodePositions[edge.To];
                g.DrawLine(Pens.Black, fromPos, toPos);

                var midPoint = new Point((fromPos.X + toPos.X) / 2, (fromPos.Y + toPos.Y) / 2);
                g.DrawString(edge.Weight.ToString(), DefaultFont, Brushes.Red, midPoint);
            }

            // Draw nodes with status
            foreach (var node in nodePositions)
            {
                var serviceRequest = allRequests.First(r => r.ID == node.Key);
                var pos = node.Value;

                g.FillEllipse(Brushes.LightBlue, pos.X - radius, pos.Y - radius, radius * 2, radius * 2);
                g.DrawEllipse(Pens.Black, pos.X - radius, pos.Y - radius, radius * 2, radius * 2);
                g.DrawString(serviceRequest.Status, DefaultFont, Brushes.Black, pos.X - radius / 2, pos.Y - radius / 2);
            }
        }


    private void ShowRequestDetails(ServiceRequest request)
        {
            string details = $"ID: {request.ID}\n" +
                             $"Location: {request.Location}\n" +
                             $"Category: {request.Category}\n" +
                             $"Description: {request.Description}\n" +
                             $"Status: {request.Status}\n" +
                             $"Priority: {request.Priority}";

            MessageBox.Show(details, "Service Request Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DFS(string start, HashSet<string> visited, List<string> result)
        {
            if (!visited.Contains(start))
            {
                visited.Add(start);
                result.Add(start);

                foreach (var neighbor in dependencyGraph.GetNeighbors(start))
                {
                    DFS(neighbor, visited, result);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            PopulateData();
        }
    }
}
