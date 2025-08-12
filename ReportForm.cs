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
    public partial class ReportForm : Form
    {
        private int userId;
        public ReportForm(int userID)
        {
            InitializeComponent();
            this.userId = userID;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadActivities();
        }

        private void LoadActivities()
        {
            var activityViewAdapter = new dbFitness_TrackerDsTableAdapters.vw_UserActivitiesTableAdapter();
            var activityData = activityViewAdapter.GetActivitiesByUserID(userId);
            DataTable dt = activityData;

            dt.Columns.Add("No", typeof(int));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["No"] = i + 1;
            }
            dt.Columns["No"].SetOrdinal(0);
            dgvActivities.DataSource = dt;

            var activityRecordAdapter = new dbFitness_TrackerDsTableAdapters.ActivityRecordTableAdapter();
            var totalCaloriesResult = activityRecordAdapter.GetTotalCaloriesByUserID(userId);
            float totalCalories = totalCaloriesResult != null ? Convert.ToSingle(totalCaloriesResult) : 0;

            var goalsAdapter = new dbFitness_TrackerDsTableAdapters.GoalsTableAdapter();
            var goalTable = goalsAdapter.GetLatestGoalByUserID(userId);
            int targetCalories = 0;
            if (goalTable.Rows.Count > 0)
            {
                targetCalories = goalTable[0].TargetCalories;
            }

            if (targetCalories == 0)
            {
                lblSummary.Text = $"Total Calories Burned: {totalCalories:F2}. Goal not set.";
            }
            else if (totalCalories >= targetCalories)
            {
                lblSummary.Text = $"Total Calories Burned: {totalCalories:F2}. Goal Achieved!";
            }
            else
            {
                lblSummary.Text = $"Total Calories Burned: {totalCalories:F2}. {targetCalories - totalCalories:F2} calories left to goal.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
