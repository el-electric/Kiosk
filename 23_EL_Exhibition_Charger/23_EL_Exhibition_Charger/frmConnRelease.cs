﻿using _23_EL_Exhibition_Charger.Common;
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
    public partial class frmConnRelease : Form
    {
        List<Image> list_img = new List<Image>();
        public frmConnRelease()
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

        private void frmConnRelease_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
                list_img.Add((Image)Properties.Resources.ResourceManager.GetObject("wev02_img_progress_disconnectconnector_0" + i, System.Globalization.CultureInfo.CurrentUICulture));
        }
        int step = 0;
        private void ui_timer_500ms_Tick(object sender, EventArgs e)
        {
            pb_progress.Image = list_img[step];
            step++;
            if (step == 4)
                step = 0;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ButtonManager buttonManager = new ButtonManager(btn_home, Properties.Resources.wev02_img_btn_home_normal, Properties.Resources.wev02_img_btn_home_clicked, btn_home.SizeMode);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmMain.del_formChange(CsDefine.Complete);
        }
    }
}
