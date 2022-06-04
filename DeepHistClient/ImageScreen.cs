using Newtonsoft.Json;
using RestSharp;
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
    public partial class ImageScreen : Form
    {
        /***************** FORMU RESİZE EDEN DEĞİŞKENLER ***********************************************************/
        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        /*----------- mouse ile pencereyi hareket ettirmek için gerekli olan değişkenler ve başvurular-------------*/

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static DateTime logintime;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();




        public Image image;
        private void ImageScreen_Load(object sender, EventArgs e)
        {
            PictureboxImage.Image = image;
        }

       
        //resmi yeniden boyutlandıran metot
        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bitmap = new Bitmap(img, img.Width + (img.Width * size.Width/100), img.Height + (img.Height* img.Height/100));
            Graphics gpu = Graphics.FromImage(bitmap);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bitmap;
        }

        public ImageScreen()
        {
            InitializeComponent();
        }

        public ImageScreen(Image image)
        {
            InitializeComponent();
            this.image = image;
           
        }






        /*FORMU RESİZE EDEN 2 METOT*/
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x40000;
                return cp;
            }
        }



       
      


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.Image = Properties.Resources.carpiisaretiBlue;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.Image = Properties.Resources.carpiisaretiwhite;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeBlue;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeWhite;
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //pencereyi hareket ettiren kod
        private void KRETitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
