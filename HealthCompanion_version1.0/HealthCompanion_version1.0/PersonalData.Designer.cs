namespace HealthCompanion_version1._0
{
    partial class PersonalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalData));
            this.isAthleticLabel = new System.Windows.Forms.Label();
            this.athleticCmbBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BmrLabel = new System.Windows.Forms.Label();
            this.BmiLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.BiometricTableAdapter = new HealthCompanion_version1._0.FitnessDatabaseDataSetTableAdapters.UserTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BmiValue = new System.Windows.Forms.Label();
            this.BmrValue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // isAthleticLabel
            // 
            this.isAthleticLabel.AutoSize = true;
            this.isAthleticLabel.ForeColor = System.Drawing.Color.White;
            this.isAthleticLabel.Location = new System.Drawing.Point(150, 202);
            this.isAthleticLabel.Name = "isAthleticLabel";
            this.isAthleticLabel.Size = new System.Drawing.Size(100, 17);
            this.isAthleticLabel.TabIndex = 6;
            this.isAthleticLabel.Text = "Athletic Much?";
            // 
            // athleticCmbBox
            // 
            this.athleticCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.athleticCmbBox.FormattingEnabled = true;
            this.athleticCmbBox.Items.AddRange(new object[] {
            "Not at all",
            "Maybe a Little",
            "A LOT!"});
            this.athleticCmbBox.Location = new System.Drawing.Point(238, 194);
            this.athleticCmbBox.Name = "athleticCmbBox";
            this.athleticCmbBox.Size = new System.Drawing.Size(121, 24);
            this.athleticCmbBox.TabIndex = 22;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(239, 325);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(122, 33);
            this.SubmitBtn.TabIndex = 26;
            this.SubmitBtn.Text = "Save My Info";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BmrLabel
            // 
            this.BmrLabel.AutoSize = true;
            this.BmrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BmrLabel.ForeColor = System.Drawing.Color.White;
            this.BmrLabel.Location = new System.Drawing.Point(151, 294);
            this.BmrLabel.Name = "BmrLabel";
            this.BmrLabel.Size = new System.Drawing.Size(56, 20);
            this.BmrLabel.TabIndex = 23;
            this.BmrLabel.Text = "BMR:";
            // 
            // BmiLabel
            // 
            this.BmiLabel.AutoSize = true;
            this.BmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BmiLabel.ForeColor = System.Drawing.Color.White;
            this.BmiLabel.Location = new System.Drawing.Point(151, 248);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(48, 20);
            this.BmiLabel.TabIndex = 22;
            this.BmiLabel.Text = "BMI:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(239, 155);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 21;
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(238, 121);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(122, 22);
            this.weightTxtBox.TabIndex = 20;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(151, 59);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(77, 17);
            this.heightLabel.TabIndex = 18;
            this.heightLabel.Text = "Height(cm)";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(239, 88);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(122, 22);
            this.ageTxtBox.TabIndex = 10;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(239, 54);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(122, 22);
            this.heightTxtBox.TabIndex = 8;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(151, 158);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(151, 88);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(150, 121);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(77, 17);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Weight(kg)";
            // 
            // BiometricTableAdapter
            // 
            this.BiometricTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(2, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Workout Selection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BmiValue
            // 
            this.BmiValue.AutoSize = true;
            this.BmiValue.ForeColor = System.Drawing.Color.White;
            this.BmiValue.Location = new System.Drawing.Point(236, 248);
            this.BmiValue.Name = "BmiValue";
            this.BmiValue.Size = new System.Drawing.Size(0, 17);
            this.BmiValue.TabIndex = 28;
            // 
            // BmrValue
            // 
            this.BmrValue.AutoSize = true;
            this.BmrValue.ForeColor = System.Drawing.Color.White;
            this.BmrValue.Location = new System.Drawing.Point(235, 297);
            this.BmrValue.Name = "BmrValue";
            this.BmrValue.Size = new System.Drawing.Size(0, 17);
            this.BmrValue.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(114, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(114, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(114, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(114, 194);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(114, 239);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 35;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(114, 286);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 36;
            this.pictureBox8.TabStop = false;
            // 
            // PersonalData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(524, 497);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BmrValue);
            this.Controls.Add(this.BmiValue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.isAthleticLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.athleticCmbBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.BmrLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.BmiLabel);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.heightLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter BiometricTableAdapter;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label BmrLabel;
        private System.Windows.Forms.Label BmiLabel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label isAthleticLabel;
        private System.Windows.Forms.ComboBox athleticCmbBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BmiValue;
        private System.Windows.Forms.Label BmrValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}