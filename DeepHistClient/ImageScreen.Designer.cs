
namespace DeepHistClient
{
    partial class ImageScreen
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
            this.KRETitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ImageHolder = new System.Windows.Forms.Panel();
            this.PictureboxImage = new System.Windows.Forms.PictureBox();
            this.KRETitle.SuspendLayout();
            this.ImageHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // KRETitle
            // 
            this.KRETitle.Controls.Add(this.label1);
            this.KRETitle.Controls.Add(this.btnMinimize);
            this.KRETitle.Controls.Add(this.ExitButton);
            this.KRETitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.KRETitle.Location = new System.Drawing.Point(0, 0);
            this.KRETitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KRETitle.Name = "KRETitle";
            this.KRETitle.Size = new System.Drawing.Size(768, 31);
            this.KRETitle.TabIndex = 0;
            this.KRETitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KRETitle_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(143)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::DeepHistClient.Properties.Resources.minimizeWhite;
            this.btnMinimize.Location = new System.Drawing.Point(700, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 31);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::DeepHistClient.Properties.Resources.carpiisaretiwhite;
            this.ExitButton.Location = new System.Drawing.Point(734, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 31);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // ImageHolder
            // 
            this.ImageHolder.Controls.Add(this.PictureboxImage);
            this.ImageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageHolder.Location = new System.Drawing.Point(0, 31);
            this.ImageHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(768, 593);
            this.ImageHolder.TabIndex = 2;
            // 
            // PictureboxImage
            // 
            this.PictureboxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureboxImage.Location = new System.Drawing.Point(0, 0);
            this.PictureboxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureboxImage.Name = "PictureboxImage";
            this.PictureboxImage.Size = new System.Drawing.Size(768, 593);
            this.PictureboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxImage.TabIndex = 0;
            this.PictureboxImage.TabStop = false;
            // 
            // ImageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(768, 624);
            this.Controls.Add(this.ImageHolder);
            this.Controls.Add(this.KRETitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(768, 624);
            this.Name = "ImageScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageScreen";
            this.Load += new System.EventHandler(this.ImageScreen_Load);
            this.KRETitle.ResumeLayout(false);
            this.ImageHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KRETitle;
        private System.Windows.Forms.Panel ImageHolder;
        private System.Windows.Forms.PictureBox PictureboxImage;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
    }
}