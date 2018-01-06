namespace HealthCompanion_version1._0
{
    partial class RoutineMenu
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
            this.trainingTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysPerWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDatabaseDataSet = new HealthCompanion_version1._0.FitnessDatabaseDataSet();
            this.trainingPlaceCmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveProgram = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.routinesTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.RoutinesTableAdapter();
            this.goalsTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userRoutineTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserRoutineTableAdapter();
            this.MoveToDietForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingTypeCmbBox
            // 
            this.trainingTypeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingTypeCmbBox.FormattingEnabled = true;
            this.trainingTypeCmbBox.Items.AddRange(new object[] {
            "Calisthenics",
            "Gym Workout"});
            this.trainingTypeCmbBox.Location = new System.Drawing.Point(649, 19);
            this.trainingTypeCmbBox.Name = "trainingTypeCmbBox";
            this.trainingTypeCmbBox.Size = new System.Drawing.Size(154, 21);
            this.trainingTypeCmbBox.TabIndex = 16;
            this.trainingTypeCmbBox.SelectedIndexChanged += new System.EventHandler(this.trainingTypeCmbBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Training Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routineNameDataGridViewTextBoxColumn,
            this.daysPerWeekDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.tipsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routinesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(103, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(629, 127);
            this.dataGridView1.TabIndex = 17;
            // 
            // routineNameDataGridViewTextBoxColumn
            // 
            this.routineNameDataGridViewTextBoxColumn.DataPropertyName = "RoutineName";
            this.routineNameDataGridViewTextBoxColumn.Frozen = true;
            this.routineNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.routineNameDataGridViewTextBoxColumn.Name = "routineNameDataGridViewTextBoxColumn";
            this.routineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysPerWeekDataGridViewTextBoxColumn
            // 
            this.daysPerWeekDataGridViewTextBoxColumn.DataPropertyName = "DaysPerWeek";
            this.daysPerWeekDataGridViewTextBoxColumn.Frozen = true;
            this.daysPerWeekDataGridViewTextBoxColumn.HeaderText = "Days/Week";
            this.daysPerWeekDataGridViewTextBoxColumn.Name = "daysPerWeekDataGridViewTextBoxColumn";
            this.daysPerWeekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Frozen = true;
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipsDataGridViewTextBoxColumn
            // 
            this.tipsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipsDataGridViewTextBoxColumn.DataPropertyName = "Tips";
            this.tipsDataGridViewTextBoxColumn.HeaderText = "Tips";
            this.tipsDataGridViewTextBoxColumn.MaxInputLength = 10000;
            this.tipsDataGridViewTextBoxColumn.Name = "tipsDataGridViewTextBoxColumn";
            this.tipsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipsDataGridViewTextBoxColumn.Width = 500;
            // 
            // routinesBindingSource
            // 
            this.routinesBindingSource.DataMember = "Routines";
            this.routinesBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // fitnessDatabaseDataSet
            // 
            this.fitnessDatabaseDataSet.DataSetName = "FitnessDatabaseDataSet";
            this.fitnessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingPlaceCmbBox
            // 
            this.trainingPlaceCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingPlaceCmbBox.FormattingEnabled = true;
            this.trainingPlaceCmbBox.Items.AddRange(new object[] {
            "Home/Outdoors",
            "Gym",
            "I don\'t mind"});
            this.trainingPlaceCmbBox.Location = new System.Drawing.Point(269, 226);
            this.trainingPlaceCmbBox.Name = "trainingPlaceCmbBox";
            this.trainingPlaceCmbBox.Size = new System.Drawing.Size(154, 21);
            this.trainingPlaceCmbBox.TabIndex = 14;
            this.trainingPlaceCmbBox.SelectedIndexChanged += new System.EventHandler(this.trainingPlaceCmbBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Training Place";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(546, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(257, 96);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // saveProgram
            // 
            this.saveProgram.Location = new System.Drawing.Point(109, 9);
            this.saveProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveProgram.Name = "saveProgram";
            this.saveProgram.Size = new System.Drawing.Size(97, 67);
            this.saveProgram.TabIndex = 20;
            this.saveProgram.Text = "Save my program";
            this.saveProgram.UseVisualStyleBackColor = true;
            this.saveProgram.Click += new System.EventHandler(this.saveProgram_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(219, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 61);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select a program from Table and click Save";
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // routinesTableAdapter
            // 
            this.routinesTableAdapter.ClearBeforeFill = true;
            // 
            // goalsTableAdapter
            // 
            this.goalsTableAdapter.ClearBeforeFill = true;
            // 
            // userRoutineTableAdapter1
            // 
            this.userRoutineTableAdapter1.ClearBeforeFill = true;
            // 
            // MoveToDietForm
            // 
            this.MoveToDietForm.Location = new System.Drawing.Point(649, 343);
            this.MoveToDietForm.Name = "MoveToDietForm";
            this.MoveToDietForm.Size = new System.Drawing.Size(181, 56);
            this.MoveToDietForm.TabIndex = 22;
            this.MoveToDietForm.Text = "Let\'s Make a Diet Plan";
            this.MoveToDietForm.UseVisualStyleBackColor = true;
            this.MoveToDietForm.Click += new System.EventHandler(this.MoveToDietForm_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 498);
            this.panel1.TabIndex = 23;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(649, 463);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(181, 44);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RoutineMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 532);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoveToDietForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveProgram);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trainingTypeCmbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trainingPlaceCmbBox);
            this.Controls.Add(this.label5);
            this.Name = "RoutineMenu";
            this.Text = "RoutineMenu";
            this.Load += new System.EventHandler(this.RoutineMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.ComboBox trainingTypeCmbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FitnessDatabaseDataSet fitnessDatabaseDataSet;
        private System.Windows.Forms.BindingSource routinesBindingSource;
        private FitnessDatabaseDataSetTableAdapters.RoutinesTableAdapter routinesTableAdapter;
        private System.Windows.Forms.ComboBox trainingPlaceCmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter goalsTableAdapter;
        private System.Windows.Forms.Button saveProgram;
        private System.Windows.Forms.Label label1;
        private FitnessDatabaseDataSetTableAdapters.UserRoutineTableAdapter userRoutineTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysPerWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button MoveToDietForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
    }
}