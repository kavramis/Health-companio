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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainningForm));
            this.fitnessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fitnessGoalsCmbBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramDurationDd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trainingTimeCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingDaysDd = new System.Windows.Forms.NumericUpDown();
            this.goalsTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDurationDd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingDaysDd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnessLabel
            // 
            this.fitnessLabel.AutoSize = true;
            this.fitnessLabel.ForeColor = System.Drawing.Color.White;
            this.fitnessLabel.Location = new System.Drawing.Point(52, 52);
            this.fitnessLabel.Name = "fitnessLabel";
            this.fitnessLabel.Size = new System.Drawing.Size(94, 17);
            this.fitnessLabel.TabIndex = 0;
            this.fitnessLabel.Text = "Fitness Goals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
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
            this.fitnessGoalsCmbBox.Location = new System.Drawing.Point(207, 49);
            this.fitnessGoalsCmbBox.Name = "fitnessGoalsCmbBox";
            this.fitnessGoalsCmbBox.Size = new System.Drawing.Size(154, 24);
            this.fitnessGoalsCmbBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(146, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Training Program";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "months";
            // 
            // ProgramDurationDd
            // 
            this.ProgramDurationDd.Location = new System.Drawing.Point(207, 195);
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
            this.ProgramDurationDd.Size = new System.Drawing.Size(154, 22);
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
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
            this.trainingTimeCmbBox.Location = new System.Drawing.Point(207, 143);
            this.trainingTimeCmbBox.Name = "trainingTimeCmbBox";
            this.trainingTimeCmbBox.Size = new System.Drawing.Size(154, 24);
            this.trainingTimeCmbBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training Time(Minutes)";
            // 
            // TrainingDaysDd
            // 
            this.TrainingDaysDd.Location = new System.Drawing.Point(207, 95);
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
            this.TrainingDaysDd.Size = new System.Drawing.Size(154, 22);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // TrainningForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter goalsTableAdapter1;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}