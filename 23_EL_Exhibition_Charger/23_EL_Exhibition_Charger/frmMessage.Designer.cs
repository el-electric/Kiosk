namespace _23_EL_Exhibition_Charger
{
    partial class frmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btn_exit = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btn3 = new DrakeUI.Framework.DrakeUIButton();
            this.btn2 = new DrakeUI.Framework.DrakeUIButton();
            this.btn1 = new DrakeUI.Framework.DrakeUIButton();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Font = new System.Drawing.Font("굴림", 14F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(61)))), ((int)(((byte)(239)))));
            this.lblMessage.Location = new System.Drawing.Point(82, 51);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(500, 77);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.Text = "레지스트리 등록 완료";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.DarkGray;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.btn_exit);
            this.pnlTitle.Controls.Add(this.lblCaption);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(600, 30);
            this.pnlTitle.TabIndex = 21;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_exit.Location = new System.Drawing.Point(556, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_exit.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn_exit.Size = new System.Drawing.Size(33, 24);
            this.btn_exit.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btn_exit.Symbol = 61453;
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(544, 28);
            this.lblCaption.TabIndex = 12;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseDown);
            this.lblCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseMove);
            this.lblCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseUp);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.Location = new System.Drawing.Point(507, 131);
            this.btn3.Name = "btn3";
            this.btn3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn3.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn3.Size = new System.Drawing.Size(75, 43);
            this.btn3.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btn3.TabIndex = 26;
            this.btn3.Text = "Cancel";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.Location = new System.Drawing.Point(426, 131);
            this.btn2.Name = "btn2";
            this.btn2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn2.Size = new System.Drawing.Size(75, 43);
            this.btn2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btn2.TabIndex = 25;
            this.btn2.Text = "No";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.Location = new System.Drawing.Point(345, 131);
            this.btn1.Name = "btn1";
            this.btn1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn1.Size = new System.Drawing.Size(75, 43);
            this.btn1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btn1.TabIndex = 24;
            this.btn1.Text = "Yes";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcon.Image = global::_23_EL_Exhibition_Charger.Properties.Resources.warning;
            this.picIcon.Location = new System.Drawing.Point(12, 51);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.TabIndex = 22;
            this.picIcon.TabStop = false;
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 180);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.picIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessage";
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlTitle;
        private DrakeUI.Framework.DrakeUIButtonIcon btn_exit;
        private System.Windows.Forms.Label lblCaption;
        private DrakeUI.Framework.DrakeUIButton btn3;
        private DrakeUI.Framework.DrakeUIButton btn2;
        private DrakeUI.Framework.DrakeUIButton btn1;
        private System.Windows.Forms.PictureBox picIcon;
    }
}