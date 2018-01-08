using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCompanion_version1._0
{

    public partial class FinalForm : Form
    {
        String s;
        public FinalForm()
        {
            InitializeComponent();
           


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Goals' table. You can move, or remove it, as needed.
            this.goalsTableAdapter.Fill(this.fitnessDatabaseDataSet.Goals);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.fitnessDatabaseDataSet.Foods);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.DietPlanFood' table. You can move, or remove it, as needed.
            this.dietPlanFoodTableAdapter.Fill(this.fitnessDatabaseDataSet.DietPlanFood);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Exercise' table. You can move, or remove it, as needed.
            this.exerciseTableAdapter.Fill(this.fitnessDatabaseDataSet.Exercise);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.RoutineExercise' table. You can move, or remove it, as needed.
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            String s = userRoutineTableAdapter1.GetDataUserID(n).Rows[0]["RoutineName"].ToString();
            this.routineExerciseTableAdapter.FillRoutineName(this.fitnessDatabaseDataSet.RoutineExercise, s);

            String g = userDietPlanTableAdapter1.GetUserID(n).Rows[0]["DietPlanID"].ToString();
            this.dietPlanFoodTableAdapter.FillDietPlan(this.fitnessDatabaseDataSet.DietPlanFood, g);
            String imgFile = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            String path = Path.Combine(Environment.CurrentDirectory, @"Resources\", imgFile);
            pictureBox1.Image = new Bitmap(path);
            s = path;            
            fname.Text = userTableAdapter1.GetDataUserBMR(n).Rows[0]["UserName"].ToString();
            lname.Text = userTableAdapter1.GetDataUserBMR(n).Rows[0]["UserLastName"].ToString();
            weight.Text = userTableAdapter1.GetDataUserBMR(n).Rows[0]["Weight"].ToString();
            goal.Text = goalsTableAdapter.GetUserPrefs(n, "Incomplete").Rows[0]["Description"].ToString();
            UserClass.firstTime = false;
            if (goalsTableAdapter.getGoals(n) + userRoutineTableAdapter1.checkRoutine(n) + userDietPlanTableAdapter1.checkDietPlan(n) > 25)
            {
                clearBtn.Enabled = true;
            }

    }
        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //AN VRETHEI TROPOS NA FEROUME TO PATH APO TO PROPERTIES.RESOURCES GIA COMBINE ME TO imgFile tha einai idanikos
            //gia na leitourgisei to parakatw prepei na ginei copy o fakelos resources kai sto bin giati to Enviroment.CurreDirectory
            //epistrefei olo to path mexri to debug
            try
            {
                String imgFile = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                String path = Path.Combine(Environment.CurrentDirectory, @"Resources\", imgFile);
                pictureBox1.Image = new Bitmap(path);
                s = path;
            }catch(Exception es)
            {
                pictureBox1.Image = new Bitmap(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            Progress pro = new Progress();
            pro.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FinalForm_Load(this, e);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will delete all record from Goals, Diet plan and Routine plan", "Warning!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
                goalsTableAdapter.deleteAllUserRecords(n);
                userRoutineTableAdapter1.deleteAllDuplicates(n);
                userDietPlanTableAdapter1.deleteUserDietPlan(n);
                userTableAdapter1.updatePoints(0, n);
                MessageBox.Show("Delete successful", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                PersonalData pd = new PersonalData();
                pd.Show();
                this.Hide();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SwapMeals sm = new SwapMeals();
            sm.Show();
            this.Hide();
        }
    }
   
}
