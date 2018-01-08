using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace HealthCompanion_version1._0
{
    public partial class StartUI : Form
    {
        
        private int count = 0;
        public StartUI()
        {
            InitializeComponent();
            LoginPanel.Location = new Point(1000, 1000);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            LoginPanel.Location = new Point(1000, 1000);
            RegisterPanel.Location = new Point(95, 137);
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            RegisterPanel.Location = new Point(2000, 2000);
            LoginPanel.Location = new Point(95, 137);
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void loginUserTxtBox_Enter(object sender, EventArgs e)
        {
            loginUserTxtBox.Text = "";
            loginUserTxtBox.ForeColor = System.Drawing.Color.Black;
        }

        private void loginUserTxtBox_Leave(object sender, EventArgs e)
        {
            if (loginUserTxtBox.Text.Equals(""))
            {
                loginUserTxtBox.Text = "Username";
                loginUserTxtBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void loginPassTxtBox_Enter(object sender, EventArgs e)
        {
            loginPassTxtBox.Text = "";
            loginPassTxtBox.ForeColor = System.Drawing.Color.Black;
        }

        private void loginPassTxtBox_Leave(object sender, EventArgs e)
        {
            if (loginPassTxtBox.Text.Equals(""))
            {
                loginPassTxtBox.Text = "Password";
                loginPassTxtBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            count = 0;
            lnameMsg.Text = "";
            unameMsg.Text = "";
            cpassMsg.Text = "";
            nameMsg.Text = "";
            createMsg.Text = "";
            passMsg.Text = "";

            if (nameTxtBox.Text == "" || nameTxtBox.Text == null)
            {
                nameMsg.Text = "Fill the field Name";
                count++;
            }
            if (lnameTxtBox.Text == "" || lnameTxtBox.Text == null)
            {
                lnameMsg.Text = "Fill the field Last Name";
                count++;
            }
            if (userTxtBox.Text == "" || userTxtBox.Text == null)
            {
                unameMsg.Text = "Give a Username for login";
                count++;
            }
            if (passTxtBox.Text == "" || passTxtBox.Text == null)
            {
                passMsg.Text = "First fill this field";
                count++;
            }
            else if (cpassTxtBox.Text == "" || cpassTxtBox.Text == null || !cpassTxtBox.Text.Equals(passTxtBox.Text))
            {
                cpassMsg.Text = "Please fill correctly the field Confirm Password";
                count++;
            }
            if (count > 0)
            {
                return;
            }
            if(LoginUserTableAdapter.checkRegister(userTxtBox.Text).Value == 1)
              {
                  createMsg.Text = "There is already a user with this Username try again";
                  unameMsg.Text = "*****";
              }
              else
              {
                  LoginUserTableAdapter.Insert(nameTxtBox.Text,lnameTxtBox.Text,cpassTxtBox.Text,0,0,0,"","",0,0,userTxtBox.Text,0);               
                createMsg.Text = "Successful Register... Welcome to Health Companion";
              }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            if (LoginUserTableAdapter.checkLogin(loginUserTxtBox.Text,loginPassTxtBox.Text).Value == 1)
             {
                UserClass.firstTime = true;
                UserClass.Name = loginUserTxtBox.Text;
                UserClass.Password = loginPassTxtBox.Text;
                int n = int.Parse(LoginUserTableAdapter.GetFindUser(UserClass.Name, UserClass.Password).Rows[0][0].ToString());

                if (int.Parse(LoginUserTableAdapter.GetCheckForUpdated(UserClass.Name, UserClass.Password).Rows[0]["BMI"].ToString()) != 0)
                {
                    if (goalsTableAdapter1.getGoalsAndStatus(n,"Incomplete") < 1)
                    {
                        TrainningForm tf = new TrainningForm();
                        tf.Show();
                        this.Hide();
                    }
                    else if (userRoutineTableAdapter1.checkRoutine(n) < 1)
                    {
                        RoutineMenu rm = new RoutineMenu();
                        rm.Show();
                        this.Hide();
                    }
                    else if (userDietPlanTableAdapter1.checkDietPlan(n) < 1)
                    {
                        DietForm df = new DietForm();
                        df.Show();
                        this.Hide();
                    }
                    else
                    {
                        FinalForm ff = new FinalForm();
                        UserClass.firstTime = false;
                        ff.Show();
                        this.Hide();
                    }
                }
                else
                {
                    PersonalData pd = new PersonalData();
                    pd.Show();
                    this.Hide();
                }
             }
             else
             {
                 errorMsg.Text = "Wrong Username or Password. \nPlease try again!";
             }
        }

        
    }
}
