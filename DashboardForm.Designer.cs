
namespace FitnessTracker
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txtGoalCalories = new System.Windows.Forms.TextBox();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblGoalStatus = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(29, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(146, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cmbActivity.Location = new System.Drawing.Point(38, 29);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(318, 28);
            this.cmbActivity.TabIndex = 1;
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblMetric1.Location = new System.Drawing.Point(35, 76);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(74, 19);
            this.lblMetric1.TabIndex = 2;
            this.lblMetric1.Text = "Metric 1:";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(214, 66);
            this.txtMetric1.Multiline = true;
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(136, 27);
            this.txtMetric1.TabIndex = 3;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblMetric2.Location = new System.Drawing.Point(35, 116);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(74, 19);
            this.lblMetric2.TabIndex = 4;
            this.lblMetric2.Text = "Metric 2:";
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(214, 113);
            this.txtMetric2.Multiline = true;
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(136, 27);
            this.txtMetric2.TabIndex = 5;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblMetric3.Location = new System.Drawing.Point(35, 156);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(74, 19);
            this.lblMetric3.TabIndex = 6;
            this.lblMetric3.Text = "Metric 3:";
            // 
            // txtMetric3
            // 
            this.txtMetric3.Location = new System.Drawing.Point(214, 153);
            this.txtMetric3.Multiline = true;
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(136, 27);
            this.txtMetric3.TabIndex = 7;
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddActivity.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnAddActivity.Location = new System.Drawing.Point(92, 205);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(200, 38);
            this.btnAddActivity.TabIndex = 8;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblGoal.Location = new System.Drawing.Point(6, 37);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(130, 19);
            this.lblGoal.TabIndex = 9;
            this.lblGoal.Text = "Set Goal Calories";
            // 
            // txtGoalCalories
            // 
            this.txtGoalCalories.Location = new System.Drawing.Point(158, 36);
            this.txtGoalCalories.Multiline = true;
            this.txtGoalCalories.Name = "txtGoalCalories";
            this.txtGoalCalories.Size = new System.Drawing.Size(154, 27);
            this.txtGoalCalories.TabIndex = 10;
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetGoal.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnSetGoal.Location = new System.Drawing.Point(206, 69);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(100, 33);
            this.btnSetGoal.TabIndex = 11;
            this.btnSetGoal.Text = "Save Goal";
            this.btnSetGoal.UseVisualStyleBackColor = false;
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTotalCalories.Location = new System.Drawing.Point(6, 21);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(176, 19);
            this.lblTotalCalories.TabIndex = 12;
            this.lblTotalCalories.Text = "Total Calories Burned: 0";
            // 
            // lblGoalStatus
            // 
            this.lblGoalStatus.AutoSize = true;
            this.lblGoalStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblGoalStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblGoalStatus.Location = new System.Drawing.Point(6, 53);
            this.lblGoalStatus.Name = "lblGoalStatus";
            this.lblGoalStatus.Size = new System.Drawing.Size(96, 19);
            this.lblGoalStatus.TabIndex = 13;
            this.lblGoalStatus.Text = "Goal not set.";
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowReport.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btnShowReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowReport.Location = new System.Drawing.Point(156, 74);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(150, 38);
            this.btnShowReport.TabIndex = 14;
            this.btnShowReport.Text = "ShowReport";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbActivity);
            this.groupBox1.Controls.Add(this.lblMetric1);
            this.groupBox1.Controls.Add(this.btnAddActivity);
            this.groupBox1.Controls.Add(this.txtMetric1);
            this.groupBox1.Controls.Add(this.txtMetric3);
            this.groupBox1.Controls.Add(this.lblMetric2);
            this.groupBox1.Controls.Add(this.lblMetric3);
            this.groupBox1.Controls.Add(this.txtMetric2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 261);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGoal);
            this.groupBox2.Controls.Add(this.txtGoalCalories);
            this.groupBox2.Controls.Add(this.btnSetGoal);
            this.groupBox2.Location = new System.Drawing.Point(510, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 102);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SetGoal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowReport);
            this.groupBox3.Controls.Add(this.lblTotalCalories);
            this.groupBox3.Controls.Add(this.lblGoalStatus);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(510, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 121);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // DashboardForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 365);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DashboardForm";
            this.Text = "Fitness Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.TextBox txtGoalCalories;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblGoalStatus;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}