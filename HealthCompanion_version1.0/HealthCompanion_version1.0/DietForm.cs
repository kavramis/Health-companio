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

        }

        

        private void DietForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.DietPlan' table. You can move, or remove it, as needed.
            this.dietPlanTableAdapter.Fill(this.fitnessDatabaseDataSet.DietPlan);
            
        }
    }
}
