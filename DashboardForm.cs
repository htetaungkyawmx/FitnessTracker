using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class DashboardForm : Form
    {
        private int userId;
        dbFitness_TrackerDsTableAdapters.ActivityRecordTableAdapter activityRecordAdapter = new
           dbFitness_TrackerDsTableAdapters.ActivityRecordTableAdapter();
        dbFitness_TrackerDsTableAdapters.ActivityTypesTableAdapter activityAdapter = new dbFitness_TrackerDsTableAdapters.ActivityTypesTableAdapter();
        dbFitness_TrackerDsTableAdapters.GoalsTableAdapter goalsAdapter = new dbFitness_TrackerDsTableAdapters.GoalsTableAdapter();
        
        public DashboardForm(int userId, string userName)
        {
            InitializeComponent();
            this.userId = userId;
            lblWelcome.Text = "Welcome to " + userName;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadActivities();
            LoadUserGoal();
            UpdateCaloriesInfo();
        }

        // Load activity types from the database into the combo box.
        private void LoadActivities()
        {
            dbFitness_TrackerDs.ActivityTypesDataTable dt = new
            dbFitness_TrackerDs.ActivityTypesDataTable();
            activityAdapter.Fill(dt);

            cmbActivity.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                cmbActivity.Items.Add(new ActivityItem
                {
                    ActivityTypeID = Convert.ToInt32(row["ActivityTypeID"]),
                    Name = row["Name"].ToString()
                });
            }
            if (cmbActivity.Items.Count > 0)
                cmbActivity.SelectedIndex = 0;
        }

        // Handles activity selection change in the combo box.
        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cmbActivity.SelectedItem as ActivityItem;
            if (selected != null)
            {
                SetMetricLabels(selected.Name);
            }
        }

        //Calcuatae Calories By Activity 
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            var selected = cmbActivity.SelectedItem as ActivityItem;
            if (selected == null)
            {
                MessageBox.Show("Please select an activity.", "DashBoard Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!float.TryParse(txtMetric1.Text, out float metric1) ||
               !float.TryParse(txtMetric2.Text, out float metric2) ||
               !float.TryParse(txtMetric3.Text, out float metric3))
            {
                MessageBox.Show("Please enter valid numbers for all metrics.", "DashBoard Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            float calories = CalculateCalories(selected.Name, metric1, metric2, metric3);
            activityRecordAdapter.InsertQuery(
                  userId,                    
                  selected.ActivityTypeID,   
                  metric1,                   
                  metric2,                  
                  metric3,                   
                  calories,
                   DateTime.Now              
              );

            MessageBox.Show($"Activity added. Calories burned: {calories:F2}", "DashBoard Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
            UpdateCaloriesInfo();
        }


        //Set Goals By Custom
        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGoalCalories.Text, out int goal) || goal <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for goal.", "DashBoard Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var goalsTable = goalsAdapter.GetDataByUserID(userId);
            if (goalsTable.Rows.Count == 0)
            {
                goalsAdapter.Insert(userId, goal, DateTime.Now);
            }
            else
            {
                var existingRow = goalsTable[0];
                existingRow.TargetCalories = goal;
                existingRow.CreatedAt = DateTime.Now;
                goalsAdapter.Update(existingRow);
            }
            MessageBox.Show("Goal saved.", "DashBoard Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateCaloriesInfo();
        }

        //Report By User Activity
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(userId);
            reportForm.StartPosition = FormStartPosition.CenterParent;
            reportForm.ShowDialog(this);
        }

        // Set metric labels based on the selected activity name.
        private void SetMetricLabels(string activityName)
        {
            switch (activityName)
            {
                case "Walking":
                    lblMetric1.Text = "Steps:";
                    lblMetric2.Text = "Distance (km):";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                case "Swimming":
                    lblMetric1.Text = "Time Taken (min):";
                    lblMetric2.Text = "Number of Laps:";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                case "Cycling":
                    lblMetric1.Text = "Distance (km):";
                    lblMetric2.Text = "Time Taken (min):";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                case "Running":
                    lblMetric1.Text = "Distance (km):";
                    lblMetric2.Text = "Time Taken (min):";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                case "Yoga":
                    lblMetric1.Text = "Time Taken (min):";
                    lblMetric2.Text = "Calories per Minute:";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                case "Jump Rope":
                    lblMetric1.Text = "Number of Jumps:";
                    lblMetric2.Text = "Time Taken (min):";
                    lblMetric3.Text = "Average Heart Rate:";
                    break;
                default:
                    lblMetric1.Text = "Metric 1:";
                    lblMetric2.Text = "Metric 2:";
                    lblMetric3.Text = "Metric 3:";
                    break;
            }
        }
        
        //Load User Goal in Textbox
        private void LoadUserGoal()
        {
            var latestGoal = goalsAdapter.GetLatestGoalByUserID(userId);
            if (latestGoal.Rows.Count > 0)
            {
                var goalRow = latestGoal[0];
                txtGoalCalories.Text = goalRow.TargetCalories.ToString();
            }
        }

        //Calculate Calories
        private float CalculateCalories(string activityName, float m1, float m2, float m3)
        {
            switch (activityName)
            {
                case "Walking":
                    return m1 * 0.04f + m2 * 30f + m3 * 0.2f;

                case "Swimming":
                    return m1 * 8f + m2 * 5f + m3 * 0.3f;

                case "Cycling":
                    return m1 * 25f + m2 * 6f + m3 * 0.2f;

                case "Running":
                    return m1 * 50f + m2 * 7f + m3 * 0.3f;

                case "Yoga":
                    return m1 * m2 + m3 * 0.1f;

                case "Jump Rope":
                    return m1 * 0.1f + m2 * 12f + m3 * 0.25f;
                default:
                    return 0;
            }
        }

        //Update Calories
        private void UpdateCaloriesInfo()
        {
            float totalCalories = 0;
            int targetCalories = 0;
            var result = activityRecordAdapter.GetTotalCaloriesByUserID(userId);
            totalCalories = result != null ? Convert.ToSingle(result) : 0;
            var goalTable = goalsAdapter.GetLatestGoalByUserID(userId);
            if (goalTable.Rows.Count > 0)
            {
                targetCalories = goalTable[0].TargetCalories;
            }

            lblTotalCalories.Text = $"Total Calories Burned: {totalCalories:F2}";

            if (targetCalories == 0)
            {
                lblGoalStatus.Text = "Goal not set.";
            }
            else if (totalCalories >= targetCalories)
            {
                lblGoalStatus.Text = "Goal Achieved! 🎉";
            }
            else
            {
                lblGoalStatus.Text = $"Keep going! {targetCalories - totalCalories:F2} calories left.";
            }
        }

        private void ClearInputs()
        {
            txtMetric1.Clear();
            txtMetric2.Clear();
            txtMetric3.Clear();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
    class ActivityItem
    {
        public int ActivityTypeID { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
