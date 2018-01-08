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


    public partial class RoutineMenu : Form
    {
        DataTable Goals;
        int CurrentUserTrainingDays;

        public RoutineMenu()
        {
            InitializeComponent();
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            Goals = goalsTableAdapter.GetUserPrefs(n,"Incomplete");
            trainingTypeCmbBox.Text = trainingTypeCmbBox.Items[0].ToString();
            CurrentUserTrainingDays = int.Parse(Goals.Rows[0]["TrainingDays"].ToString());


        }

        private void RoutineMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Routines' table. You can move, or remove it, as needed.
            this.routinesTableAdapter.FillByDays(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            trainingTypeCmbBox_SelectedIndexChanged(this, e);
            if(UserClass.firstTime == true)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }
        }

        private void trainingPlaceCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainingPlaceCmbBox.SelectedIndex == 0)
            {
                this.routinesTableAdapter.FillByCalisthenics(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
            else if (trainingPlaceCmbBox.SelectedIndex == 1)
            {
                this.routinesTableAdapter.FillByGym(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
            else
            {
                this.routinesTableAdapter.FillByDays(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
        }

        private void trainingTypeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainingTypeCmbBox.SelectedIndex == 0)
            {
                richTextBox1.Text = "Calisthenics :\nBody weight exercises\nIdeal for those who want to workout at home" +
                    "\nAlmost special equipment required";
            }
            else
            {
                richTextBox1.Text = "Gym Workout :\nGet yourself a membership in a local Gym of your choiceand enjoy the variety of weight lifting exercises"+
                    "\nIdeal for those who like a challenge and are willing to invest a good amount of time";
            }
        }

        private void saveProgram_Click(object sender, EventArgs e)
        {
            try {
                int g = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
                int n = dataGridView1.CurrentRow.Index;
                if (userRoutineTableAdapter1.checkRoutine(g) > 0)
                {
                    userRoutineTableAdapter1.deleteAllDuplicates(g);
                }
                userRoutineTableAdapter1.Insert(Convert.ToDateTime(Goals.Rows[0]["DateStart"].ToString()), g, dataGridView1.Rows[n].Cells[0].Value.ToString());
                MessageBox.Show("Successful Insert", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saveProgram.Enabled = false;
                MoveToDietForm.Enabled = true;
                userTableAdapter1.updatePoints(0, g);

            }catch(Exception es)
            {
                MessageBox.Show("Error with insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PersonalData pd = new PersonalData();
                UserClass.firstTime = true;
                pd.Show();
                this.Hide();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoveToDietForm_Click(object sender, EventArgs e)
        {
            DietForm df = new DietForm();
            df.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalForm ff = new FinalForm();
            ff.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StartUI sui = new StartUI();
            UserClass.Name = "";
            UserClass.Password = "";
            sui.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DietForm df = new DietForm();
            df.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoutineMenu rm = new RoutineMenu();
            rm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PersonalData pd = new PersonalData();
            pd.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TrainningForm tf = new TrainningForm();
            tf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Progress p = new Progress();
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FinalForm ff = new FinalForm();
            ff.Show();
            this.Show();
        }
    }
}
