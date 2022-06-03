
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZoomPositive = new System.Windows.Forms.Button();
            this.ImageHolder = new System.Windows.Forms.Panel();
            this.PictureboxImage = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnZoomNegative = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ImageHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnZoomNegative);
            this.panel2.Controls.Add(this.btnZoomPositive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 730);
            this.panel2.TabIndex = 1;
            // 
            // btnZoomPositive
            // 
            this.btnZoomPositive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoomPositive.FlatAppearance.BorderSize = 0;
            this.btnZoomPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomPositive.Location = new System.Drawing.Point(0, 0);
            this.btnZoomPositive.Name = "btnZoomPositive";
            this.btnZoomPositive.Size = new System.Drawing.Size(102, 53);
            this.btnZoomPositive.TabIndex = 0;
            this.btnZoomPositive.UseVisualStyleBackColor = true;
            // 
            // ImageHolder
            // 
            this.ImageHolder.Controls.Add(this.PictureboxImage);
            this.ImageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageHolder.Location = new System.Drawing.Point(102, 38);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(922, 730);
            this.ImageHolder.TabIndex = 2;
            // 
            // PictureboxImage
            // 
            this.PictureboxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureboxImage.Location = new System.Drawing.Point(0, 0);
            this.PictureboxImage.Name = "PictureboxImage";
            this.PictureboxImage.Size = new System.Drawing.Size(922, 730);
            this.PictureboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxImage.TabIndex = 0;
            this.PictureboxImage.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::DeepHistClient.Properties.Resources.carpiisaretiwhite;
            this.ExitButton.Location = new System.Drawing.Point(979, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 38);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::DeepHistClient.Properties.Resources.minimizeWhite;
            this.btnMinimize.Location = new System.Drawing.Point(934, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 38);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnZoomNegative
            // 
            this.btnZoomNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoomNegative.Location = new System.Drawing.Point(0, 53);
            this.btnZoomNegative.Name = "btnZoomNegative";
            this.btnZoomNegative.Size = new System.Drawing.Size(102, 53);
            this.btnZoomNegative.TabIndex = 1;
            this.btnZoomNegative.UseVisualStyleBackColor = true;
            // 
            // ImageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ImageHolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageScreen";
            this.Text = "ImageScreen";
            this.Load += new System.EventHandler(this.ImageScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ImageHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ImageHolder;
        private System.Windows.Forms.Button btnZoomPositive;
        private System.Windows.Forms.PictureBox PictureboxImage;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnZoomNegative;
    }
}