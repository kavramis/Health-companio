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
            this.PersonalDataPanel = new System.Windows.Forms.Panel();
            this.isAthleticLabel = new System.Windows.Forms.Label();
            this.athleticCmbBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.BmrValue = new System.Windows.Forms.Label();
            this.BmiValue = new System.Windows.Forms.Label();
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
            this.PersonalDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalDataPanel
            // 
            this.PersonalDataPanel.BackColor = System.Drawing.Color.Salmon;
            this.PersonalDataPanel.Controls.Add(this.isAthleticLabel);
            this.PersonalDataPanel.Controls.Add(this.athleticCmbBox);
            this.PersonalDataPanel.Controls.Add(this.SubmitBtn);
            this.PersonalDataPanel.Controls.Add(this.BmrValue);
            this.PersonalDataPanel.Controls.Add(this.BmiValue);
            this.PersonalDataPanel.Controls.Add(this.BmrLabel);
            this.PersonalDataPanel.Controls.Add(this.BmiLabel);
            this.PersonalDataPanel.Controls.Add(this.GenderComboBox);
            this.PersonalDataPanel.Controls.Add(this.weightTxtBox);
            this.PersonalDataPanel.Controls.Add(this.heightLabel);
            this.PersonalDataPanel.Controls.Add(this.ageTxtBox);
            this.PersonalDataPanel.Controls.Add(this.heightTxtBox);
            this.PersonalDataPanel.Controls.Add(this.genderLabel);
            this.PersonalDataPanel.Controls.Add(this.ageLabel);
            this.PersonalDataPanel.Controls.Add(this.weightLabel);
            this.PersonalDataPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonalDataPanel.Name = "PersonalDataPanel";
            this.PersonalDataPanel.Size = new System.Drawing.Size(527, 1000);
            this.PersonalDataPanel.TabIndex = 0;
            // 
            // isAthleticLabel
            // 
            this.isAthleticLabel.AutoSize = true;
            this.isAthleticLabel.ForeColor = System.Drawing.Color.White;
            this.isAthleticLabel.Location = new System.Drawing.Point(27, 167);
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
            this.athleticCmbBox.Location = new System.Drawing.Point(115, 159);
            this.athleticCmbBox.Name = "athleticCmbBox";
            this.athleticCmbBox.Size = new System.Drawing.Size(121, 24);
            this.athleticCmbBox.TabIndex = 22;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(12, 237);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(128, 23);
            this.SubmitBtn.TabIndex = 26;
            this.SubmitBtn.Text = "Save My Info";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // BmrValue
            // 
            this.BmrValue.AutoSize = true;
            this.BmrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmrValue.Location = new System.Drawing.Point(329, 49);
            this.BmrValue.Name = "BmrValue";
            this.BmrValue.Size = new System.Drawing.Size(0, 20);
            this.BmrValue.TabIndex = 25;
            // 
            // BmiValue
            // 
            this.BmiValue.AutoSize = true;
            this.BmiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BmiValue.Location = new System.Drawing.Point(329, 22);
            this.BmiValue.Name = "BmiValue";
            this.BmiValue.Size = new System.Drawing.Size(0, 20);
            this.BmiValue.TabIndex = 24;
            // 
            // BmrLabel
            // 
            this.BmrLabel.AutoSize = true;
            this.BmrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BmrLabel.Location = new System.Drawing.Point(269, 50);
            this.BmrLabel.Name = "BmrLabel";
            this.BmrLabel.Size = new System.Drawing.Size(56, 20);
            this.BmrLabel.TabIndex = 23;
            this.BmrLabel.Text = "BMR:";
            // 
            // BmiLabel
            // 
            this.BmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BmiLabel.Location = new System.Drawing.Point(269, 20);
            this.BmiLabel.Name = "BmiLabel";
            this.BmiLabel.Size = new System.Drawing.Size(41, 16);
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
            this.GenderComboBox.Location = new System.Drawing.Point(116, 120);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 21;
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(115, 86);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(122, 22);
            this.weightTxtBox.TabIndex = 20;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.ForeColor = System.Drawing.Color.White;
            this.heightLabel.Location = new System.Drawing.Point(28, 24);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(77, 17);
            this.heightLabel.TabIndex = 18;
            this.heightLabel.Text = "Height(cm)";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(116, 53);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(122, 22);
            this.ageTxtBox.TabIndex = 10;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(116, 19);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(122, 22);
            this.heightTxtBox.TabIndex = 8;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(28, 123);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(28, 53);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(27, 86);
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
            this.button2.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(693, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PersonalData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(829, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PersonalDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalData";
            this.PersonalDataPanel.ResumeLayout(false);
            this.PersonalDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PersonalDataPanel;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private FitnessDatabaseDataSetTableAdapters.UserTableAdapter BiometricTableAdapter;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label BmrValue;
        private System.Windows.Forms.Label BmiValue;
        private System.Windows.Forms.Label BmrLabel;
        private System.Windows.Forms.Label BmiLabel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label isAthleticLabel;
        private System.Windows.Forms.ComboBox athleticCmbBox;
    }
}