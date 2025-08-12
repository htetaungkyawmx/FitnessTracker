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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Gender = cmbGender.Text,
                DateOfBirth = dtpDOB.Value.Date,
                Weight = (int)nudWeight.Value,
                Height = (int)nudHeight.Value,
                PhoneNo = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Role = cmbRole.Text,
            };

            if (IsValidInput(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                try
                {
                    var userAdapter = new dbFitness_TrackerDsTableAdapters.UsersTableAdapter();
                    userAdapter.InsertUser(
                        newUser.Username,
                        newUser.Password,
                        newUser.Gender,
                        newUser.DateOfBirth.ToString(),
                        newUser.Weight,
                        newUser.Height,
                        newUser.PhoneNo,
                        newUser.Address,
                        newUser.Role,
                        DateTime.Now
                    );

                    MessageBox.Show("Login SuccessFull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Fail" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
