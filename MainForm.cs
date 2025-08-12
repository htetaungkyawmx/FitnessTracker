using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class MainForm : Form
    {
        private int? loggedInUserId = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (LoginForm login = new LoginForm())
            {
                login.StartPosition = FormStartPosition.CenterParent;
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    loggedInUserId = login.UserId;
                    using (DashboardForm dashboard = new DashboardForm(login.UserId, login.LoggedInUser.Username))
                    {
                        dashboard.StartPosition = FormStartPosition.CenterParent;
                        dashboard.ShowDialog(this);
                    }
                }
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RegisterForm register = new RegisterForm())
            {
                register.StartPosition = FormStartPosition.CenterParent;
                register.ShowDialog(this);
            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loggedInUserId.HasValue)
            {
                using (ReportForm reportForm = new ReportForm(loggedInUserId.Value))
                {
                    reportForm.StartPosition = FormStartPosition.CenterParent;
                    reportForm.ShowDialog(this);
                }
            }
            else
            {
                 MessageBox.Show("Please log in to view the report.", "Login Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                using (LoginForm login = new LoginForm())
                {
                    login.StartPosition = FormStartPosition.CenterParent;
                    if (login.ShowDialog(this) == DialogResult.OK)
                    {
                        loggedInUserId = login.UserId;
                        using (ReportForm reportForm = new ReportForm(loggedInUserId.Value))
                        {
                            reportForm.StartPosition = FormStartPosition.CenterParent;
                            reportForm.ShowDialog(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login is required to access reports.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
