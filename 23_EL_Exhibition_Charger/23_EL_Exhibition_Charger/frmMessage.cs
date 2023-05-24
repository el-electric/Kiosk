using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_EL_Exhibition_Charger
{
    public partial class frmMessage : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private string msg = string.Empty;
        private MessageBoxIcon ico = MessageBoxIcon.None;
        private MessageBoxButtons btn = MessageBoxButtons.OK;
        private string cap = string.Empty;

        private bool dragging = false;

        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmMessage()
        {
            InitializeComponent();
        }
        public frmMessage(string Message, string Caption, MessageBoxButtons Button, MessageBoxIcon Icon)
        {
            InitializeComponent();

            this.msg = Message;
            this.ico = Icon;
            this.btn = Button;
            this.cap = Caption;

            this.Text = this.cap;


            lblCaption.Text = this.cap;

            lblMessage.Text = this.msg;



            if (this.ico == MessageBoxIcon.Asterisk || this.ico == MessageBoxIcon.Information)
            {
                picIcon.BackgroundImage = Properties.Resources.information;

                btn1.Location = new System.Drawing.Point(345, 131);

                btn1.Text = "OK";
                btn2.Text = "";
                btn3.Text = "";

                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
            }
            else if (this.ico == MessageBoxIcon.Error || this.ico == MessageBoxIcon.Hand || this.ico == MessageBoxIcon.Stop)
            {
                picIcon.BackgroundImage = Properties.Resources.error;

                btn1.Location = new System.Drawing.Point(345, 131);

                btn1.Text = "OK";
                btn2.Text = "";
                btn3.Text = "";

                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
            }
            else if (this.ico == MessageBoxIcon.Exclamation || this.ico == MessageBoxIcon.Warning)
            {
                picIcon.BackgroundImage = Properties.Resources.warning;

                btn1.Location = new System.Drawing.Point(345, 131);

                btn1.Text = "OK";
                btn2.Text = "";
                btn3.Text = "";

                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
            }
            else if (this.ico == MessageBoxIcon.Question)
            {
                picIcon.BackgroundImage = Properties.Resources.question;

                if (Button == MessageBoxButtons.AbortRetryIgnore)
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "Abort";
                    btn2.Text = "Retry";
                    btn3.Text = "Ignore";

                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }
                else if (Button == MessageBoxButtons.OKCancel)
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "";
                    btn2.Text = "OK";
                    btn3.Text = "Cancel";

                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }
                else if (Button == MessageBoxButtons.RetryCancel)
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "";
                    btn2.Text = "Retry";
                    btn3.Text = "Cancel";

                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }
                else if (Button == MessageBoxButtons.YesNo)
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "";
                    btn2.Text = "Yes";
                    btn3.Text = "No";

                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }
                else if (Button == MessageBoxButtons.YesNoCancel)
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "Yes";
                    btn2.Text = "No";
                    btn3.Text = "Cancel";

                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }
                else
                {
                    btn1.Location = new System.Drawing.Point(345, 131);

                    btn1.Text = "";
                    btn2.Text = "Yes";
                    btn3.Text = "No";

                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                }

            }
            else if (this.ico == MessageBoxIcon.None)
            {
                picIcon.BackgroundImage = null;

                btn1.Location = new System.Drawing.Point(345, 131);

                btn1.Text = "OK";
                btn2.Text = "";
                btn3.Text = "";

                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = false;
            }

            picIcon.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void lblCaption_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void lblCaption_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.btn == MessageBoxButtons.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (this.btn == MessageBoxButtons.YesNoCancel)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else if (this.btn == MessageBoxButtons.AbortRetryIgnore)
            {
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.btn == MessageBoxButtons.OKCancel)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (this.btn == MessageBoxButtons.YesNo)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else if (this.btn == MessageBoxButtons.YesNoCancel)
            {
                this.DialogResult = DialogResult.No;
            }
            else if (this.btn == MessageBoxButtons.RetryCancel)
            {
                this.DialogResult = DialogResult.Retry;
            }
            else if (this.btn == MessageBoxButtons.AbortRetryIgnore)
            {
                this.DialogResult = DialogResult.Retry;
            }
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.btn == MessageBoxButtons.OKCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.YesNo)
            {
                this.DialogResult = DialogResult.No;
            }
            else if (this.btn == MessageBoxButtons.YesNoCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.RetryCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.AbortRetryIgnore)
            {
                this.DialogResult = DialogResult.Ignore;
            }

            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (this.btn == MessageBoxButtons.OKCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.YesNo)
            {
                this.DialogResult = DialogResult.No;
            }
            else if (this.btn == MessageBoxButtons.YesNoCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.RetryCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else if (this.btn == MessageBoxButtons.AbortRetryIgnore)
            {
                this.DialogResult = DialogResult.Ignore;
            }

            this.Close();
        }
    }
}
