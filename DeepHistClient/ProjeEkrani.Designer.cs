
namespace DeepHistClient
{
    partial class ProjeEkrani
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
            this.components = new System.ComponentModel.Container();
            this.refreshAmazon = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AcikRenkliUstPanelProjeEkrani = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AcikRenkliPanelLocalProjeEkrani = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.KRELocalImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.AcikRenkliPanelAWSProjeEkrani = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.KREAwsImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AcikRenkliPanelProjeEkraniTitleAlti = new System.Windows.Forms.Panel();
            this.KREProjectInfoList = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.KRAProjectInfosHolder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.AcikRenkliUstPanelProjeEkrani.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.AcikRenkliPanelLocalProjeEkrani.SuspendLayout();
            this.AcikRenkliPanelAWSProjeEkrani.SuspendLayout();
            this.panel4.SuspendLayout();
            this.AcikRenkliPanelProjeEkraniTitleAlti.SuspendLayout();
            this.panel3.SuspendLayout();
            this.KRAProjectInfosHolder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshAmazon
            // 
            this.refreshAmazon.Enabled = true;
            this.refreshAmazon.Interval = 30300;
            this.refreshAmazon.Tick += new System.EventHandler(this.refreshAmazon_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_TickAsync);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            // 
            // AcikRenkliUstPanelProjeEkrani
            // 
            this.AcikRenkliUstPanelProjeEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnBack);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnMinimize);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnCikis);
            this.AcikRenkliUstPanelProjeEkrani.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcikRenkliUstPanelProjeEkrani.Location = new System.Drawing.Point(0, 0);
            this.AcikRenkliUstPanelProjeEkrani.Name = "AcikRenkliUstPanelProjeEkrani";
            this.AcikRenkliUstPanelProjeEkrani.Size = new System.Drawing.Size(1167, 34);
            this.AcikRenkliUstPanelProjeEkrani.TabIndex = 4;
            this.AcikRenkliUstPanelProjeEkrani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Image = global::DeepHistClient.Properties.Resources.backWhite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Image = global::DeepHistClient.Properties.Resources.minimizeWhite;
            this.btnMinimize.Location = new System.Drawing.Point(1101, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 34);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button2_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Image = global::DeepHistClient.Properties.Resources.carpiisaretiwhite;
            this.btnCikis.Location = new System.Drawing.Point(1133, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 34);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 684);
            this.panel1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.splitContainer1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1167, 570);
            this.panel7.TabIndex = 12;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AcikRenkliPanelLocalProjeEkrani);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AcikRenkliPanelAWSProjeEkrani);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 570);
            this.splitContainer1.SplitterDistance = 579;
            this.splitContainer1.TabIndex = 20;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // AcikRenkliPanelLocalProjeEkrani
            // 
            this.AcikRenkliPanelLocalProjeEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.AcikRenkliPanelLocalProjeEkrani.Controls.Add(this.panel2);
            this.AcikRenkliPanelLocalProjeEkrani.Controls.Add(this.KRELocalImageHolder);
            this.AcikRenkliPanelLocalProjeEkrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcikRenkliPanelLocalProjeEkrani.Location = new System.Drawing.Point(0, 0);
            this.AcikRenkliPanelLocalProjeEkrani.Name = "AcikRenkliPanelLocalProjeEkrani";
            this.AcikRenkliPanelLocalProjeEkrani.Size = new System.Drawing.Size(579, 570);
            this.AcikRenkliPanelLocalProjeEkrani.TabIndex = 19;
            this.AcikRenkliPanelLocalProjeEkrani.Paint += new System.Windows.Forms.PaintEventHandler(this.AcikRenkliPanelLocalProjeEkrani_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(202, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiting For Backup";
            // 
            // KRELocalImageHolder
            // 
            this.KRELocalImageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KRELocalImageHolder.AutoScroll = true;
            this.KRELocalImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRELocalImageHolder.Location = new System.Drawing.Point(3, 73);
            this.KRELocalImageHolder.Name = "KRELocalImageHolder";
            this.KRELocalImageHolder.Size = new System.Drawing.Size(574, 497);
            this.KRELocalImageHolder.TabIndex = 2;
            // 
            // AcikRenkliPanelAWSProjeEkrani
            // 
            this.AcikRenkliPanelAWSProjeEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.AcikRenkliPanelAWSProjeEkrani.Controls.Add(this.panel5);
            this.AcikRenkliPanelAWSProjeEkrani.Controls.Add(this.KREAwsImageHolder);
            this.AcikRenkliPanelAWSProjeEkrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcikRenkliPanelAWSProjeEkrani.Location = new System.Drawing.Point(0, 0);
            this.AcikRenkliPanelAWSProjeEkrani.Name = "AcikRenkliPanelAWSProjeEkrani";
            this.AcikRenkliPanelAWSProjeEkrani.Size = new System.Drawing.Size(584, 570);
            this.AcikRenkliPanelAWSProjeEkrani.TabIndex = 20;
            this.AcikRenkliPanelAWSProjeEkrani.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(217, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Backed Up Images";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // KREAwsImageHolder
            // 
            this.KREAwsImageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KREAwsImageHolder.AutoScroll = true;
            this.KREAwsImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KREAwsImageHolder.Location = new System.Drawing.Point(3, 76);
            this.KREAwsImageHolder.Name = "KREAwsImageHolder";
            this.KREAwsImageHolder.Size = new System.Drawing.Size(578, 491);
            this.KREAwsImageHolder.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.AcikRenkliPanelProjeEkraniTitleAlti);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1167, 114);
            this.panel4.TabIndex = 11;
            // 
            // AcikRenkliPanelProjeEkraniTitleAlti
            // 
            this.AcikRenkliPanelProjeEkraniTitleAlti.Controls.Add(this.KREProjectInfoList);
            this.AcikRenkliPanelProjeEkraniTitleAlti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcikRenkliPanelProjeEkraniTitleAlti.Location = new System.Drawing.Point(171, 0);
            this.AcikRenkliPanelProjeEkraniTitleAlti.Name = "AcikRenkliPanelProjeEkraniTitleAlti";
            this.AcikRenkliPanelProjeEkraniTitleAlti.Size = new System.Drawing.Size(996, 114);
            this.AcikRenkliPanelProjeEkraniTitleAlti.TabIndex = 1;
            // 
            // KREProjectInfoList
            // 
            this.KREProjectInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KREProjectInfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KREProjectInfoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KREProjectInfoList.CausesValidation = false;
            this.KREProjectInfoList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KREProjectInfoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.KREProjectInfoList.Location = new System.Drawing.Point(37, 0);
            this.KREProjectInfoList.Multiline = true;
            this.KREProjectInfoList.Name = "KREProjectInfoList";
            this.KREProjectInfoList.ReadOnly = true;
            this.KREProjectInfoList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KREProjectInfoList.Size = new System.Drawing.Size(956, 111);
            this.KREProjectInfoList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.KRAProjectInfosHolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 114);
            this.panel3.TabIndex = 0;
            // 
            // KRAProjectInfosHolder
            // 
            this.KRAProjectInfosHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRAProjectInfosHolder.Controls.Add(this.label2);
            this.KRAProjectInfosHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KRAProjectInfosHolder.Location = new System.Drawing.Point(0, 0);
            this.KRAProjectInfosHolder.Name = "KRAProjectInfosHolder";
            this.KRAProjectInfosHolder.Size = new System.Drawing.Size(171, 114);
            this.KRAProjectInfosHolder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(40, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Infos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 67);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(5, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 67);
            this.panel5.TabIndex = 4;
            // 
            // ProjeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AcikRenkliUstPanelProjeEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 661);
            this.Name = "ProjeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeEkrani";
            this.Load += new System.EventHandler(this.ProjeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.AcikRenkliUstPanelProjeEkrani.ResumeLayout(false);
            this.AcikRenkliUstPanelProjeEkrani.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.AcikRenkliPanelLocalProjeEkrani.ResumeLayout(false);
            this.AcikRenkliPanelAWSProjeEkrani.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.AcikRenkliPanelProjeEkraniTitleAlti.ResumeLayout(false);
            this.AcikRenkliPanelProjeEkraniTitleAlti.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.KRAProjectInfosHolder.ResumeLayout(false);
            this.KRAProjectInfosHolder.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Timer refreshAmazon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel AcikRenkliUstPanelProjeEkrani;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel KRAProjectInfosHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KREProjectInfoList;
        private System.Windows.Forms.Panel AcikRenkliPanelProjeEkraniTitleAlti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel AcikRenkliPanelLocalProjeEkrani;
        private System.Windows.Forms.Panel AcikRenkliPanelAWSProjeEkrani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel KREAwsImageHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel KRELocalImageHolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}