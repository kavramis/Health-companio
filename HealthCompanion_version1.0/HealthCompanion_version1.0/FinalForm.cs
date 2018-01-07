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
    public partial class FinalForm : Form
    {
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
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.Exercise' table. You can move, or remove it, as needed.
            this.exerciseTableAdapter.Fill(this.fitnessDatabaseDataSet.Exercise);
            // TODO: This line of code loads data into the 'fitnessDatabaseDataSet.RoutineExercise' table. You can move, or remove it, as needed.
            this.routineExerciseTableAdapter.Fill(this.fitnessDatabaseDataSet.RoutineExercise);

        }
    }
}
