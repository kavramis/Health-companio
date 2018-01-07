﻿namespace HealthCompanion_version1._0
{
    partial class FinalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDatabaseDataSet = new HealthCompanion_version1._0.FitnessDatabaseDataSet();
            this.routineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routineDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routineExerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.routineExerciseTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.RoutineExerciseTableAdapter();
            this.exerciseTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.ExerciseTableAdapter();
            this.exIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muscleGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exImgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exRepsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exSetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routineExerciseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 606);
            this.panel1.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkRed;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 512);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(203, 94);
            this.button9.TabIndex = 9;
            this.button9.Text = "Exit  ";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.button4.Text = "Personal Data      ";
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Switch User";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 138);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Health Companion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 73);
            this.label3.TabIndex = 0;
            this.label3.Text = "HC";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 606);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routineNameDataGridViewTextBoxColumn,
            this.exIDDataGridViewTextBoxColumn,
            this.exNumberDataGridViewTextBoxColumn,
            this.routineDayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routineExerciseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exIDDataGridViewTextBoxColumn1,
            this.exNameDataGridViewTextBoxColumn,
            this.exTypeDataGridViewTextBoxColumn,
            this.muscleGroupDataGridViewTextBoxColumn,
            this.exTipDataGridViewTextBoxColumn,
            this.exImgDataGridViewTextBoxColumn,
            this.exRepsDataGridViewTextBoxColumn,
            this.exSetsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.exerciseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(619, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "Exercise";
            this.exerciseBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // fitnessDatabaseDataSet
            // 
            this.fitnessDatabaseDataSet.DataSetName = "FitnessDatabaseDataSet";
            this.fitnessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routineNameDataGridViewTextBoxColumn
            // 
            this.routineNameDataGridViewTextBoxColumn.DataPropertyName = "RoutineName";
            this.routineNameDataGridViewTextBoxColumn.HeaderText = "RoutineName";
            this.routineNameDataGridViewTextBoxColumn.Name = "routineNameDataGridViewTextBoxColumn";
            // 
            // exIDDataGridViewTextBoxColumn
            // 
            this.exIDDataGridViewTextBoxColumn.DataPropertyName = "ExID";
            this.exIDDataGridViewTextBoxColumn.HeaderText = "ExID";
            this.exIDDataGridViewTextBoxColumn.Name = "exIDDataGridViewTextBoxColumn";
            // 
            // exNumberDataGridViewTextBoxColumn
            // 
            this.exNumberDataGridViewTextBoxColumn.DataPropertyName = "ExNumber";
            this.exNumberDataGridViewTextBoxColumn.HeaderText = "ExNumber";
            this.exNumberDataGridViewTextBoxColumn.Name = "exNumberDataGridViewTextBoxColumn";
            // 
            // routineDayDataGridViewTextBoxColumn
            // 
            this.routineDayDataGridViewTextBoxColumn.DataPropertyName = "RoutineDay";
            this.routineDayDataGridViewTextBoxColumn.HeaderText = "RoutineDay";
            this.routineDayDataGridViewTextBoxColumn.Name = "routineDayDataGridViewTextBoxColumn";
            // 
            // routineExerciseBindingSource
            // 
            this.routineExerciseBindingSource.DataMember = "RoutineExercise";
            this.routineExerciseBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // routineExerciseTableAdapter
            // 
            this.routineExerciseTableAdapter.ClearBeforeFill = true;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
            // 
            // exIDDataGridViewTextBoxColumn1
            // 
            this.exIDDataGridViewTextBoxColumn1.DataPropertyName = "Ex_ID";
            this.exIDDataGridViewTextBoxColumn1.HeaderText = "Ex_ID";
            this.exIDDataGridViewTextBoxColumn1.Name = "exIDDataGridViewTextBoxColumn1";
            // 
            // exNameDataGridViewTextBoxColumn
            // 
            this.exNameDataGridViewTextBoxColumn.DataPropertyName = "Ex_Name";
            this.exNameDataGridViewTextBoxColumn.HeaderText = "Ex_Name";
            this.exNameDataGridViewTextBoxColumn.Name = "exNameDataGridViewTextBoxColumn";
            // 
            // exTypeDataGridViewTextBoxColumn
            // 
            this.exTypeDataGridViewTextBoxColumn.DataPropertyName = "Ex_Type";
            this.exTypeDataGridViewTextBoxColumn.HeaderText = "Ex_Type";
            this.exTypeDataGridViewTextBoxColumn.Name = "exTypeDataGridViewTextBoxColumn";
            // 
            // muscleGroupDataGridViewTextBoxColumn
            // 
            this.muscleGroupDataGridViewTextBoxColumn.DataPropertyName = "MuscleGroup";
            this.muscleGroupDataGridViewTextBoxColumn.HeaderText = "MuscleGroup";
            this.muscleGroupDataGridViewTextBoxColumn.Name = "muscleGroupDataGridViewTextBoxColumn";
            // 
            // exTipDataGridViewTextBoxColumn
            // 
            this.exTipDataGridViewTextBoxColumn.DataPropertyName = "ExTip";
            this.exTipDataGridViewTextBoxColumn.HeaderText = "ExTip";
            this.exTipDataGridViewTextBoxColumn.Name = "exTipDataGridViewTextBoxColumn";
            // 
            // exImgDataGridViewTextBoxColumn
            // 
            this.exImgDataGridViewTextBoxColumn.DataPropertyName = "ExImg";
            this.exImgDataGridViewTextBoxColumn.HeaderText = "ExImg";
            this.exImgDataGridViewTextBoxColumn.Name = "exImgDataGridViewTextBoxColumn";
            // 
            // exRepsDataGridViewTextBoxColumn
            // 
            this.exRepsDataGridViewTextBoxColumn.DataPropertyName = "ExReps";
            this.exRepsDataGridViewTextBoxColumn.HeaderText = "ExReps";
            this.exRepsDataGridViewTextBoxColumn.Name = "exRepsDataGridViewTextBoxColumn";
            // 
            // exSetsDataGridViewTextBoxColumn
            // 
            this.exSetsDataGridViewTextBoxColumn.DataPropertyName = "ExSets";
            this.exSetsDataGridViewTextBoxColumn.HeaderText = "ExSets";
            this.exSetsDataGridViewTextBoxColumn.Name = "exSetsDataGridViewTextBoxColumn";
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalForm";
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routineExerciseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private FitnessDatabaseDataSet fitnessDatabaseDataSet;
        private System.Windows.Forms.BindingSource routineExerciseBindingSource;
        private FitnessDatabaseDataSetTableAdapters.RoutineExerciseTableAdapter routineExerciseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routineDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource exerciseBindingSource;
        private FitnessDatabaseDataSetTableAdapters.ExerciseTableAdapter exerciseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscleGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exImgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exRepsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exSetsDataGridViewTextBoxColumn;
    }
}