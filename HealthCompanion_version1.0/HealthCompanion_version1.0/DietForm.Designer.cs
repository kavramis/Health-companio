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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DietForm));
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
            this.goalsTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.quickTipTxtBox = new System.Windows.Forms.RichTextBox();
            this.dietPlanTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.DietPlanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userDietPlanTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserDietPlanTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.finalFormDrive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BmrLabel
            // 
            this.BmrLabel.BackColor = System.Drawing.Color.Transparent;
            this.BmrLabel.ForeColor = System.Drawing.Color.Transparent;
            this.BmrLabel.Location = new System.Drawing.Point(298, 1);
            this.BmrLabel.Name = "BmrLabel";
            this.BmrLabel.Size = new System.Drawing.Size(69, 18);
            this.BmrLabel.TabIndex = 0;
            this.BmrLabel.Text = "Your Bmr is:";
            // 
            // BmrValue
            // 
            this.BmrValue.BackColor = System.Drawing.Color.Transparent;
            this.BmrValue.ForeColor = System.Drawing.Color.White;
            this.BmrValue.Location = new System.Drawing.Point(412, 1);
            this.BmrValue.Name = "BmrValue";
            this.BmrValue.Size = new System.Drawing.Size(69, 18);
            this.BmrValue.TabIndex = 1;
            this.BmrValue.Text = "0";
            // 
            // CaloriesPD
            // 
            this.CaloriesPD.BackColor = System.Drawing.Color.Transparent;
            this.CaloriesPD.ForeColor = System.Drawing.Color.White;
            this.CaloriesPD.Location = new System.Drawing.Point(477, 1);
            this.CaloriesPD.Name = "CaloriesPD";
            this.CaloriesPD.Size = new System.Drawing.Size(116, 18);
            this.CaloriesPD.TabIndex = 2;
            this.CaloriesPD.Text = "Calories Per Day";
            // 
            // FitGoal
            // 
            this.FitGoal.AutoSize = true;
            this.FitGoal.BackColor = System.Drawing.Color.Transparent;
            this.FitGoal.ForeColor = System.Drawing.Color.White;
            this.FitGoal.Location = new System.Drawing.Point(301, 42);
            this.FitGoal.Name = "FitGoal";
            this.FitGoal.Size = new System.Drawing.Size(87, 17);
            this.FitGoal.TabIndex = 3;
            this.FitGoal.Text = "Fitness Goal";
            // 
            // fitnessGoalTxtBox
            // 
            this.fitnessGoalTxtBox.Enabled = false;
            this.fitnessGoalTxtBox.Location = new System.Drawing.Point(455, 39);
            this.fitnessGoalTxtBox.Name = "fitnessGoalTxtBox";
            this.fitnessGoalTxtBox.Size = new System.Drawing.Size(138, 22);
            this.fitnessGoalTxtBox.TabIndex = 4;
            // 
            // Tip
            // 
            this.Tip.BackColor = System.Drawing.Color.Transparent;
            this.Tip.ForeColor = System.Drawing.Color.White;
            this.Tip.Location = new System.Drawing.Point(301, 100);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(75, 17);
            this.Tip.TabIndex = 6;
            this.Tip.Text = "Quick Tip:";
            // 
            // GuideLine
            // 
            this.GuideLine.Location = new System.Drawing.Point(303, 495);
            this.GuideLine.Name = "GuideLine";
            this.GuideLine.Size = new System.Drawing.Size(629, 22);
            this.GuideLine.TabIndex = 7;
            this.GuideLine.Text = "You can view the details of your selected,\r\nyou can also swap meals based on your" +
    " needs and  preferences\r\nin in your profile tab";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietPlanIDDataGridViewTextBoxColumn,
            this.mealsPerDayDataGridViewTextBoxColumn,
            this.dietPlanNameDataGridViewTextBoxColumn,
            this.dietTypeDataGridViewTextBoxColumn,
            this.dailyCaloriesDataGridViewTextBoxColumn,
            this.tipsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dietPlanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(303, 523);
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
            this.quickTipTxtBox.Location = new System.Drawing.Point(383, 77);
            this.quickTipTxtBox.Name = "quickTipTxtBox";
            this.quickTipTxtBox.Size = new System.Drawing.Size(210, 61);
            this.quickTipTxtBox.TabIndex = 9;
            this.quickTipTxtBox.Text = "";
            // 
            // dietPlanTableAdapter
            // 
            this.dietPlanTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(952, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert my diet program";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(947, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 75);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select a program from Table and click Insert";
            // 
            // userDietPlanTableAdapter1
            // 
            this.userDietPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 687);
            this.panel1.TabIndex = 23;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkRed;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 590);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(212, 94);
            this.button9.TabIndex = 9;
            this.button9.Text = "Exit  ";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(0, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 46);
            this.button7.TabIndex = 7;
            this.button7.Text = "My profile";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(0, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Progress    ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Goals          ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Personal Data  ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(-3, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Workout      ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Diet Form   ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Maroon;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(0, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 46);
            this.button8.TabIndex = 1;
            this.button8.Text = "Switch User";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // finalFormDrive
            // 
            this.finalFormDrive.BackColor = System.Drawing.Color.Maroon;
            this.finalFormDrive.Enabled = false;
            this.finalFormDrive.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalFormDrive.ForeColor = System.Drawing.Color.White;
            this.finalFormDrive.Location = new System.Drawing.Point(952, 569);
            this.finalFormDrive.Name = "finalFormDrive";
            this.finalFormDrive.Size = new System.Drawing.Size(185, 40);
            this.finalFormDrive.TabIndex = 24;
            this.finalFormDrive.Text = "Register Done";
            this.finalFormDrive.UseVisualStyleBackColor = false;
            this.finalFormDrive.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 138);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trajan Pro 3", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "C";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nueva Std Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Health Companion";
            // 
            // DietForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1163, 687);
            this.Controls.Add(this.finalFormDrive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quickTipTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuideLine);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.fitnessGoalTxtBox);
            this.Controls.Add(this.FitGoal);
            this.Controls.Add(this.CaloriesPD);
            this.Controls.Add(this.BmrValue);
            this.Controls.Add(this.BmrLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DietForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietForm";
            this.Load += new System.EventHandler(this.DietForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private FitnessDatabaseDataSetTableAdapters.UserDietPlanTableAdapter userDietPlanTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button finalFormDrive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}