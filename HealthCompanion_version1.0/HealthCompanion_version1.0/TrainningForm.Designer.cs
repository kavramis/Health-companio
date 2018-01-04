namespace HealthCompanion_version1._0
{
    partial class TrainningForm
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
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fitnessGoalsCmbBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramDurationDd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trainingTimeCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingDaysDd = new System.Windows.Forms.NumericUpDown();
            this.goalsTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDurationDd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingDaysDd)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.Location = new System.Drawing.Point(3, 15);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(70, 13);
            this.fitnessLabel.TabIndex = 0;
            this.fitnessLabel.Text = "Fitness Goals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Training Days";
            // 
            // fitnessGoalsCmbBox
            // 
            this.fitnessGoalsCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fitnessGoalsCmbBox.FormattingEnabled = true;
            this.fitnessGoalsCmbBox.Items.AddRange(new object[] {
            "Weight Loss",
            "Increase Muscles"});
            this.fitnessGoalsCmbBox.Location = new System.Drawing.Point(166, 8);
            this.fitnessGoalsCmbBox.Name = "fitnessGoalsCmbBox";
            this.fitnessGoalsCmbBox.Size = new System.Drawing.Size(154, 21);
            this.fitnessGoalsCmbBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProgramDurationDd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trainingTimeCmbBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TrainingDaysDd);
            this.panel1.Controls.Add(this.fitnessLabel);
            this.panel1.Controls.Add(this.fitnessGoalsCmbBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 488);
            this.panel1.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Calisthenics",
            "Gym Workout"});
            this.comboBox4.Location = new System.Drawing.Point(166, 249);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(154, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Home/Outdoors",
            "Gym"});
            this.comboBox3.Location = new System.Drawing.Point(166, 202);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Training Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Training Place";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Training Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "months";
            // 
            // ProgramDurationDd
            // 
            this.ProgramDurationDd.Location = new System.Drawing.Point(166, 154);
            this.ProgramDurationDd.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ProgramDurationDd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProgramDurationDd.Name = "ProgramDurationDd";
            this.ProgramDurationDd.Size = new System.Drawing.Size(154, 20);
            this.ProgramDurationDd.TabIndex = 7;
            this.ProgramDurationDd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Program Duration";
            // 
            // trainingTimeCmbBox
            // 
            this.trainingTimeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingTimeCmbBox.FormattingEnabled = true;
            this.trainingTimeCmbBox.Items.AddRange(new object[] {
            "20",
            "45",
            "90"});
            this.trainingTimeCmbBox.Location = new System.Drawing.Point(166, 102);
            this.trainingTimeCmbBox.Name = "trainingTimeCmbBox";
            this.trainingTimeCmbBox.Size = new System.Drawing.Size(154, 21);
            this.trainingTimeCmbBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training Time(Minutes)";
            // 
            // TrainingDaysDd
            // 
            this.TrainingDaysDd.Location = new System.Drawing.Point(166, 54);
            this.TrainingDaysDd.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TrainingDaysDd.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TrainingDaysDd.Name = "TrainingDaysDd";
            this.TrainingDaysDd.Size = new System.Drawing.Size(154, 20);
            this.TrainingDaysDd.TabIndex = 3;
            this.TrainingDaysDd.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // goalsTableAdapter1
            // 
            this.goalsTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // TrainningForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(479, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainningForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDurationDd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingDaysDd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fitnessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fitnessGoalsCmbBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox trainingTimeCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TrainingDaysDd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ProgramDurationDd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter goalsTableAdapter1;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
    }
}