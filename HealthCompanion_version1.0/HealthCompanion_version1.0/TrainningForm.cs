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
    public partial class TrainningForm : Form
    {
        public TrainningForm()
        {
            InitializeComponent();
            fitnessGoalsCmbBox.Text = fitnessGoalsCmbBox.Items[0].ToString();
            trainingTimeCmbBox.Text = trainingTimeCmbBox.Items[0].ToString();
            comboBox3.Text = comboBox3.Items[0].ToString();
            comboBox4.Text = comboBox4.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            DateTime dateStart = DateTime.Now;
            goalsTableAdapter1.Insert(n, fitnessGoalsCmbBox.Text, int.Parse(trainingTimeCmbBox.Text), (int)TrainingDaysDd.Value, dateStart, (int)ProgramDurationDd.Value, dateStart.AddMonths((int)ProgramDurationDd.Value), "Incomplete");
            RoutineMenu rm = new RoutineMenu();
            rm.Show();

        }
    }
}
