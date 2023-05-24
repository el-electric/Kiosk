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
    public partial class frmSelectMember : Form
    {
        public frmSelectMember()
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
        private void frmSelectMember_Load(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_back, Properties.Resources.wev02_img_btn_back_normal, Properties.Resources.wev02_img_btn_back_normal_clicked, btn_back.SizeMode);
            buttonManager = new ButtonManager(btn_home, Properties.Resources.wev02_img_btn_home_normal, Properties.Resources.wev02_img_btn_home_clicked, btn_home.SizeMode);
            buttonManager = new ButtonManager(btn_member, Properties.Resources.wev02_horizontal_img_btn_membertype_normal, Properties.Resources.wev02_horizontal_img_btn_membertype_clicked, btn_member.SizeMode);
            buttonManager = new ButtonManager(btn_nomember, Properties.Resources.wev02_horizontal_img_btn_membertype_normal, Properties.Resources.wev02_horizontal_img_btn_membertype_clicked, btn_member.SizeMode);

        }
    }
}
