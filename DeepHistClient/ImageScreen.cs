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

        public Image image;
        private void ImageScreen_Load(object sender, EventArgs e)
        {
            PictureboxImage.Image = image;
        }

        //public async Task loadImage()
        //{
        //    var client = new RestClient(ProjeEkrani.ClickedPictureBoxImageUrl);
        //    var request = new RestRequest();
        //    var response = await client.GetAsync(request);
        //    var jsonResult = response.Content;
        //    var output = JsonConvert.DeserializeObject<List<dynamic>>(jsonResult);           
        //    PictureboxImage.ImageLocation = output[0];
        //    PictureboxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //}

        public ImageScreen()
        {
            InitializeComponent();
        }

        public ImageScreen(Image image)
        {
            InitializeComponent();
            this.image = image;
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
    }
}
