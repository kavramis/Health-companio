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
            Goals = goalsTableAdapter.GetUserPrefs(n);
            trainingTypeCmbBox.Text = trainingTypeCmbBox.Items[0].ToString();
            CurrentUserTrainingDays = int.Parse(Goals.Rows[0]["TrainingDays"].ToString());


        }

        private void RoutineMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Routines' table. You can move, or remove it, as needed.
            this.routinesTableAdapter.FillByDays(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            trainingTypeCmbBox_SelectedIndexChanged(this, e);
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
            int n = dataGridView1.CurrentRow.Index;
            userRoutineTableAdapter1.Insert(Convert.ToDateTime(Goals.Rows[0]["DateStart"].ToString()), int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString()), dataGridView1.Rows[n].Cells[0].Value.ToString());
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
    }
}
