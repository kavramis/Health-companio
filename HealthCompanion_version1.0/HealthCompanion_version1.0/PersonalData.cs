using System;
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
                MessageBox.Show("Please Fill All Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double bmr;
            double bmi;
            try
            {
                if (GenderComboBox.SelectedIndex == 0)
                {//Men bmr
                    bmr = 66 + (13.7 * double.Parse(weightTxtBox.Text)) + (5 * int.Parse(heightTxtBox.Text)) - (6.8 * int.Parse(ageTxtBox.Text));

                }
                else
                {//Women bmr
                    bmr = 655 + (9.6 * double.Parse(weightTxtBox.Text)) + (1.8 * int.Parse(heightTxtBox.Text)) - (4.7 * int.Parse(ageTxtBox.Text));
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Wrong Format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            if (heightTxtBox.Text == "" || ageTxtBox.Text == "" || weightTxtBox.Text == "" || GenderComboBox.Text == "" || athleticCmbBox.Text == "")
            {
                MessageBox.Show("Fill all the fields to update your data", "Update Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GenderComboBox_SelectedIndexChanged(this, e);
            try
            {
                this.BiometricTableAdapter.UpdateBiometrics(int.Parse(ageTxtBox.Text), int.Parse(heightTxtBox.Text), int.Parse(weightTxtBox.Text),
                    athleticCmbBox.Text.ToString(), GenderComboBox.Text.ToString(), decimal.Parse(BmrValue.Text),
                    (int)Math.Round(decimal.Parse(BmiValue.Text)), UserClass.Name, UserClass.Password);
                MessageBox.Show("Succesfull update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
            }
            catch (Exception s)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainningForm trf = new TrainningForm();
            trf.Show();
            this.Hide();
        }
    }
}
