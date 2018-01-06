namespace HealthCompanion_version1._0
{
    partial class DietForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BmrLabel = new System.Windows.Forms.Label();
            this.BmrValue = new System.Windows.Forms.Label();
            this.CaloriesPD = new System.Windows.Forms.Label();
            this.FitGoal = new System.Windows.Forms.Label();
            this.fitnessGoalTxtBox = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.Label();
            this.GuideLine = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dietPlanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealsPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCaloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDatabaseDataSet = new HealthCompanion_version1._0.FitnessDatabaseDataSet();
            this.dietPlanTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.DietPlanTableAdapter();
            this.goalsTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.quickTipTxtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 451);
            this.panel1.TabIndex = 0;
            // 
            // BmrLabel
            // 
            this.BmrLabel.Location = new System.Drawing.Point(93, 9);
            this.BmrLabel.Name = "BmrLabel";
            this.BmrLabel.Size = new System.Drawing.Size(69, 18);
            this.BmrLabel.TabIndex = 0;
            this.BmrLabel.Text = "Your Bmr is:";
            // 
            // BmrValue
            // 
            this.BmrValue.Location = new System.Drawing.Point(207, 9);
            this.BmrValue.Name = "BmrValue";
            this.BmrValue.Size = new System.Drawing.Size(69, 18);
            this.BmrValue.TabIndex = 1;
            this.BmrValue.Text = "0";
            // 
            // CaloriesPD
            // 
            this.CaloriesPD.Location = new System.Drawing.Point(272, 9);
            this.CaloriesPD.Name = "CaloriesPD";
            this.CaloriesPD.Size = new System.Drawing.Size(116, 18);
            this.CaloriesPD.TabIndex = 2;
            this.CaloriesPD.Text = "Calories Per Day";
            // 
            // FitGoal
            // 
            this.FitGoal.AutoSize = true;
            this.FitGoal.Location = new System.Drawing.Point(96, 60);
            this.FitGoal.Name = "FitGoal";
            this.FitGoal.Size = new System.Drawing.Size(87, 17);
            this.FitGoal.TabIndex = 3;
            this.FitGoal.Text = "Fitness Goal";
            // 
            // fitnessGoalTxtBox
            // 
            this.fitnessGoalTxtBox.Enabled = false;
            this.fitnessGoalTxtBox.Location = new System.Drawing.Point(177, 57);
            this.fitnessGoalTxtBox.Name = "fitnessGoalTxtBox";
            this.fitnessGoalTxtBox.Size = new System.Drawing.Size(138, 22);
            this.fitnessGoalTxtBox.TabIndex = 4;
            // 
            // Tip
            // 
            this.Tip.Location = new System.Drawing.Point(96, 108);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(75, 17);
            this.Tip.TabIndex = 6;
            this.Tip.Text = "Quick Tip:";
            // 
            // GuideLine
            // 
            this.GuideLine.Location = new System.Drawing.Point(82, 334);
            this.GuideLine.Name = "GuideLine";
            this.GuideLine.Size = new System.Drawing.Size(629, 22);
            this.GuideLine.TabIndex = 7;
            this.GuideLine.Text = "You can view the details of your selected,\r\nyou can also swap meals based on your" +
    " needs and  preferences\r\nin in your profile tab";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietPlanIDDataGridViewTextBoxColumn,
            this.mealsPerDayDataGridViewTextBoxColumn,
            this.dietPlanNameDataGridViewTextBoxColumn,
            this.dietTypeDataGridViewTextBoxColumn,
            this.dailyCaloriesDataGridViewTextBoxColumn,
            this.tipsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dietPlanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // dietPlanIDDataGridViewTextBoxColumn
            // 
            this.dietPlanIDDataGridViewTextBoxColumn.DataPropertyName = "DietPlanID";
            this.dietPlanIDDataGridViewTextBoxColumn.HeaderText = "DietPlanID";
            this.dietPlanIDDataGridViewTextBoxColumn.Name = "dietPlanIDDataGridViewTextBoxColumn";
            // 
            // mealsPerDayDataGridViewTextBoxColumn
            // 
            this.mealsPerDayDataGridViewTextBoxColumn.DataPropertyName = "MealsPerDay";
            this.mealsPerDayDataGridViewTextBoxColumn.HeaderText = "MealsPerDay";
            this.mealsPerDayDataGridViewTextBoxColumn.Name = "mealsPerDayDataGridViewTextBoxColumn";
            // 
            // dietPlanNameDataGridViewTextBoxColumn
            // 
            this.dietPlanNameDataGridViewTextBoxColumn.DataPropertyName = "DietPlanName";
            this.dietPlanNameDataGridViewTextBoxColumn.HeaderText = "DietPlanName";
            this.dietPlanNameDataGridViewTextBoxColumn.Name = "dietPlanNameDataGridViewTextBoxColumn";
            // 
            // dietTypeDataGridViewTextBoxColumn
            // 
            this.dietTypeDataGridViewTextBoxColumn.DataPropertyName = "DietType";
            this.dietTypeDataGridViewTextBoxColumn.HeaderText = "DietType";
            this.dietTypeDataGridViewTextBoxColumn.Name = "dietTypeDataGridViewTextBoxColumn";
            // 
            // dailyCaloriesDataGridViewTextBoxColumn
            // 
            this.dailyCaloriesDataGridViewTextBoxColumn.DataPropertyName = "Daily Calories";
            this.dailyCaloriesDataGridViewTextBoxColumn.HeaderText = "Daily Calories";
            this.dailyCaloriesDataGridViewTextBoxColumn.Name = "dailyCaloriesDataGridViewTextBoxColumn";
            // 
            // tipsDataGridViewTextBoxColumn
            // 
            this.tipsDataGridViewTextBoxColumn.DataPropertyName = "Tips";
            this.tipsDataGridViewTextBoxColumn.HeaderText = "Tips";
            this.tipsDataGridViewTextBoxColumn.Name = "tipsDataGridViewTextBoxColumn";
            // 
            // dietPlanBindingSource
            // 
            this.dietPlanBindingSource.DataMember = "DietPlan";
            this.dietPlanBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // fitnessDatabaseDataSet
            // 
            this.fitnessDatabaseDataSet.DataSetName = "FitnessDatabaseDataSet";
            this.fitnessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietPlanTableAdapter
            // 
            this.dietPlanTableAdapter.ClearBeforeFill = true;
            // 
            // goalsTableAdapter1
            // 
            this.goalsTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // quickTipTxtBox
            // 
            this.quickTipTxtBox.Enabled = false;
            this.quickTipTxtBox.Location = new System.Drawing.Point(178, 108);
            this.quickTipTxtBox.Name = "quickTipTxtBox";
            this.quickTipTxtBox.Size = new System.Drawing.Size(210, 48);
            this.quickTipTxtBox.TabIndex = 9;
            this.quickTipTxtBox.Text = "";
            // 
            // DietForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(849, 454);
            this.Controls.Add(this.quickTipTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuideLine);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.fitnessGoalTxtBox);
            this.Controls.Add(this.FitGoal);
            this.Controls.Add(this.CaloriesPD);
            this.Controls.Add(this.BmrValue);
            this.Controls.Add(this.BmrLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DietForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietForm";
            this.Load += new System.EventHandler(this.DietForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BmrLabel;
        private System.Windows.Forms.Label BmrValue;
        private System.Windows.Forms.Label CaloriesPD;
        private System.Windows.Forms.Label FitGoal;
        private System.Windows.Forms.TextBox fitnessGoalTxtBox;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.TextBox GuideLine;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FitnessDatabaseDataSet fitnessDatabaseDataSet;
        private System.Windows.Forms.BindingSource dietPlanBindingSource;
        private FitnessDatabaseDataSetTableAdapters.DietPlanTableAdapter dietPlanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietPlanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealsPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietPlanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCaloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipsDataGridViewTextBoxColumn;
        private FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter goalsTableAdapter1;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.RichTextBox quickTipTxtBox;
    }
}