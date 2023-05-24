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
    public partial class frmCharging : Form
    {
        //#region 테스트용
        //private string _chargingtime, _leftTime, _amount, _ChargingEp;

        //public string ChargingTime
        //{
        //    get { return _chargingtime; }
        //    set
        //    {
        //        _chargingtime = value;
        //        updateLabelText(_chargingtime, lbl_chargingtime);
        //    }
        //}
        //public string LeftTime
        //{
        //    get { return _leftTime; }
        //    set
        //    {
        //        _leftTime = value;
        //        updateLabelText(_leftTime, lbl_leftTime);
        //    }
        //}
        //public string Amount
        //{
        //    get { return _amount; }
        //    set
        //    {
        //        _amount = value;
        //        updateLabelText(_amount, lbl_amount);
        //    }
        //}
        //public string ChargingEp
        //{
        //    get { return _ChargingEp; }
        //    set
        //    {
        //        _ChargingEp = value;
        //        updateLabelText(_ChargingEp, lbl_ChargingEp);
        //    }
        //}
        //delegate void updateLabelTextDelegate(string newText, Label lbl);
        //private void updateLabelText(string newText, Label lbl)
        //{
        //    if (lbl.InvokeRequired)
        //    {
        //        // this is worker thread
        //        updateLabelTextDelegate del = new updateLabelTextDelegate(updateLabelText);
        //        lbl.Invoke(del, new object[] { newText });
        //    }
        //    else
        //    {
        //        // this is UI thread
        //        lbl.Text = newText;
        //    }
        //}
        //#endregion


        public frmCharging()
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

        private void frmCharging_Load(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_back, Properties.Resources.wev02_img_btn_back_normal, Properties.Resources.wev02_img_btn_back_normal_clicked, btn_back.SizeMode);
            buttonManager = new ButtonManager(btn_home, Properties.Resources.wev02_img_btn_home_normal, Properties.Resources.wev02_img_btn_home_clicked, btn_home.SizeMode);
            buttonManager = new ButtonManager(pictureBox_chargingstop, Properties.Resources.we02_img_btn_charginstop_normal, Properties.Resources.we02_img_btn_charginstop_click1, pictureBox_chargingstop.SizeMode);


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMain.del_formChange(CsDefine.ConnRelease);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmMain.del_formChange(CsDefine.ConnRelease);
        }
    }
}
