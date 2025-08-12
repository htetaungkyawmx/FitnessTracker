using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        dbFitness_TrackerDsTableAdapters.UsersTableAdapter usersAdapter = new dbFitness_TrackerDsTableAdapters.UsersTableAdapter();
        int failedAttempts = 0;
        const int maxFailedAttempts = 3;

        public int UserId { get; internal set; }
        public User LoggedInUser { get; internal set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, userPassword;
            int userID;
            userName = txtName.Text;
            userPassword = txtPassword.Text;

            if (!IsValidInput(userName, userPassword))
            {
                failedAttempts++;
                if (failedAttempts >= maxFailedAttempts)
                {
                    MessageBox.Show("Too many failed attempts. Application will close.", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else {
                var userData = usersAdapter.CheckUserData(userName, userPassword);
                if (userData.Rows.Count > 0)
                {
                    userName = userData.Rows[0][1].ToString();
                    userID = int.Parse(userData.Rows[0][0].ToString());
                    MessageBox.Show("Login Successful", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DashboardForm dbForm = new DashboardForm(userID, userName);
                    dbForm.StartPosition = FormStartPosition.CenterParent;
                    dbForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Login UserName and Password is worng", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsValidInput(string username, string password)
        {
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username must contain only letters and numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Length != 12 || !Regex.IsMatch(password, @"[a-z]") || !Regex.IsMatch(password, @"[A-Z]"))
            {
                MessageBox.Show("Password must be 12 characters long, with at least one uppercase and one lowercase letter.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerF = new RegisterForm();
            registerF.StartPosition = FormStartPosition.CenterParent;  
            registerF.ShowDialog(this);
        }

        /*private void btbCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }*/

        private void btbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
