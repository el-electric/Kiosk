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

    public partial class frmComplete : Form
    {
        public Stopwatch sw = new Stopwatch();
        public frmComplete()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void frmComplete_Load(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_home, Properties.Resources.wev02_img_btn_home_normal, Properties.Resources.wev02_img_btn_home_clicked, btn_home.SizeMode);
        }

        private void ui_timer_100ms_Tick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds >= 5000)
            {
                frmMain.del_formChange(CsDefine.TouchScreen);
            }
            
        }
    }
}
