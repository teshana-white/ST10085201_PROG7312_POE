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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Opens the Report Issues Form so that user may record an issue on the application 
        private void btnReportIssues_Click_1(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide(); // Hides the main form
        }

        // Opens the Local Events and Announcements Form so that user view events and announcements
        private void btnLocalEvents_Click_1(object sender, EventArgs e)
        {
            LocalEventsForm eventsAndAnnouncementsForm = new LocalEventsForm();
            eventsAndAnnouncementsForm.Show();
            this.Hide(); // Hides the main form
        }

        // Opens the Service Request Form so that user may view requested services, graphs, etc on the application 
        private void btnServiceStatus_Click_1(object sender, EventArgs e)
        {
            ServiceRequestForm serviceRequestForm = new ServiceRequestForm();
            serviceRequestForm.Show();
            this.Hide(); // Hides the main form
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e) // fixed the exit button that previously did not work
        {
            // Closes the application
            Application.Exit();
        }

        private void MainMenuForm_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
