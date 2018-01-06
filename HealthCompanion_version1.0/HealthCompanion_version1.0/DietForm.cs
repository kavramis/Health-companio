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
    public partial class DietForm : Form
    {
        DataTable User;
        String currentUserBmr;
        public DietForm()
        {
            InitializeComponent();
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            User = userTableAdapter1.GetDataUserBMR(n);
            currentUserBmr = User.Rows[0]["BMR"].ToString();
            BmrValue.Text = currentUserBmr;
            fitnessGoalTxtBox.Text = goalsTableAdapter1.GetUserPrefs(n).Rows[0]["Description"].ToString();
            if(fitnessGoalTxtBox.Text.Equals("Weight Loss"))
            {
                quickTipTxtBox.Text = "Your daily diet should be \nabout 200 calories below your BMR";
            }
            else
            {
                quickTipTxtBox.Text = "Your daily diet should be \nabout 200 calories above your BMR";
            }
        }

        

        private void DietForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.DietPlan' table. You can move, or remove it, as needed.
            this.dietPlanTableAdapter.FillMyDiet(fitnessDatabaseDataSet.DietPlan,(int) Math.Round(decimal.Parse(BmrValue.Text)), (int)Math.Round(decimal.Parse(BmrValue.Text)));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            int n = dataGridView1.CurrentRow.Index;
            DataTable Goals = goalsTableAdapter1.GetUserPrefs(g);
            userDietPlanTableAdapter1.Insert(g, dataGridView1.Rows[n].Cells[0].Value.ToString(), Convert.ToDateTime(Goals.Rows[0]["DateStart"].ToString()));
            MessageBox.Show("Complete");
        }
    }
}
