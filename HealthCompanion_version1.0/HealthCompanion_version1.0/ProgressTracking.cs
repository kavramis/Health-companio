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
    public partial class Progress : Form
    {
        int id;
        DateTime start,end;
        public Progress()
        {
            InitializeComponent();
            id = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            start = (DateTime)goalsTableAdapter1.GetUserPrefs(id, "Incomplete").Rows[0]["DateStart"];
            end = (DateTime)goalsTableAdapter1.GetUserPrefs(id, "Incomplete").Rows[0]["DateEnd"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTableAdapter1.updatePoints(circularProgressBar1.Value+1, id);
            Progress_Load(this, e);
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = int.Parse(userTableAdapter1.GetDataUserBMR(id).Rows[0]["ProgressPoints"].ToString());
            supposed.Text ="Supposed point : "+(DateTime.Now.Date - start.Date).TotalDays * 2;
            circularProgressBar1.SuperscriptText = userTableAdapter1.GetDataUserBMR(id).Rows[0]["ProgressPoints"].ToString();
            if ((DateTime.Now.Date - start.Date).TotalDays * 2 >= 8)
            {
                button12.Enabled = true;
            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            userTableAdapter1.updatePoints(circularProgressBar1.Value + 1, id);
            Progress_Load(this, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now.Date - start.Date).TotalDays * 2 >= 8)
            {
                if (MessageBox.Show("We recommend to reset your goals, your diet plan and training plan", "Instraction", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                 
                    userTableAdapter1.updatePoints(0, id);
                    goalsTableAdapter1.updateStatus("Failed", id , "Incomplete");
                    userRoutineTableAdapter1.deleteAllDuplicates(id);
                    userDietPlanTableAdapter1.deleteUserDietPlan(id);
                    MessageBox.Show("Reset successful", "Reseted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UserClass.firstTime = true;
                    TrainningForm tf = new TrainningForm();
                    tf.Show();
                    this.Hide();

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you satisfied with current program?","Satisfied?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
            {
                if(MessageBox.Show("Do you want to reset goals, diet plan and training plan?", "Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userTableAdapter1.updatePoints(0, id);
                    goalsTableAdapter1.updateStatus("Failed", id, "Incomplete");
                    userRoutineTableAdapter1.deleteAllDuplicates(id);
                    userDietPlanTableAdapter1.deleteUserDietPlan(id);
                    MessageBox.Show("Reset successful", "Reseted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UserClass.firstTime = true;
                    TrainningForm tf = new TrainningForm();
                    tf.Show();
                    this.Hide();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
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
            Progress_Load(this, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FinalForm ff = new FinalForm();
            ff.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Date == end.Date)
            {
                userTableAdapter1.updatePoints(0, id);
                goalsTableAdapter1.updateStatus("Completed", id , "Incomplete");
                userRoutineTableAdapter1.deleteAllDuplicates(id);
                userDietPlanTableAdapter1.deleteUserDietPlan(id);
                MessageBox.Show("Completed your Program", "Complete program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserClass.firstTime = true;
                TrainningForm tf = new TrainningForm();
                tf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You still have "+ (end.Date - DateTime.Now.Date).TotalDays + " days for training", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
