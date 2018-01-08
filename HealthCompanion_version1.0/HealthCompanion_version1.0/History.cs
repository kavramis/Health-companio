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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Goals' table. You can move, or remove it, as needed.
            this.goalsTableAdapter.FillHistory(this.fitnessDatabaseDataSet.Goals, int.Parse(userTableAdapter1.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalForm ff = new FinalForm();
            ff.Show();
            this.Hide();
        }
    }
}
