namespace HealthCompanion_version1._0
{
    partial class History
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fitnessDatabaseDataSet = new HealthCompanion_version1._0.FitnessDatabaseDataSet();
            this.goalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goalsTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.trainingTimeDataGridViewTextBoxColumn,
            this.trainingDaysDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.workoutTimeDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(163, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(849, 511);
            this.dataGridView1.TabIndex = 0;
            // 
            // fitnessDatabaseDataSet
            // 
            this.fitnessDatabaseDataSet.DataSetName = "FitnessDatabaseDataSet";
            this.fitnessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalsBindingSource
            // 
            this.goalsBindingSource.DataMember = "Goals";
            this.goalsBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // goalsTableAdapter
            // 
            this.goalsTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // trainingTimeDataGridViewTextBoxColumn
            // 
            this.trainingTimeDataGridViewTextBoxColumn.DataPropertyName = "TrainingTime";
            this.trainingTimeDataGridViewTextBoxColumn.HeaderText = "TrainingTime";
            this.trainingTimeDataGridViewTextBoxColumn.Name = "trainingTimeDataGridViewTextBoxColumn";
            // 
            // trainingDaysDataGridViewTextBoxColumn
            // 
            this.trainingDaysDataGridViewTextBoxColumn.DataPropertyName = "TrainingDays";
            this.trainingDaysDataGridViewTextBoxColumn.HeaderText = "TrainingDays";
            this.trainingDaysDataGridViewTextBoxColumn.Name = "trainingDaysDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // workoutTimeDataGridViewTextBoxColumn
            // 
            this.workoutTimeDataGridViewTextBoxColumn.DataPropertyName = "WorkoutTime";
            this.workoutTimeDataGridViewTextBoxColumn.HeaderText = "WorkoutTime";
            this.workoutTimeDataGridViewTextBoxColumn.Name = "workoutTimeDataGridViewTextBoxColumn";
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 535);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FitnessDatabaseDataSet fitnessDatabaseDataSet;
        private System.Windows.Forms.BindingSource goalsBindingSource;
        private FitnessDatabaseDataSetTableAdapters.GoalsTableAdapter goalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
    }
}