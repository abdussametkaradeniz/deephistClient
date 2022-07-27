
namespace DeepHistClient
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.IconForCorp = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconForCorp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.IconForCorp);
            this.panel3.Controls.Add(this.Version);
            this.panel3.Controls.Add(this.BtnCikis);
            this.panel3.Controls.Add(this.picturePassword);
            this.panel3.Controls.Add(this.Copyright);
            this.panel3.Controls.Add(this.txtSifre);
            this.panel3.Controls.Add(this.pictureUser);
            this.panel3.Controls.Add(this.userPanel);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.passwordPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 600);
            this.panel3.TabIndex = 35;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(105, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 38);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // IconForCorp
            // 
            this.IconForCorp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconForCorp.BackgroundImage = global::DeepHistClient.Properties.Resources.deephistlogo;
            this.IconForCorp.ErrorImage = null;
            this.IconForCorp.InitialImage = null;
            this.IconForCorp.Location = new System.Drawing.Point(140, 20);
            this.IconForCorp.Margin = new System.Windows.Forms.Padding(6);
            this.IconForCorp.Name = "IconForCorp";
            this.IconForCorp.Size = new System.Drawing.Size(140, 140);
            this.IconForCorp.TabIndex = 24;
            this.IconForCorp.TabStop = false;
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.Version.Location = new System.Drawing.Point(167, 537);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(92, 19);
            this.Version.TabIndex = 33;
            this.Version.Text = "Version 1.0";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.Location = new System.Drawing.Point(105, 400);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(200, 38);
            this.BtnCikis.TabIndex = 25;
            this.BtnCikis.Text = "EXIT";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            this.BtnCikis.MouseEnter += new System.EventHandler(this.BtnCikis_MouseEnter);
            this.BtnCikis.MouseLeave += new System.EventHandler(this.BtnCikis_MouseLeave);
            // 
            // picturePassword
            // 
            this.picturePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePassword.BackgroundImage = global::DeepHistClient.Properties.Resources.password_white;
            this.picturePassword.InitialImage = null;
            this.picturePassword.Location = new System.Drawing.Point(105, 255);
            this.picturePassword.Margin = new System.Windows.Forms.Padding(6);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(25, 24);
            this.picturePassword.TabIndex = 30;
            this.picturePassword.TabStop = false;
            // 
            // Copyright
            // 
            this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.Copyright.Location = new System.Drawing.Point(60, 499);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(359, 24);
            this.Copyright.TabIndex = 32;
            this.Copyright.Text = "Copyright © 2022 All Right Reserved.";
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSifre.HideSelection = false;
            this.txtSifre.Location = new System.Drawing.Point(135, 258);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(6);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(170, 22);
            this.txtSifre.TabIndex = 29;
            this.txtSifre.TabStop = false;
            this.txtSifre.Text = "abc";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.MouseEnter += new System.EventHandler(this.txtSifre_MouseEnter);
            this.txtSifre.MouseLeave += new System.EventHandler(this.txtSifre_MouseLeave);
            // 
            // pictureUser
            // 
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUser.BackgroundImage = global::DeepHistClient.Properties.Resources.user_white;
            this.pictureUser.InitialImage = null;
            this.pictureUser.Location = new System.Drawing.Point(105, 193);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(6);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(25, 24);
            this.pictureUser.TabIndex = 27;
            this.pictureUser.TabStop = false;
            // 
            // userPanel
            // 
            this.userPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userPanel.Location = new System.Drawing.Point(105, 222);
            this.userPanel.Margin = new System.Windows.Forms.Padding(6);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 1);
            this.userPanel.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(135, 197);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 22);
            this.txtId.TabIndex = 23;
            this.txtId.TabStop = false;
            this.txtId.Text = "deepHist";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            this.txtId.Enter += new System.EventHandler(this.txtId_Enter);
            this.txtId.MouseEnter += new System.EventHandler(this.txtId_MouseEnter);
            this.txtId.MouseLeave += new System.EventHandler(this.txtId_MouseLeave);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordPanel.Location = new System.Drawing.Point(105, 285);
            this.passwordPanel.Margin = new System.Windows.Forms.Padding(6);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(200, 1);
            this.passwordPanel.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 600);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DeepHistClient.Properties.Resources.dna2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 2000;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconForCorp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox IconForCorp;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

