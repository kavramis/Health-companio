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
        public DietForm()
        {
            InitializeComponent();
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
    }
}
