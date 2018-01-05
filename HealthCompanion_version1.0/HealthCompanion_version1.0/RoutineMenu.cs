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
            Goals = goalsTableAdapter1.GetUserPrefs(n);          
            trainingTypeCmbBox.Text = trainingTypeCmbBox.Items[0].ToString();
             CurrentUserTrainingDays = int.Parse(Goals.Rows[0]["TrainingDays"].ToString());


        }

        private void RoutineMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Routines' table. You can move, or remove it, as needed.
            this.routinesTableAdapter.FillByDays(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);

        }

        private void trainingPlaceCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (trainingPlaceCmbBox.SelectedIndex == 0)
            {
                this.routinesTableAdapter.FillByCalisthenics(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
            else if (trainingPlaceCmbBox.SelectedIndex == 1)
            {
                this.routinesTableAdapter.FillByGym(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
            else {
                this.routinesTableAdapter.FillByDays(fitnessDatabaseDataSet.Routines, CurrentUserTrainingDays);
            }
        }
    }
}
