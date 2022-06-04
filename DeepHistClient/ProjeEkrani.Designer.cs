
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
            this.titleAltiniTutanPanel = new System.Windows.Forms.Panel();
            this.KREAwsImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.OrtaAlan = new System.Windows.Forms.Panel();
            this.AcikRenkliPanelProjeEkraniTitleAlti = new System.Windows.Forms.Panel();
            this.KREProjectInfoList = new System.Windows.Forms.TextBox();
            this.ProjectInfosPanel = new System.Windows.Forms.Panel();
            this.KRAProjectInfosHolder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.ARETitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KRELocalImageHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.AcikRenkliUstPanelProjeEkrani.SuspendLayout();
            this.titleAltiniTutanPanel.SuspendLayout();
            this.OrtaAlan.SuspendLayout();
            this.AcikRenkliPanelProjeEkraniTitleAlti.SuspendLayout();
            this.ProjectInfosPanel.SuspendLayout();
            this.KRAProjectInfosHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnMinimized);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnMaximize);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnBack);
            this.AcikRenkliUstPanelProjeEkrani.Controls.Add(this.btnCikis);
            this.AcikRenkliUstPanelProjeEkrani.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcikRenkliUstPanelProjeEkrani.Location = new System.Drawing.Point(0, 0);
            this.AcikRenkliUstPanelProjeEkrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcikRenkliUstPanelProjeEkrani.Name = "AcikRenkliUstPanelProjeEkrani";
            this.AcikRenkliUstPanelProjeEkrani.Size = new System.Drawing.Size(1556, 42);
            this.AcikRenkliUstPanelProjeEkrani.TabIndex = 4;
            this.AcikRenkliUstPanelProjeEkrani.Paint += new System.Windows.Forms.PaintEventHandler(this.AcikRenkliUstPanelProjeEkrani_Paint);
            this.AcikRenkliUstPanelProjeEkrani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // titleAltiniTutanPanel
            // 
            this.titleAltiniTutanPanel.Controls.Add(this.splitContainer1);
            this.titleAltiniTutanPanel.Controls.Add(this.OrtaAlan);
            this.titleAltiniTutanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleAltiniTutanPanel.Location = new System.Drawing.Point(0, 42);
            this.titleAltiniTutanPanel.Name = "titleAltiniTutanPanel";
            this.titleAltiniTutanPanel.Size = new System.Drawing.Size(1556, 842);
            this.titleAltiniTutanPanel.TabIndex = 5;
            // 
            // KREAwsImageHolder
            // 
            this.KREAwsImageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KREAwsImageHolder.AutoScroll = true;
            this.KREAwsImageHolder.AutoSize = true;
            this.KREAwsImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KREAwsImageHolder.Location = new System.Drawing.Point(4, 63);
            this.KREAwsImageHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KREAwsImageHolder.Name = "KREAwsImageHolder";
            this.KREAwsImageHolder.Size = new System.Drawing.Size(749, 635);
            this.KREAwsImageHolder.TabIndex = 3;
            // 
            // OrtaAlan
            // 
            this.OrtaAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.OrtaAlan.Controls.Add(this.AcikRenkliPanelProjeEkraniTitleAlti);
            this.OrtaAlan.Controls.Add(this.ProjectInfosPanel);
            this.OrtaAlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrtaAlan.Location = new System.Drawing.Point(0, 0);
            this.OrtaAlan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrtaAlan.Name = "OrtaAlan";
            this.OrtaAlan.Size = new System.Drawing.Size(1556, 140);
            this.OrtaAlan.TabIndex = 11;
            // 
            // AcikRenkliPanelProjeEkraniTitleAlti
            // 
            this.AcikRenkliPanelProjeEkraniTitleAlti.Controls.Add(this.KREProjectInfoList);
            this.AcikRenkliPanelProjeEkraniTitleAlti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcikRenkliPanelProjeEkraniTitleAlti.Location = new System.Drawing.Point(228, 0);
            this.AcikRenkliPanelProjeEkraniTitleAlti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcikRenkliPanelProjeEkraniTitleAlti.Name = "AcikRenkliPanelProjeEkraniTitleAlti";
            this.AcikRenkliPanelProjeEkraniTitleAlti.Size = new System.Drawing.Size(1328, 140);
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
            this.KREProjectInfoList.Location = new System.Drawing.Point(49, 0);
            this.KREProjectInfoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KREProjectInfoList.Multiline = true;
            this.KREProjectInfoList.Name = "KREProjectInfoList";
            this.KREProjectInfoList.ReadOnly = true;
            this.KREProjectInfoList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KREProjectInfoList.Size = new System.Drawing.Size(1275, 137);
            this.KREProjectInfoList.TabIndex = 0;
            // 
            // ProjectInfosPanel
            // 
            this.ProjectInfosPanel.Controls.Add(this.KRAProjectInfosHolder);
            this.ProjectInfosPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectInfosPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectInfosPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectInfosPanel.Name = "ProjectInfosPanel";
            this.ProjectInfosPanel.Size = new System.Drawing.Size(228, 140);
            this.ProjectInfosPanel.TabIndex = 0;
            // 
            // KRAProjectInfosHolder
            // 
            this.KRAProjectInfosHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRAProjectInfosHolder.Controls.Add(this.label2);
            this.KRAProjectInfosHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KRAProjectInfosHolder.Location = new System.Drawing.Point(0, 0);
            this.KRAProjectInfosHolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KRAProjectInfosHolder.Name = "KRAProjectInfosHolder";
            this.KRAProjectInfosHolder.Size = new System.Drawing.Size(228, 140);
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
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Infos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 42);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button3_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
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
            this.btnCikis.Location = new System.Drawing.Point(1511, 0);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(45, 42);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::DeepHistClient.Properties.Resources.windowMaximizeWhite;
            this.btnMaximize.Location = new System.Drawing.Point(1466, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 42);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.btnMaximize_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = global::DeepHistClient.Properties.Resources.minimizeWhite;
            this.btnMinimized.Location = new System.Drawing.Point(1421, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(45, 42);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseEnter += new System.EventHandler(this.btnMinimized_MouseEnter);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            // 
            // ARETitle
            // 
            this.ARETitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ARETitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARETitle.Font = new System.Drawing.Font("Arial", 12F);
            this.ARETitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.ARETitle.Location = new System.Drawing.Point(4, 4);
            this.ARETitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ARETitle.Name = "ARETitle";
            this.ARETitle.Size = new System.Drawing.Size(787, 55);
            this.ARETitle.TabIndex = 1;
            this.ARETitle.Text = "Waiting For Backup";
            this.ARETitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backed Up Images";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KRELocalImageHolder
            // 
            this.KRELocalImageHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KRELocalImageHolder.AutoScroll = true;
            this.KRELocalImageHolder.AutoSize = true;
            this.KRELocalImageHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.KRELocalImageHolder.Location = new System.Drawing.Point(4, 63);
            this.KRELocalImageHolder.Margin = new System.Windows.Forms.Padding(4);
            this.KRELocalImageHolder.Name = "KRELocalImageHolder";
            this.KRELocalImageHolder.Size = new System.Drawing.Size(787, 639);
            this.KRELocalImageHolder.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 140);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.KRELocalImageHolder);
            this.splitContainer1.Panel1.Controls.Add(this.ARETitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.KREAwsImageHolder);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1556, 702);
            this.splitContainer1.SplitterDistance = 795;
            this.splitContainer1.TabIndex = 12;
            // 
            // ProjeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.titleAltiniTutanPanel);
            this.Controls.Add(this.AcikRenkliUstPanelProjeEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "ProjeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeEkrani";
            this.Load += new System.EventHandler(this.ProjeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.AcikRenkliUstPanelProjeEkrani.ResumeLayout(false);
            this.AcikRenkliUstPanelProjeEkrani.PerformLayout();
            this.titleAltiniTutanPanel.ResumeLayout(false);
            this.OrtaAlan.ResumeLayout(false);
            this.AcikRenkliPanelProjeEkraniTitleAlti.ResumeLayout(false);
            this.AcikRenkliPanelProjeEkraniTitleAlti.PerformLayout();
            this.ProjectInfosPanel.ResumeLayout(false);
            this.KRAProjectInfosHolder.ResumeLayout(false);
            this.KRAProjectInfosHolder.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel titleAltiniTutanPanel;
        private System.Windows.Forms.Panel OrtaAlan;
        private System.Windows.Forms.Panel KRAProjectInfosHolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KREProjectInfoList;
        private System.Windows.Forms.Panel AcikRenkliPanelProjeEkraniTitleAlti;
        private System.Windows.Forms.Panel ProjectInfosPanel;
        private System.Windows.Forms.FlowLayoutPanel KREAwsImageHolder;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ARETitle;
        private System.Windows.Forms.FlowLayoutPanel KRELocalImageHolder;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}