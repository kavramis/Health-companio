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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oldFood = old.CurrentRow.Index;
            int newFood = add.CurrentRow.Index;

            if (!old.Rows[0].Cells[3].Value.Equals(add.Rows[newFood].Cells[3].Value) || int.Parse(old.Rows[0].Cells[2].Value.ToString())+70 < int.Parse(add.Rows[newFood].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Pick the same types of food and about calories(+70)", "Pick alert!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                
                if (dr[1].ToString().Equals(dataGridView1.CurrentRow.Cells[1].Value.ToString()) &&
                    dr[0].ToString().Equals(dataGridView1.CurrentRow.Cells[0].Value.ToString()) &&
                    dr[2].ToString().Equals(dataGridView1.CurrentRow.Cells[2].Value.ToString()) &&
                    dr[3].ToString().Equals(dataGridView1.CurrentRow.Cells[3].Value.ToString()))
                {
                    try
                    {
                        dr.SetField<int>(1, (int)add.Rows[newFood].Cells[0].Value);
                        MessageBox.Show("Updated correctly", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(Exception es)
                    {
                        MessageBox.Show("Can't pick that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());
            String g = userDietPlanTableAdapter1.GetUserID(n).Rows[0]["DietPlanID"].ToString();
            DataRow d = dietPlanTableAdapter1.GetDataByNewMeals(g).Rows[0];
            if (userDietPlanTableAdapter1.checkForUpdate("User " + n + " Updated Plan") == 1)
            {
                userDietPlanTableAdapter1.UpdateQuery("User " + n + " Updated Plan", n);
                dietPlanTableAdapter1.updateMeal(int.Parse(d[1].ToString()), d[2].ToString(), d[3].ToString(), int.Parse(d[4].ToString()), "", "User " + n + " Updated Plan");
                dietPlanFoodTableAdapter.DeleteQuery("User " + n + " Updated Plan");
                foreach (DataRow dr in dt.Rows)
                {
                    dr.SetField<String>(0, "User " + n + " Updated Plan");
                    dietPlanFoodTableAdapter.Insert(dr[0].ToString(), int.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()));
                }
                MessageBox.Show("Updated custom diet program", "Updated", MessageBoxButtons.OK);

            }
            else
            {
                dietPlanTableAdapter1.Insert("User " + n + " Updated Plan", int.Parse(d[1].ToString()), d[2].ToString(), d[3].ToString(), int.Parse(d[4].ToString()), "");
                userDietPlanTableAdapter1.UpdateQuery("User " + n + " Updated Plan", n);
                foreach (DataRow dr in dt.Rows)
                {
                    dr.SetField<String>(0, "User " + n + " Updated Plan");
                    dietPlanFoodTableAdapter.Insert(dr[0].ToString(), int.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), int.Parse(dr[3].ToString()));

                }
                userDietPlanTableAdapter1.UpdateQuery("User " + n + " Updated Plan", n);
                MessageBox.Show("Created custom diet program", "Created", MessageBoxButtons.OK);

            }
        }
    }
}
