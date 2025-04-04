﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepHistClient
{
    public partial class ProjeSecimEkrani : Form
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

        public static string folderPath = string.Empty;
        public bool isMax = false;
        public static Dictionary<string, string> LoginUserProjectInfos = new Dictionary<string, string>();
        public static List<projectInfos> listUserProjects = new List<projectInfos>();
        public static string choosenProject=string.Empty;
        public static string customerId;
        public int refreshcomboboxcounter = 0;
        public ProjeSecimEkrani()
        {
            InitializeComponent();
           
        }


        private async void ProjeSecimEkranı_Load(object sender, EventArgs e)
        {
            try
            {
                txtFolderPath.Text = string.Empty;
                folderPath = string.Empty;
                if (EthernetStatus.CheckForInternetConnection())
                {
                    btnProjeyeGit.ForeColor = Color.FromArgb(97, 97, 97);
                    buttonState();
                    await FillCombobox1Async();
                    FillProjectInfos();
                }
                else
                {
                    DialogWindows.showDialog("Check your internet connection", Properties.Resources.interneticons, "Connection Error");
                    buttonState();
                    refreshForInternet.Enabled = true;
                }
               
            }
            catch (Exception xxe)
            {
                Console.WriteLine(xxe);
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
                cp.Height = 0;
                return cp;
            }
        }
        /*-------------------------------- PROJE İÇERİSİNDEKİ TÜM BUTONLAR --------------------------------------*/

        //sağ üstteki çarpı işareti
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //path seçtiren butonun içerisi.
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*
                folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                txtFolderPath.Text = folderPath;*/
                folderPath = folderDlg.SelectedPath;
                txtFolderPath.Text = folderPath;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you made the right choice?", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnProjeyeGit.Enabled = true;
                btnProjeyeGit.Image = Properties.Resources.GotoProjectwhite;
                btnProjeyeGit.ForeColor = Color.WhiteSmoke;
            }
            else if (dialogResult == DialogResult.No)
            {
                btnProjeyeGit.Enabled = false;
                txtFolderPath.Clear();
                btnProjeyeGit.Image = Properties.Resources.GotoProjectBlack;
                btnProjeyeGit.ForeColor = Color.Black;
            }
            btnDosyaSec.Image = Properties.Resources.FolderWhite;
            btnDosyaSec.ForeColor = Color.WhiteSmoke;
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

        //proje ekranına götüren buton
        private async void btnProjeyeGit_ClickAsync(object sender, EventArgs e)
        {
            ProjeEkrani p1 = new ProjeEkrani();
            AnimationForm a1 = new AnimationForm();
            this.Hide();
            //a1.Show();
            //await WaitTwoSecondsAsync();
            //a1.Close();
            p1.Show();
            this.Close();
        }


        //giriş ekranına geri döndüren butonun içerisi
        private async void btnCikisYap_ClickAsync(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            AnimationForm a1 = new AnimationForm();
            this.Hide();
            //a1.Show();
            //await WaitTwoSecondsAsync();
            //a1.Close();
            f1.Show();
            this.Close();          
        }
       
        //Contact butonu
        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact c1 = new Contact();
            c1.Show();
        }


        /*------------------------------------------------------------------------------------------------------------*/


        /*------------------------------- Ekran için gerekli olan fonksiyonlar buranın altında -------------*/

        //projeye git butonunu ayarlayan fonksiyon
        public void buttonState()
        {

            if (folderPath != string.Empty || txtFolderPath.Text == "")
            {
                txtFolderPath.Text = folderPath;
                btnProjeyeGit.Enabled = false;
            }
            else
            {
                txtFolderPath.Text = "";
                btnProjeyeGit.Enabled = true;
            }
        }

        //combobox1 i doldurduğum metot. Proje isimleri burada doluyor.
        public async Task FillCombobox1Async()
        {
            if (EthernetStatus.CheckForInternetConnection())
            {
                listUserProjects.Clear();
                customerId = Form1.LoginUserInfos["customerId"];
                string url = string.Format("http://deephistapps.com/api/project/ProjectsByCustomerId/{0}", customerId);
                var client = new RestClient(url);
                var request = new RestRequest();
                var response = await client.GetAsync(request);
                listUserProjects = JsonConvert.DeserializeObject<List<projectInfos>>(response.Content);
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = listUserProjects;
                comboBox1.DataSource = bindingSource1.DataSource;
                comboBox1.DisplayMember = "projectName";
                comboBox1.ValueMember = "projectName";
            }
            else
            {
                DialogWindows.showDialog("Check your internet connection", Properties.Resources.interneticons, "Connection Error");
                refreshForInternet.Enabled = true;
            }
            
        }

        //proje bilgileri txtsini doldurduğum fonksiyon
        public void FillProjectInfos()
        {
            try
            {
                AREProjectInfosHolder.Clear();
                choosenProject = comboBox1.SelectedValue.ToString();
                foreach (var projectname in listUserProjects)
                {
                    if (projectname.projectName == choosenProject)
                    {
                        AREProjectInfosHolder.AppendText("Project Id : " + projectname.projectId.ToString());
                        AREProjectInfosHolder.AppendText(Environment.NewLine);
                        AREProjectInfosHolder.AppendText("Project Name : " + projectname.projectName.ToString());
                        AREProjectInfosHolder.AppendText(Environment.NewLine);
                        AREProjectInfosHolder.AppendText("Project Number : " + projectname.projectNumber.ToString());
                        AREProjectInfosHolder.AppendText(Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain, "Unexpected Error");
            }

        }

        //comboboxı dolduran event
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillProjectInfos();
        }

        private async void refreshForInternet_TickAsync(object sender, EventArgs e)
        {
            refreshcomboboxcounter += 1;
            if (EthernetStatus.CheckForInternetConnection())
            {
                await FillCombobox1Async();
                refreshForInternet.Enabled = false;
            }
            if (refreshcomboboxcounter % 4 == 0)
            {
                DialogWindows.showDialog("Check your internet connection", Properties.Resources.interneticons, "Connection Error");
            }
        }

        //formu sürüklemek için gerekli olan kod
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void ARETitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /*-------------------------------------------------------------------------------------------------------------*/




        /*-------- bu kısmın altında sadece buton tasarımları vardır. Hover ve leave eventleri için kodlar yer alıyor ------------*/


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelchieldForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeWhite;
        }

        private void btnCikis_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.Image = Properties.Resources.carpiisaretiwhite;
        }

        private void btnDosyaSec_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnDosyaSec_MouseLeave(object sender, EventArgs e)
        {
            btnDosyaSec.Image = Properties.Resources.FolderWhite;
            btnDosyaSec.ForeColor = Color.WhiteSmoke;
        }

        private void btnProjeyeGit_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnProjeyeGit_MouseLeave(object sender, EventArgs e)
        {
            btnProjeyeGit.Image = Properties.Resources.GotoProjectwhite;
            btnProjeyeGit.ForeColor = Color.WhiteSmoke;
        }

        private void btnCikisYap_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnCikisYap_MouseLeave(object sender, EventArgs e)
        {
            btnCikisYap.Image = Properties.Resources.logoutWhite;
            btnCikisYap.ForeColor = Color.WhiteSmoke;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDosyaSec_MouseEnter(object sender, EventArgs e)
        {
            btnDosyaSec.Image = Properties.Resources.FolderBlue;
            btnDosyaSec.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnProjeyeGit_MouseEnter(object sender, EventArgs e)
        {
            btnProjeyeGit.Image = Properties.Resources.GotoProjectBlue;
            btnProjeyeGit.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnCikisYap_MouseEnter(object sender, EventArgs e)
        {
            btnCikisYap.Image = Properties.Resources.logoutBlue;
            btnCikisYap.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.Image = Properties.Resources.carpiisaretiBlue;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = Properties.Resources.minimizeBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Image = Properties.Resources.SettingsBlue;
            btnSettings.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Image = Properties.Resources.settingsWhite;
            btnSettings.ForeColor = Color.WhiteSmoke;
        }

        private void btnContact_MouseEnter(object sender, EventArgs e)
        {
            btnContact.Image = Properties.Resources.contact;
            btnContact.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void btnContact_MouseLeave(object sender, EventArgs e)
        {
            btnContact.Image = Properties.Resources.contactWhite;
            btnContact.ForeColor = Color.WhiteSmoke;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void ARETitle_Click(object sender, EventArgs e)
        {

        }

        private void ARELeft1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (isMax == false)
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      
    }
}
