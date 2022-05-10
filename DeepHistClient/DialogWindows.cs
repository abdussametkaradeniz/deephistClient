using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepHistClient
{
    public partial class DialogWindows : Form
    {
        public DialogWindows(string message, Bitmap imgPath,string title)
        {
            InitializeComponent();
            this.txtWarn.Text = message;
            this.pictureBox1.Image =imgPath;
            this.lblTitle.Text = title;
        }

        void animateForeShow()
        {

        }

        //notify için ayrılmış alan
        public static void showDialog(String message, Bitmap icoPath, string title)
        {
            DialogWindows dialog = new DialogWindows(message, icoPath, title);
            dialog.Show();
        }


        private void DialogWindows_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtWarn_Click(object sender, EventArgs e)
        {

        }
    }
}
