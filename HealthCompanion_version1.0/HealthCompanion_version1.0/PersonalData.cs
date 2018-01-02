﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCompanion_version1._0
{
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();

            athleticCmbBox.Text = athleticCmbBox.Items[0].ToString();
            heightLabel.BackColor = System.Drawing.Color.Transparent;
            weightLabel.BackColor = System.Drawing.Color.Transparent;
            ageLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.BackColor = System.Drawing.Color.Transparent;

            

        }



        

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BmiValue.Text = "";
            BmrValue.Text = "";
            if (heightTxtBox.Text == "" || ageTxtBox.Text == "" || weightTxtBox.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields");
                return;
            }


            double bmr;
            double bmi;
            if (GenderComboBox.SelectedIndex == 0)
            {//Men bmr
                bmr = 66 + (13.7 * double.Parse(weightTxtBox.Text)) + (5 * int.Parse(heightTxtBox.Text)) - (6.8 * int.Parse(ageTxtBox.Text));

            }
            else
            {//Women bmr
                bmr = 655 + (9.6 * double.Parse(weightTxtBox.Text)) + (1.8 * int.Parse(heightTxtBox.Text)) - (4.7 * int.Parse(ageTxtBox.Text));
            }
            bmi = double.Parse(weightTxtBox.Text) / Math.Pow((double.Parse(heightTxtBox.Text) / 100), 2);
            BmiValue.Text = "" + bmi;
            BmrValue.Text = "" + bmr;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            BiometricTableAdapter.Update(fitnessDatabaseDataSet.User);
            BiometricTableAdapter.UpdateBiometrics(int.Parse(ageTxtBox.Text),int.Parse(heightTxtBox.Text),int.Parse(weightTxtBox.Text),athleticCmbBox.Text,GenderComboBox.Text,decimal.Parse(BmrValue.Text),int.Parse(BmiValue.Text), UserClass.Name.ToString(), UserClass.Password.ToString());
            
        }

        private void athleticCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonalData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.User' table. You can move, or remove it, as needed.
            this.BiometricTableAdapter.Fill(this.fitnessDatabaseDataSet.User);

        }
    }
}
