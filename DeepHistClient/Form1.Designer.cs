
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picturePassword = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.IconForCorp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconForCorp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(100, 364);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 38);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordPanel.Location = new System.Drawing.Point(100, 304);
            this.passwordPanel.Margin = new System.Windows.Forms.Padding(6);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(200, 1);
            this.passwordPanel.TabIndex = 20;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSifre.HideSelection = false;
            this.txtSifre.Location = new System.Drawing.Point(129, 279);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(6);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(170, 18);
            this.txtSifre.TabIndex = 18;
            this.txtSifre.TabStop = false;
            this.txtSifre.Text = "abc";
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click_1);
            this.txtSifre.MouseEnter += new System.EventHandler(this.txtSifre_MouseEnter);
            this.txtSifre.MouseLeave += new System.EventHandler(this.txtSifre_MouseLeave);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.Location = new System.Drawing.Point(100, 417);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(200, 38);
            this.BtnCikis.TabIndex = 14;
            this.BtnCikis.Text = "EXIT";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            this.BtnCikis.MouseEnter += new System.EventHandler(this.BtnCikis_MouseEnter);
            this.BtnCikis.MouseLeave += new System.EventHandler(this.BtnCikis_MouseLeave);
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userPanel.Location = new System.Drawing.Point(100, 244);
            this.userPanel.Margin = new System.Windows.Forms.Padding(6);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 1);
            this.userPanel.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(129, 219);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 18);
            this.txtId.TabIndex = 12;
            this.txtId.TabStop = false;
            this.txtId.Text = "deepHist";
            this.txtId.Click += new System.EventHandler(this.txtId_Click_1);
            this.txtId.MouseEnter += new System.EventHandler(this.txtId_MouseEnter);
            this.txtId.MouseLeave += new System.EventHandler(this.txtId_MouseLeave);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.Copyright.Location = new System.Drawing.Point(59, 526);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(289, 19);
            this.Copyright.TabIndex = 21;
            this.Copyright.Text = "Copyright © 2022 All Right Reserved.";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.Version.Location = new System.Drawing.Point(165, 564);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(73, 16);
            this.Version.TabIndex = 22;
            this.Version.Text = "Version 1.0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // picturePassword
            // 
            this.picturePassword.BackgroundImage = global::DeepHistClient.Properties.Resources.password_white;
            this.picturePassword.InitialImage = null;
            this.picturePassword.Location = new System.Drawing.Point(99, 273);
            this.picturePassword.Margin = new System.Windows.Forms.Padding(6);
            this.picturePassword.Name = "picturePassword";
            this.picturePassword.Size = new System.Drawing.Size(24, 24);
            this.picturePassword.TabIndex = 19;
            this.picturePassword.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackgroundImage = global::DeepHistClient.Properties.Resources.user_white;
            this.pictureUser.InitialImage = null;
            this.pictureUser.Location = new System.Drawing.Point(99, 213);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(6);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(24, 24);
            this.pictureUser.TabIndex = 16;
            this.pictureUser.TabStop = false;
            // 
            // IconForCorp
            // 
            this.IconForCorp.BackgroundImage = global::DeepHistClient.Properties.Resources.deephistlogo;
            this.IconForCorp.ErrorImage = null;
            this.IconForCorp.InitialImage = null;
            this.IconForCorp.Location = new System.Drawing.Point(129, 29);
            this.IconForCorp.Margin = new System.Windows.Forms.Padding(6);
            this.IconForCorp.Name = "IconForCorp";
            this.IconForCorp.Size = new System.Drawing.Size(128, 128);
            this.IconForCorp.TabIndex = 13;
            this.IconForCorp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.picturePassword);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.IconForCorp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.picturePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconForCorp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox picturePassword;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.PictureBox IconForCorp;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

