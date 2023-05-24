using _23_EL_Exhibition_Charger.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_EL_Exhibition_Charger
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CsUtil.RegiAdd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CsUtil.RegiDelete();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CsUtil.RegiCheck();
        }
    }
}
