
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
            this.readJsonTimers = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AcikRenkliUstPanelProjeEkrani = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.titleAltiniTutanPanel = new System.Windows.Forms.Panel();
            this.MainContentHolder = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imagesSplitContainerHolder = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.KRELocalImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.KREAwsImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.underProgressBarPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ARETitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titles = new System.Windows.Forms.Panel();
            this.KREProjectInfoList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KRAProjectInfosHolder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.AcikRenkliUstPanelProjeEkrani.SuspendLayout();
            this.titleAltiniTutanPanel.SuspendLayout();
            this.MainContentHolder.SuspendLayout();
            this.panel5.SuspendLayout();
            this.imagesSplitContainerHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.underProgressBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.titles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.KRAProjectInfosHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshAmazon
            // 
            this.refreshAmazon.Enabled = true;
            this.refreshAmazon.Interval = 60000;
            this.refreshAmazon.Tick += new System.EventHandler(this.refreshAmazon_TickAsync);
            // 
            // readJsonTimers
            // 
            this.readJsonTimers.Enabled = true;
            this.readJsonTimers.Interval = 10000;
            this.readJsonTimers.Tick += new System.EventHandler(this.timer2_TickAsync);
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
            this.AcikRenkliUstPanelProjeEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnMinimized);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnMaximize);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnBack);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnCikis);
            this.AcikRenkliUstPanelProjeEkrani.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcikRenkliUstPanelProjeEkrani.Location = new System.Drawing.Point(0, 0);
            this.AcikRenkliUstPanelProjeEkrani.Name = "AcikRenkliUstPanelProjeEkrani";
            this.AcikRenkliUstPanelProjeEkrani.Size = new System.Drawing.Size(1024, 28);
            this.AcikRenkliUstPanelProjeEkrani.TabIndex = 4;
            this.AcikRenkliUstPanelProjeEkrani.Paint += new System.Windows.Forms.PaintEventHandler(this.AcikRenkliUstPanelProjeEkrani_Paint);
            this.AcikRenkliUstPanelProjeEkrani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = global::DeepHistClient.Properties.Resources.minimizeWhite;
            this.btnMinimized.Location = new System.Drawing.Point(922, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(34, 28);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseEnter += new System.EventHandler(this.btnMinimized_MouseEnter);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::DeepHistClient.Properties.Resources.windowMaximizeWhite;
            this.btnMaximize.Location = new System.Drawing.Point(956, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(34, 28);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.btnMaximize_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Image = global::DeepHistClient.Properties.Resources.backWhite;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_ClickAsync);
            this.btnBack.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCikis.Image = global::DeepHistClient.Properties.Resources.carpiisaretiwhite;
            this.btnCikis.Location = new System.Drawing.Point(990, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(34, 28);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // titleAltiniTutanPanel
            // 
            this.titleAltiniTutanPanel.Controls.Add(this.MainContentHolder);
            this.titleAltiniTutanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleAltiniTutanPanel.Location = new System.Drawing.Point(0, 28);
            this.titleAltiniTutanPanel.Margin = new System.Windows.Forms.Padding(2);
            this.titleAltiniTutanPanel.Name = "titleAltiniTutanPanel";
            this.titleAltiniTutanPanel.Size = new System.Drawing.Size(1024, 596);
            this.titleAltiniTutanPanel.TabIndex = 5;
            // 
            // MainContentHolder
            // 
            this.MainContentHolder.Controls.Add(this.panel5);
            this.MainContentHolder.Controls.Add(this.titles);
            this.MainContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentHolder.Location = new System.Drawing.Point(0, 0);
            this.MainContentHolder.Margin = new System.Windows.Forms.Padding(2);
            this.MainContentHolder.Name = "MainContentHolder";
            this.MainContentHolder.Size = new System.Drawing.Size(1024, 596);
            this.MainContentHolder.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.imagesSplitContainerHolder);
            this.panel5.Controls.Add(this.underProgressBarPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 532);
            this.panel5.TabIndex = 4;
            // 
            // imagesSplitContainerHolder
            // 
            this.imagesSplitContainerHolder.Controls.Add(this.splitContainer1);
            this.imagesSplitContainerHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesSplitContainerHolder.Location = new System.Drawing.Point(0, 63);
            this.imagesSplitContainerHolder.Name = "imagesSplitContainerHolder";
            this.imagesSplitContainerHolder.Size = new System.Drawing.Size(1024, 469);
            this.imagesSplitContainerHolder.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.KRELocalImageHolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KREAwsImageHolder);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 469);
            this.splitContainer1.SplitterDistance = 510;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // KRELocalImageHolder
            // 
            this.KRELocalImageHolder.AutoScroll = true;
            this.KRELocalImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRELocalImageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KRELocalImageHolder.Location = new System.Drawing.Point(0, 0);
            this.KRELocalImageHolder.Name = "KRELocalImageHolder";
            this.KRELocalImageHolder.Size = new System.Drawing.Size(510, 469);
            this.KRELocalImageHolder.TabIndex = 2;
            this.KRELocalImageHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.KRELocalImageHolder_Paint);
            // 
            // KREAwsImageHolder
            // 
            this.KREAwsImageHolder.AutoScroll = true;
            this.KREAwsImageHolder.AutoSize = true;
            this.KREAwsImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KREAwsImageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KREAwsImageHolder.Location = new System.Drawing.Point(0, 0);
            this.KREAwsImageHolder.Name = "KREAwsImageHolder";
            this.KREAwsImageHolder.Size = new System.Drawing.Size(513, 469);
            this.KREAwsImageHolder.TabIndex = 3;
            this.KREAwsImageHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.KREAwsImageHolder_Paint);
            // 
            // underProgressBarPanel
            // 
            this.underProgressBarPanel.Controls.Add(this.splitContainer2);
            this.underProgressBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.underProgressBarPanel.Location = new System.Drawing.Point(0, 0);
            this.underProgressBarPanel.Name = "underProgressBarPanel";
            this.underProgressBarPanel.Size = new System.Drawing.Size(1024, 63);
            this.underProgressBarPanel.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ARETitle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(1024, 63);
            this.splitContainer2.SplitterDistance = 510;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            // 
            // ARETitle
            // 
            this.ARETitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ARETitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARETitle.Font = new System.Drawing.Font("Arial", 12F);
            this.ARETitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.ARETitle.Location = new System.Drawing.Point(0, 0);
            this.ARETitle.Name = "ARETitle";
            this.ARETitle.Size = new System.Drawing.Size(510, 63);
            this.ARETitle.TabIndex = 1;
            this.ARETitle.Text = "Waiting For Back Up";
            this.ARETitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ARETitle.Click += new System.EventHandler(this.ARETitle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backed Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titles
            // 
            this.titles.Controls.Add(this.KREProjectInfoList);
            this.titles.Controls.Add(this.panel1);
            this.titles.Dock = System.Windows.Forms.DockStyle.Top;
            this.titles.Location = new System.Drawing.Point(0, 0);
            this.titles.Margin = new System.Windows.Forms.Padding(2);
            this.titles.Name = "titles";
            this.titles.Size = new System.Drawing.Size(1024, 64);
            this.titles.TabIndex = 0;
            // 
            // KREProjectInfoList
            // 
            this.KREProjectInfoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KREProjectInfoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KREProjectInfoList.CausesValidation = false;
            this.KREProjectInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KREProjectInfoList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KREProjectInfoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.KREProjectInfoList.Location = new System.Drawing.Point(200, 0);
            this.KREProjectInfoList.Multiline = true;
            this.KREProjectInfoList.Name = "KREProjectInfoList";
            this.KREProjectInfoList.ReadOnly = true;
            this.KREProjectInfoList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KREProjectInfoList.Size = new System.Drawing.Size(824, 64);
            this.KREProjectInfoList.TabIndex = 0;
            this.KREProjectInfoList.TextChanged += new System.EventHandler(this.KREProjectInfoList_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.KRAProjectInfosHolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 64);
            this.panel1.TabIndex = 0;
            // 
            // KRAProjectInfosHolder
            // 
            this.KRAProjectInfosHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRAProjectInfosHolder.Controls.Add(this.label2);
            this.KRAProjectInfosHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.KRAProjectInfosHolder.Location = new System.Drawing.Point(0, 0);
            this.KRAProjectInfosHolder.Name = "KRAProjectInfosHolder";
            this.KRAProjectInfosHolder.Size = new System.Drawing.Size(200, 64);
            this.KRAProjectInfosHolder.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ProjeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.titleAltiniTutanPanel);
            this.Controls.Add(this.AcikRenkliUstPanelProjeEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 624);
            this.Name = "ProjeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeEkrani";
            this.Load += new System.EventHandler(this.ProjeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.AcikRenkliUstPanelProjeEkrani.ResumeLayout(false);
            this.AcikRenkliUstPanelProjeEkrani.PerformLayout();
            this.titleAltiniTutanPanel.ResumeLayout(false);
            this.MainContentHolder.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.imagesSplitContainerHolder.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.underProgressBarPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.titles.ResumeLayout(false);
            this.titles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.KRAProjectInfosHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Timer refreshAmazon;
        private System.Windows.Forms.Timer readJsonTimers;
        private System.Windows.Forms.Timer timer3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel AcikRenkliUstPanelProjeEkrani;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel titleAltiniTutanPanel;
        private System.Windows.Forms.FlowLayoutPanel KREAwsImageHolder;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.FlowLayoutPanel KRELocalImageHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ARETitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel titles;
        private System.Windows.Forms.TextBox KREProjectInfoList;
        private System.Windows.Forms.Panel KRAProjectInfosHolder;
        private System.Windows.Forms.Panel MainContentHolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel imagesSplitContainerHolder;
        private System.Windows.Forms.Panel underProgressBarPanel;
    }
}