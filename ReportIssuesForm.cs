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
    public partial class ReportIssuesForm : Form
    {
        // Generic list to store issues reported by the user
        private static List<Issues> reportedIssues = new List<Issues>();

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        // Method to handle file attachment
        private List<string> attachedFiles = new List<string>();

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFiles.Add(openFileDialog.FileName);
                    listBoxAttachments.Items.Add(openFileDialog.FileName);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect user input
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtbDescription.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Ensure that all fields are entered correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new issue instance
            Issues newIssue = new Issues(location, category, description, attachedFiles);

            // Add the issue to the list of reported issues
            reportedIssues.Add(newIssue);

            // Confirm submission
            MessageBox.Show("Successfully reported issue", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form for the next report
            ClearForm();
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            listBoxAttachments.Items.Clear();
            attachedFiles.Clear();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Return to main menu
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) // fixed the exit button that previously did not work
        {
            // Closes the application
            Application.Exit();
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            if (reportedIssues.Count == 0)
            {
                MessageBox.Show("There have been no issues reported yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string allIssues = "";
                foreach (var issue in reportedIssues)
                {
                    allIssues += issue.ToString() + "\n";
                }
                MessageBox.Show(allIssues, "Reported Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportIssuesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblAttachments_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
