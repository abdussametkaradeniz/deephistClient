using Newtonsoft.Json;
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

        public ImageList images = new ImageList();
        public static string imgpath = ProjeSecimEkrani.folderPath;
        public DateTime dt = Form1.logintime;
        string CacheImgPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "cache");
        public static string choosenProjectId = string.Empty;
        public static List<ReturnImageInfos> listImageInfos = new List<ReturnImageInfos>();
       


        public ProjeEkrani()
        {
            InitializeComponent();
            
        }

        private async void ProjeEkrani_Load(object sender, EventArgs e)
        {
            Filltxtbox();
            
            fileSystemWatcher1.Path = ProjeSecimEkrani.folderPath;
            await ImageInfos();
            await GetUrlFromImageIdForPicturebox();
            await uploadImagesToAmazons3(CacheImgPath+"\\"+"Image10.jpeg");
            Control.CheckForIllegalCrossThreadCalls = false;
            
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
            string url = "http://deephistapps.com/api/image";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = await client.GetAsync(request);
            listImageInfos = JsonConvert.DeserializeObject<List<ReturnImageInfos>>(response.Content);
            
        }
        
        public async Task GetUrlFromImageIdForPicturebox()
        {
            foreach (var imageInfos in listImageInfos)
            {
                if (imageInfos.projectId.ToString().Equals("5"))
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
                    AWSstorage.Controls.Add(pb1);         
                }
            }      
        }
        
        
              
        
        //picturebox oluşturan ve içerisine resim gönderen fonksiyon
        public void CreateAndFillPictureBox()
        {
            try
            {              
                var imagesFromCache = Directory.GetFiles(CacheImgPath+"\\", "*.jpeg").Where((x => new FileInfo(x).CreationTime > dt));
                foreach (string img in imagesFromCache)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = new Bitmap(img);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = 225;
                    pb.Width = 225;
                    pb.Tag = Name;
                    if (this.InvokeRequired) //Forma gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    {
                        //Eğer farklı bir iş parçacığından talep gelmişse aşağıdaki Invoke metoduyla işlem gerçekleştiriliyor.
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            LocalStorage.Controls.Add(pb);
                        });
                    }
                    else
                    {
                        LocalStorage.Controls.Add(pb);
                    }
                }             
            }
            catch (Exception w)
            {
                MessageBox.Show("createandfill" + w);
            }
        }

        
        public void Filltxtbox()
        {
            foreach (var projectname in ProjeSecimEkrani.listUserProjects)
            {
                if (projectname.projectName == ProjeSecimEkrani.choosenProject)
                {
                    choosenProjectId = projectname.projectId.ToString();
                    txtInfoAll.AppendText("Admin Id : " + projectname.adminId.ToString());
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("Project Id : " + choosenProjectId);
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("Project Name : " + projectname.projectName.ToString());
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("Project Number : " + projectname.projectNumber.ToString());
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("Tissue Id : " + projectname.tissueId.ToString());
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("isUseableInOnlineLearning : " + projectname.ısUseableInOnlineLearning.ToString());
                    txtInfoAll.AppendText(Environment.NewLine);
                }
            }
                     
                    txtInfoAll.AppendText("Proje Sahibi İsim : " + Form1.LoginUserInfos["name"]);
                    txtInfoAll.AppendText(Environment.NewLine);
                    txtInfoAll.AppendText("Proje Sahibi Soyisim : " + Form1.LoginUserInfos["surname"]);
                    txtInfoAll.AppendText(Environment.NewLine);
                    
                
            
        }

        

        //dosya adının yaratıldığı metot
        public string CreateFolderName()
        {
            string fileName = "1_1_" + DateTime.Now.ToString("dd_MM_dd_yyy_HH_mm_ss_ffff") + ".jpeg";
            return fileName;
        }

        //dosyaları amazona upload eden metot
        public async Task uploadImagesToAmazons3(string waitingForUploadImagePath)
        {
            try
            {
                string url = "http://deephistapps.com/api/image/UploadImageToAmazon";
                var client = new RestClient(url);
                var request = new RestRequest();
                var strImageDto1 = new
                {
                    ImageName = "abc.jpeg",
                    ProjectId = 5,
                    StainId = 1,
                    MagnificationImageId = 1,
                    MicroscopeId = 1,
                    CustomerId = 1
                };
                string strImageDto = JsonConvert.SerializeObject(strImageDto1);
                //request.AddHeader("Content-Type", "multipart/form-data");
                request.AddFile(Path.GetFileNameWithoutExtension("Image10"),waitingForUploadImagePath);
                request.AddParameter("StrImageDto",strImageDto);
                request.AlwaysMultipartFormData = true;
                var response = await client.PostAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());                
            }           
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
        private void refreshAmazon_Tick(object sender, EventArgs e)
        {
            /*
            try
            {
                if (EthernetStatus.CheckForInternetConnection())
                {
                    ListingObjectsAsync().Wait();
                }

            }
            catch (Exception w)
            {
                MessageBox.Show("beklenmedik hata gerçekleşti " + w);
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            LocalStorage.Controls.Clear();
            CreateAndFillPictureBox();
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(300);
                string fileName = CreateFolderName();
                string fullPath = CacheImgPath+"\\" + fileName;
                string imgname = e.FullPath;
                System.IO.File.Copy(imgname, fullPath);
                System.Threading.Thread.Sleep(300);
                LocalStorage.Controls.Clear();
                CreateAndFillPictureBox();
            }
            catch (Exception w)
            {
                MessageBox.Show("filesystemwatchercreated" + w);
            }
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

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeWhite;
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
    
        private void button3_Click(object sender, EventArgs e)
        {
            ProjeSecimEkrani p1 = new ProjeSecimEkrani();
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
    }
}
