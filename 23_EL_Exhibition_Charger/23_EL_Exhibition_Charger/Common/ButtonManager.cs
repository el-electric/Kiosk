using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _23_EL_Exhibition_Charger.Common
{
    public class ButtonManager
    {
        protected PictureBox mPb = null;
        protected Panel mPn = null;
        protected Image mImage_Normal = null;
        protected Image mImage_Click = null;
        public ButtonManager(PictureBox pb, Image normal, Image click, PictureBoxSizeMode mode = PictureBoxSizeMode.Zoom)
        {
            mPb = pb;
            mPb.SizeMode = mode;
            mImage_Normal = normal;
            mImage_Click = click;

            mPb.Click += MPb_Click;
            mPb.MouseEnter += MPb_MouseEnter;
            mPb.MouseLeave += MPb_MouseLeave;
            mPb.MouseUp += MPb_MouseUp;
        }
        private void MPb_MouseUp(object sender, MouseEventArgs e)
        {
            mPb.Image = mImage_Normal;
        }

        private void MPb_MouseLeave(object sender, EventArgs e)
        {
            mPb.Image = mImage_Normal;
        }

        private void MPb_MouseEnter(object sender, EventArgs e)
        {
            mPb.Image = mImage_Click;
        }

        private void MPb_Click(object sender, EventArgs e)
        {
            mPb.Image = mImage_Click;
            string name = ((PictureBox)sender).Name;
            switch (name)
            {
                case "btn_start":
                    frmMain.del_formChange(CsDefine.SelectMember);
                    break;
                case "btn_back":
                    frmMain.del_formChange(CsDefine.lastFormName);
                    break;
                case "btn_home":
                    frmMain.del_formChange(CsDefine.TouchScreen);
                    break;
                case "btn_member":
                    frmMain.del_formChange(CsDefine.ChargeCheck);
                    break;
                case "btn_nomember":
                    frmMain.del_formChange(CsDefine.ChargeCheck);
                    break;
            }
        }
    }
}
