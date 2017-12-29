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
    public partial class StartUI : Form
    {
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
            lnameMsg.Text = "";
            unameMsg.Text = "";
            cpassMsg.Text = "";
            nameMsg.Text = "";

            if (nameTxtBox.Text == "" || nameTxtBox.Text == null)
            {
                nameMsg.Text = "Fill the field Name";
                return;
            }
            if (lnameTxtBox.Text == "" || lnameTxtBox.Text == null)
            {
                lnameMsg.Text = "Fill the field Last Name";
                return;
            }
            if (userTxtBox.Text == "" || userTxtBox.Text == null)
            {
                unameMsg.Text = "Give a Username for login";
                return;
            }
            if (cpassTxtBox.Text == "" || cpassTxtBox.Text == null || !cpassTxtBox.Text.Equals(passTxtBox.Text))
                {
                    cpassMsg.Text = "Please fill correctly the field Confirm Password";
                    return;

                }
            }
        }
    }
