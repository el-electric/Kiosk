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
    public partial class frmMain : Form
    {
        Image[] imagePaths_Ads = new Image[6];

        public delegate void delFormChange(string formName);
        public static event delFormChange evtFormChange;

        frmTouchScreen frmTouchScreen = new frmTouchScreen();
        frmSelectMember frmSelectMember = new frmSelectMember();
        frmChargeCheck frmChargeCheck = new frmChargeCheck();
        frmConnJoin frmConnJoin = new frmConnJoin();
        frmCharging frmCharging = new frmCharging();
        frmConnRelease frmConnRelease = new frmConnRelease();
        frmComplete frmComplete = new frmComplete();

        public frmMain()
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            formInit();
            evtFormChange += formChange;


            formChange(CsDefine.TouchScreen);


            for (int i = 0; i < 6; i++)
                imagePaths_Ads[i] = ((Image)Properties.Resources.ResourceManager.GetObject("p1080_1920_ad_0" + (i + 1), System.Globalization.CultureInfo.CurrentUICulture));

            //테스트용
            Screen[] scr = Screen.AllScreens;
            if (scr.Length > 1)
            {
                Screen screen = (scr[0].WorkingArea.Contains(this.Location)) ? scr[1] : scr[0]; // 현재모니터 찾기
                this.Location = screen.Bounds.Location; // 모니터위치 변경
            }
        }

        private void formInit()
        {
            frmTouchScreen.TopLevel = false;
            frmSelectMember.TopLevel = false;
            frmChargeCheck.TopLevel = false;
            frmConnJoin.TopLevel = false;
            frmCharging.TopLevel = false;
            frmComplete.TopLevel = false;
            frmConnRelease.TopLevel = false;

            frmTouchScreen.Show();
            frmSelectMember.Show();
            frmChargeCheck.Show();
            frmConnJoin.Show();
            frmCharging.Show();
            frmComplete.Show();
            frmConnRelease.Show();
        }

        public static void del_formChange(string formName)
        {
            //member_yn 기본값 true = 회원
            evtFormChange(formName);


        }
        int zz = 0;
        private void formChange(string formName)
        {
            panel1.Controls.Clear();

            frmChargeCheck.ui_timer_100ms.Enabled = false;
            frmConnJoin.ui_timer_500ms.Enabled = false;
            frmConnRelease.ui_timer_500ms.Enabled = false;

            frmChargeCheck.sw.Stop();
            frmComplete.sw.Stop();
            frmComplete.ui_timer_100ms.Enabled = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Restart();

            switch (formName)
            {
                case "TouchScreen":
                    panel1.Controls.Add(frmTouchScreen);
                    break;
                case "SelectMember":
                    panel1.Controls.Add(frmSelectMember);
                    break;
                case "ChargeCheck":
                    frmChargeCheck.progressImgIdx = 0;
                    frmChargeCheck.ui_timer_100ms.Enabled = true;
                    frmChargeCheck.sw.Restart();
                    panel1.Controls.Add(frmChargeCheck);
                    break;
                case "Charging":
                    panel1.Controls.Add(frmCharging);
                    break;
                case "ConnJoin":
                    frmConnJoin.ui_timer_500ms.Enabled = true;
                    panel1.Controls.Add(frmConnJoin);
                    break;
                case "ConnRelease":
                    frmConnRelease.ui_timer_500ms.Enabled = true;
                    panel1.Controls.Add(frmConnRelease);
                    break;

                case "Complete":
                    frmComplete.sw.Restart();
                    frmComplete.ui_timer_100ms.Enabled = true;
                    panel1.Controls.Add(frmComplete);
                    break;
            }
            CsDefine.lastFormName = formName;
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            //    notifyIcon1.Visible = true;
            //this.Size = new Size(10, 10);

            //WindowState = FormWindowState.Minimized;

        }

        int imgIdx = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imagePaths_Ads[imgIdx];

            imgIdx++;
            if (imgIdx == 6)
                imgIdx = 0;



        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
