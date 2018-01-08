namespace HealthCompanion_version1._0
{
    partial class SwapMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwapMeals));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dietPlanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietPlanFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDatabaseDataSet = new HealthCompanion_version1._0.FitnessDatabaseDataSet();
            this.add = new System.Windows.Forms.DataGridView();
            this.foodIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.old = new System.Windows.Forms.DataGridView();
            this.foodIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodsDietPlanFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dietPlanFoodTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.DietPlanFoodTableAdapter();
            this.foodsTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.FoodsTableAdapter();
            this.userTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.userDietPlanTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserDietPlanTableAdapter();
            this.dietPlanTableAdapter1 = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.DietPlanTableAdapter();
            this.returnBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.old)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDietPlanFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietPlanIDDataGridViewTextBoxColumn,
            this.foodIDDataGridViewTextBoxColumn,
            this.mealNumberDataGridViewTextBoxColumn,
            this.mealDayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dietPlanFoodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(413, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // dietPlanIDDataGridViewTextBoxColumn
            // 
            this.dietPlanIDDataGridViewTextBoxColumn.DataPropertyName = "DietPlanID";
            this.dietPlanIDDataGridViewTextBoxColumn.HeaderText = "DietPlanID";
            this.dietPlanIDDataGridViewTextBoxColumn.Name = "dietPlanIDDataGridViewTextBoxColumn";
            // 
            // foodIDDataGridViewTextBoxColumn
            // 
            this.foodIDDataGridViewTextBoxColumn.DataPropertyName = "FoodID";
            this.foodIDDataGridViewTextBoxColumn.HeaderText = "FoodID";
            this.foodIDDataGridViewTextBoxColumn.Name = "foodIDDataGridViewTextBoxColumn";
            // 
            // mealNumberDataGridViewTextBoxColumn
            // 
            this.mealNumberDataGridViewTextBoxColumn.DataPropertyName = "MealNumber";
            this.mealNumberDataGridViewTextBoxColumn.HeaderText = "MealNumber";
            this.mealNumberDataGridViewTextBoxColumn.Name = "mealNumberDataGridViewTextBoxColumn";
            // 
            // mealDayDataGridViewTextBoxColumn
            // 
            this.mealDayDataGridViewTextBoxColumn.DataPropertyName = "MealDay";
            this.mealDayDataGridViewTextBoxColumn.HeaderText = "MealDay";
            this.mealDayDataGridViewTextBoxColumn.Name = "mealDayDataGridViewTextBoxColumn";
            // 
            // dietPlanFoodBindingSource
            // 
            this.dietPlanFoodBindingSource.DataMember = "DietPlanFood";
            this.dietPlanFoodBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // fitnessDatabaseDataSet
            // 
            this.fitnessDatabaseDataSet.DataSetName = "FitnessDatabaseDataSet";
            this.fitnessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add
            // 
            this.add.AutoGenerateColumns = false;
            this.add.BackgroundColor = System.Drawing.SystemColors.Window;
            this.add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIDDataGridViewTextBoxColumn2,
            this.specificationsDataGridViewTextBoxColumn1,
            this.caloriesDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1});
            this.add.DataSource = this.foodsBindingSource;
            this.add.Location = new System.Drawing.Point(413, 344);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.MultiSelect = false;
            this.add.Name = "add";
            this.add.RowTemplate.Height = 24;
            this.add.Size = new System.Drawing.Size(694, 201);
            this.add.TabIndex = 1;
            // 
            // foodIDDataGridViewTextBoxColumn2
            // 
            this.foodIDDataGridViewTextBoxColumn2.DataPropertyName = "FoodID";
            this.foodIDDataGridViewTextBoxColumn2.HeaderText = "FoodID";
            this.foodIDDataGridViewTextBoxColumn2.Name = "foodIDDataGridViewTextBoxColumn2";
            // 
            // specificationsDataGridViewTextBoxColumn1
            // 
            this.specificationsDataGridViewTextBoxColumn1.DataPropertyName = "Specifications";
            this.specificationsDataGridViewTextBoxColumn1.HeaderText = "Specifications";
            this.specificationsDataGridViewTextBoxColumn1.Name = "specificationsDataGridViewTextBoxColumn1";
            // 
            // caloriesDataGridViewTextBoxColumn1
            // 
            this.caloriesDataGridViewTextBoxColumn1.DataPropertyName = "Calories";
            this.caloriesDataGridViewTextBoxColumn1.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn1.Name = "caloriesDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // foodsBindingSource
            // 
            this.foodsBindingSource.DataMember = "Foods";
            this.foodsBindingSource.DataSource = this.fitnessDatabaseDataSet;
            // 
            // old
            // 
            this.old.AutoGenerateColumns = false;
            this.old.BackgroundColor = System.Drawing.SystemColors.Window;
            this.old.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.old.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIDDataGridViewTextBoxColumn1,
            this.specificationsDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.old.DataSource = this.foodsDietPlanFoodBindingSource;
            this.old.Location = new System.Drawing.Point(413, 178);
            this.old.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.old.MultiSelect = false;
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(694, 162);
            this.old.TabIndex = 2;
            // 
            // foodIDDataGridViewTextBoxColumn1
            // 
            this.foodIDDataGridViewTextBoxColumn1.DataPropertyName = "FoodID";
            this.foodIDDataGridViewTextBoxColumn1.HeaderText = "FoodID";
            this.foodIDDataGridViewTextBoxColumn1.Name = "foodIDDataGridViewTextBoxColumn1";
            // 
            // specificationsDataGridViewTextBoxColumn
            // 
            this.specificationsDataGridViewTextBoxColumn.DataPropertyName = "Specifications";
            this.specificationsDataGridViewTextBoxColumn.HeaderText = "Specifications";
            this.specificationsDataGridViewTextBoxColumn.Name = "specificationsDataGridViewTextBoxColumn";
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // foodsDietPlanFoodBindingSource
            // 
            this.foodsDietPlanFoodBindingSource.DataMember = "FoodsDietPlanFood";
            this.foodsDietPlanFoodBindingSource.DataSource = this.dietPlanFoodBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(207, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Swap my foods";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dietPlanFoodTableAdapter
            // 
            this.dietPlanFoodTableAdapter.ClearBeforeFill = true;
            // 
            // foodsTableAdapter
            // 
            this.foodsTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // userDietPlanTableAdapter1
            // 
            this.userDietPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // dietPlanTableAdapter1
            // 
            this.dietPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.DarkRed;
            this.returnBtn.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(0, 499);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(178, 46);
            this.returnBtn.TabIndex = 5;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SwapMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1108, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.old);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SwapMeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwapMeals";
            this.Load += new System.EventHandler(this.SwapMeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietPlanFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.old)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDietPlanFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView add;
        private System.Windows.Forms.DataGridView old;
        private FitnessDatabaseDataSet fitnessDatabaseDataSet;
        private System.Windows.Forms.BindingSource dietPlanFoodBindingSource;
        private FitnessDatabaseDataSetTableAdapters.DietPlanFoodTableAdapter dietPlanFoodTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietPlanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource foodsDietPlanFoodBindingSource;
        private FitnessDatabaseDataSetTableAdapters.FoodsTableAdapter foodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource foodsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private FitnessDatabaseDataSetTableAdapters.UserDietPlanTableAdapter userDietPlanTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FitnessDatabaseDataSetTableAdapters.DietPlanTableAdapter dietPlanTableAdapter1;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}