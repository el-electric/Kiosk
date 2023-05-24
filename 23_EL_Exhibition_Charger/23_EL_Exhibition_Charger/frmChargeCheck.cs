using _23_EL_Exhibition_Charger.Common;
using _23_EL_Exhibition_Charger.Properties;
using DrakeUI.Framework;
using System;
using System.Collections;
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
    public partial class frmChargeCheck : Form
    {
        public Stopwatch sw = new Stopwatch();

        //프로그레스 이미지        
        List<PictureBox> list_pb = new List<PictureBox>();
        public frmChargeCheck()
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

        private void frmChargeCheck_Load(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_back, Properties.Resources.wev02_img_btn_back_normal, Properties.Resources.wev02_img_btn_back_normal_clicked,btn_back.SizeMode);
            buttonManager = new ButtonManager(btn_home, Properties.Resources.wev02_img_btn_home_normal, Properties.Resources.wev02_img_btn_home_clicked, btn_home.SizeMode);


            //for (int i = 0; i < 5; i++)
            //{
            //    var pb = this.Controls.Find("pb_progress" + i, true).FirstOrDefault();
            //    list_pb.Add((PictureBox)pb);
            //}
        }


        public int progressImgIdx = 0;
        bool reverse = false;
        string beforeTime;
        private void ui_timer_100ms_Tick(object sender, EventArgs e)
        {            
            label_remaintime.Text = (100 - sw.ElapsedMilliseconds / 1000).ToString();

            // 초가 바뀌면
            if (!label_remaintime.Text.Equals(beforeTime))
            {
                beforeTime = label_remaintime.Text;
                progressStep(progressImgIdx);
                progressImgIdx++;
                if (progressImgIdx == 10)
                {
                    progressImgIdx = 0;
                    reverse = !reverse;
                }

                //5 0 0 0 0
                //4 5 0 0 0
                //3 4 5 0 0
                //2 3 4 5 0
                //1 2 3 4 5
                //0 1 2 3 4
            }

        }

        private void progressStep(int step)
        {
            switch (step)
            {
                case 0:

                    if (!reverse)
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    else
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_05;
                    }

                    break;
                case 1:
                    if (!reverse)
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    else
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_04;
                    }
                    break;
                case 2:
                    if (!reverse)
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    else
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_03;
                    }
                    break;
                case 3:
                    if (!reverse)
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress4.Image = null;
                    }
                    else
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_02;
                    }
                    break;
                case 4:
                    if (!reverse)
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_05;
                    }
                    else
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_05;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_01;
                    }
                    break;
                case 5:
                    if (!reverse)
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_04;
                    }
                    else
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_04;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress4.Image = null;
                    }
                    break;
                case 6:
                    if (!reverse)
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_03;
                    }
                    else
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_03;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress2.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    break;
                case 7:
                    if (!reverse)
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_02;
                    }
                    else
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_02;
                        pb_progress1.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }

                    break;
                case 8:
                    if (!reverse)
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = Properties.Resources.wev02_img_icon_progress_01;
                    }
                    else
                    {
                        pb_progress0.Image = Properties.Resources.wev02_img_icon_progress_01;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }

                    break;
                case 9:
                    if (!reverse)
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    else
                    {
                        pb_progress0.Image = null;
                        pb_progress1.Image = null;
                        pb_progress2.Image = null;
                        pb_progress3.Image = null;
                        pb_progress4.Image = null;
                    }
                    break;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmMain.del_formChange(CsDefine.ConnJoin);
        }
    }
}
