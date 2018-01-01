using System;
using System.Drawing;
using System.Windows.Forms;

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
            if(userTableAdapter1.checkRegister(userTxtBox.Text).Value == 1)
              {
                  createMsg.Text = "There is already a user with this Username try again";
                  unameMsg.Text = "*****";
              }
              else
              {
                  userTableAdapter1.Insert(nameTxtBox.Text,lnameTxtBox.Text,cpassTxtBox.Text,0,0,0,"","",0,0,userTxtBox.Text);      
                
                  createMsg.Text = "Succesfull Register... Welcome to Health Companion";
              }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            if (userTableAdapter1.checkLogin(loginUserTxtBox.Text,loginPassTxtBox.Text).Value == 1)
             {
                 // do things
             }
             else
             {
                 errorMsg.Text = "Wrong Username or Password. \nPlease try again!";
             }
        }
    }
}
