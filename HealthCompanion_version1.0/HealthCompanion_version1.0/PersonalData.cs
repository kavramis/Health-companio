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
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
            genderRadioBtnMale.Select();
            heightLabel.BackColor = System.Drawing.Color.Transparent;
            weightLabel.BackColor = System.Drawing.Color.Transparent;
            ageLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            submitBtn.BackColor = System.Drawing.Color.Transparent;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
