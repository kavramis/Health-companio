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
            String imgFile = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            String path = Path.Combine(Environment.CurrentDirectory, @"Resources\", imgFile);
            pictureBox1.Image = new Bitmap(path);






        }
        
        

        private void button8_Click(object sender, EventArgs e)
        {
            //AN VRETHEI TROPOS NA FEROUME TO PATH APO TO PROPERTIES.RESOURCES GIA COMBINE ME TO imgFile tha einai idanikos
            //gia na leitourgisei to parakatw prepei na ginei copy o fakelos resources kai sto bin giati to Enviroment.CurreDirectory
            //epistrefei olo to path mexri to debug
            String imgFile = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            String path = Path.Combine(Environment.CurrentDirectory, @"Resources\", imgFile);            
            pictureBox1.Image = new Bitmap(path);
        }

       
    }
   
}
