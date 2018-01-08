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
    public partial class SwapMeals : Form
    {
        public SwapMeals()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void SwapMeals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.fitnessDatabaseDataSet.Foods);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.DietPlanFood' table. You can move, or remove it, as needed.
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            String g = userDietPlanTableAdapter1.GetUserID(n).Rows[0]["DietPlanID"].ToString();
            this.dietPlanFoodTableAdapter.FillDietPlan(this.fitnessDatabaseDataSet.DietPlanFood, g);
            dt = dietPlanFoodTableAdapter.GetPlanID(g);
            fitnessDatabaseDataSet.Tables.Add(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oldFood = old.CurrentRow.Index;
            int newFood = add.CurrentRow.Index;


            DataRow dr = dt.Rows[dataGridView1.CurrentRow.Index];
            dt.Rows[0].Delete();
            dr.SetField<int>(1, (int)add.Rows[newFood].Cells[0].Value);
            dt.Rows.Add(dr);
            
        }
    }
}
