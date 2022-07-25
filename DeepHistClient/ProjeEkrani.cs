﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeepHistClient
{
   

    public partial class ProjeEkrani : Form
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

        /*---------------------------------------------------------------------------------------------------------*/
        public bool isMax = false;
        public ImageList images = new ImageList();
        public static string imgpath = ProjeSecimEkrani.folderPath;
        public DateTime dt = Form1.logintime;
        public string CacheImgPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "cache");
        public string gifPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "gifs");
        public static string choosenProjectId = string.Empty;
        public static List<ReturnImageInfos> listImageInfos = new List<ReturnImageInfos>();
        public int filesystemwatchercounter = 0;
        ImageUploadProcesses imageuploadprocesses = new ImageUploadProcesses();
        public static string ClickedPictureBoxImageUrl = string.Empty;





        public ProjeEkrani()
        {
            InitializeComponent();           
        }

        private async void ProjeEkrani_Load(object sender, EventArgs e)
        {
            try
            {                
                Filltxtbox();
                fileSystemWatcher1.Path = ProjeSecimEkrani.folderPath;
                fileSystemWatcher1.IncludeSubdirectories = true;
                fileSystemWatcher1.EnableRaisingEvents = true;
                await imageuploadprocesses.uploadImagesToAmazons3();
                //await imageuploadprocesses.readJson();
                await ImageInfos();
                await GetUrlFromImageIdForPicturebox();
                Control.CheckForIllegalCrossThreadCalls = false;
            }
            catch (Exception eec)
            {
                Console.WriteLine(string.Format("this exception from load {0}", eec));
            }
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


        /* ----------------------- PROJE İÇİN ÖNEMLİ FONKSİYONLARIN BULUNDUĞU KISIM ------------------------- */

        //seçilen projeye ait olan görüntülerinin idsini listeye dolduran metot
        public async Task ImageInfos()
        {
            try
            {
                listImageInfos.Clear();
                string url = "http://deephistapps.com/api/image";
                var client = new RestClient(url);
                var request = new RestRequest();
                var response = await client.GetAsync(request);
                listImageInfos = JsonConvert.DeserializeObject<List<ReturnImageInfos>>(response.Content);
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("this exception from ImageInfos {0}", exc));
            }
        }
        
        
        public async Task GetUrlFromImageIdForPicturebox()
        {
            try
            {
                foreach (var imageInfos in listImageInfos)
                {
                    if (imageInfos.projectId.ToString().Equals(choosenProjectId))
                    {
                        string url = "http://deephistapps.com/api/image/UrlOfImageByImageId/" + imageInfos.imageId.ToString();
                        var client = new RestClient(url);
                        var request = new RestRequest();
                        var response = await client.GetAsync(request);
                        var jsonResult = response.Content;
                        var output = JsonConvert.DeserializeObject<List<dynamic>>(jsonResult);
                        PictureBox pb1 = new PictureBox();
                        pb1.ImageLocation = output[0];
                        pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb1.Height = 225;
                        pb1.Width = 225;
                        pb1.Click += new EventHandler(pb1_Click);
                        pb1.Tag = url;
                        pb1.ErrorImage = Properties.Resources.noInternet;
                        pb1.InitialImage = Properties.Resources.loadingGifForPb;                        
                        KREAwsImageHolder.Controls.Add(pb1);
                    }
                }                
            }
            catch (Exception exception)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                Console.WriteLine(string.Format("this exception from getUrlFromImageIdForPicturebox {0}",exception));
            }
            
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox clickedPictureBox = (PictureBox)sender;
                ImageScreen i1 = new ImageScreen(clickedPictureBox.Image);
                i1.Show();
            }
            catch (Exception y)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                Console.WriteLine(string.Format("this exception from pb1Click {0}", y));

            }

        }

        //picturebox oluşturan ve içerisine resim gönderen fonksiyon
        public void CreateAndFillPictureBox()
        {
            try
            {
                KRELocalImageHolder.Controls.Clear();
                var imagesFromCache = Directory.GetFiles(
                    CacheImgPath+"\\","*.*",SearchOption.AllDirectories).Where(
                        (x => new FileInfo(x).CreationTime > dt 
                        && (x.EndsWith(".jpeg")) || 
                        x.EndsWith(".png") ||
                        x.EndsWith(".jpg")
                ));
                foreach (string img in imagesFromCache)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = new Bitmap(img);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 225;
                    pb.Width = 225;
                    pb.Tag = Name;
                    pb.ErrorImage = Properties.Resources.noInternet;
                    pb.InitialImage = Properties.Resources.loadingGif;
                    pb.Click += new EventHandler(pb1_Click);
                    if (this.InvokeRequired) //Forma gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    {
                        //Eğer farklı bir iş parçacığından talep gelmişse aşağıdaki Invoke metoduyla işlem gerçekleştiriliyor.
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            KRELocalImageHolder.Controls.Add(pb);
                        });
                    }
                    else
                    {
                        KRELocalImageHolder.Controls.Add(pb);
                    }
                }
                imagesFromCache = null;
            }
            catch (Exception w)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                Console.WriteLine(string.Format("this exception from createandfill methods {0}",w));
            }
        }

        
        public void Filltxtbox()
        {
            try
            {
                foreach (var projectname in ProjeSecimEkrani.listUserProjects)
                {
                    if (projectname.projectName == ProjeSecimEkrani.choosenProject)
                    {
                        choosenProjectId = projectname.projectId.ToString();
                        KREProjectInfoList.AppendText(
                            string.Format("Project Name : {0}, Number : {1} ",
                            projectname.projectName.ToString(),
                            projectname.projectNumber.ToString()
                            )
                        );
                    }
                }
                KREProjectInfoList.AppendText(Environment.NewLine);
                KREProjectInfoList.AppendText(string.Format("Manager Name : {0} {1}", Form1.LoginUserInfos["name"], Form1.LoginUserInfos["surname"]));
            }
            catch (Exception e)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                Console.WriteLine(string.Format("this exception from filltxtbox {0}", e));
            }
               
        }

        //dosya adının yaratıldığı metot
        public string CreateFolderName()
        {
            string fileName = ProjeSecimEkrani.customerId.ToString()+ choosenProjectId + DateTime.Now.ToString("dd_MM_dd_yyy_HH_mm_ss_ffff") + ".jpeg";
            return fileName;
        }

        //pencereyi hareket ettiren kod
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public async Task WaitTwoSecondsAsync()
        {
            int fade1 = 100;
            while (fade1 != -1)
            {
                await Task.Delay(30);
                fade1--;
            }
        }

        /*----------------------------------------------------------------------------------------*/



        /*------------------------- BU KISIMDA TOOLLARIN EVENTLERİ BULUNUYOR----------------------*/

        //LOGOUT BUTONU
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1 l1 = new Form1();
            this.Close();
            l1.Show();
        }

        //AMAZON TIMERI
        private async void refreshAmazon_TickAsync(object sender, EventArgs e)
        {
            try
            {
                if (EthernetStatus.CheckForInternetConnection())
                {
                    var needDeletedPicturebox = this.KREAwsImageHolder.Controls.OfType<PictureBox>().ToArray();
                    foreach (PictureBox pb in needDeletedPicturebox)
                    {                       
                        this.KREAwsImageHolder.Controls.Remove(pb);                      
                        pb.Dispose();
                    }
                    KREAwsImageHolder.Controls.Clear();
                    await GetUrlFromImageIdForPicturebox();
                }
                else
                {
                    var needDeletedPicturebox = this.KREAwsImageHolder.Controls.OfType<PictureBox>().ToArray();
                    foreach (PictureBox pb in needDeletedPicturebox)
                    {                      
                        this.KREAwsImageHolder.Controls.Remove(pb);                      
                        pb.Dispose();                     
                    }
                    KREAwsImageHolder.Controls.Clear();
                    PictureBox pbx = new PictureBox();
                    pbx.Image = Properties.Resources.internetConnectionWarning;
                    pbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbx.Height = KREAwsImageHolder.Height;
                    pbx.Width = KREAwsImageHolder.Width;
                    pbx.Tag = Name;
                    //pbx.Dock = DockStyle.Fill;
                    pbx.ErrorImage = Properties.Resources.noInternet;
                    pbx.InitialImage = Properties.Resources.loadingGif;
                    KREAwsImageHolder.Controls.Add(pbx);
                }
            }
            catch (Exception w)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                Console.WriteLine(string.Format("this exception from filltxtbox {0}", w));


            }
        }

        private async void timer2_TickAsync(object sender, EventArgs e)
        {
           // await imageuploadprocesses.readJson();
        }

        //private void timer3_Tick(object sender, EventArgs e)
        //{
        //    KRELocalImageHolder.Controls.Clear();
        //    CreateAndFillPictureBox();
        //}

        private async void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {        
            if (filesystemwatchercounter % 2 == 0)
            {
                try
                {
                    System.Threading.Thread.Sleep(300);
                    string fileName = CreateFolderName();
                    string fullPath = CacheImgPath + "\\" + fileName;
                    string imgname = e.FullPath;
                    System.IO.File.Copy(imgname, fullPath);                    
                    System.Threading.Thread.Sleep(300);
                    KRELocalImageHolder.Controls.Clear();
                    CreateAndFillPictureBox();
                    imageuploadprocesses.fillJsonFile();                    
                    //await imageuploadprocesses.readJson();
                    await imageuploadprocesses.uploadImagesToAmazons3();
                }
                catch (Exception w)
                {
                    DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
                    Console.WriteLine(string.Format("this exception from filltxtbox {0}", w));
                }
            }
            filesystemwatchercounter++;
        }

       
        /*-----------------------------------------------------------------------------------------*/
       

        /*----------------ÜST MENÜDEKİ BUTONLARIN TASARIMLARI VE İÇLERİ--------------------------------*/

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.Image = Properties.Resources.carpiisaretiBlue;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.Image = Properties.Resources.carpiisaretiwhite;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.backBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.backWhite;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    
        private async void button3_ClickAsync(object sender, EventArgs e)
        {
            ProjeSecimEkrani p1 = new ProjeSecimEkrani();
            AnimationForm a1 = new AnimationForm();           
            this.Hide();
            a1.Show();
            await WaitTwoSecondsAsync();
            a1.Close();
            p1.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void AcikRenkliPanelLocalProjeEkrani_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ImageUploadProcesses i1 = new ImageUploadProcesses();
            i1.fillJsonFile();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AcikRenkliUstPanelProjeEkrani_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (isMax==false)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
            }
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.Image = Properties.Resources.windowMaximizeBlue;
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.Image = Properties.Resources.windowMaximizeWhite;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimized_MouseEnter(object sender, EventArgs e)
        {
            btnMinimized.Image = Properties.Resources.minimizeBlue;
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            btnMinimized.Image = Properties.Resources.minimizeWhite;
        }

        private void ARETitle_Click(object sender, EventArgs e)
        {

        }

        private void KRELocalImageHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KREAwsImageHolder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KREProjectInfoList_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
