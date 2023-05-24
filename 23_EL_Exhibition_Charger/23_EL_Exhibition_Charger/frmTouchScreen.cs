using _23_EL_Exhibition_Charger.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_EL_Exhibition_Charger
{
    public partial class frmTouchScreen : Form
    {
        private string _test;
        public string test
        {
            get { return _test; }
            set
            {
                _test = value;
                updateLabelText(_test, label2);
            }
        }
        delegate void updateLabelTextDelegate(string newText, Label lbl);
        private void updateLabelText(string newText, Label lbl)
        {
            if (lbl.InvokeRequired)
            {
                // this is worker thread
                updateLabelTextDelegate del = new updateLabelTextDelegate(updateLabelText);
                lbl.Invoke(del, new object[] { newText });
            }
            else
            {
                // this is UI thread
                lbl.Text = newText;
            }
        }

        public frmTouchScreen()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                //cp.ExStyle |= 0x00080000;
                return cp;
            }
        }
        private void frmTouchScreen_Load(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_start, Properties.Resources.Group_255, Properties.Resources.Group_256);
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
