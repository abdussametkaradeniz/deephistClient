using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepHistClient
{

    public partial class Form1 : Form
    {

       

        /*----------- mouse ile pencereyi hareket ettirmek için gerekli olan değişkenler ve başvurular-------------*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;              
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        

       
        /*---------------------------------------------------------------------------------------*/
        public string loginresult = string.Empty;
        public static DateTime logintime;
        public static Dictionary<string, string> LoginUserInfos = new Dictionary<string, string>();
        ProjeSecimEkrani f2 = new ProjeSecimEkrani();
        EthernetStatus ethernetStatusObject = new EthernetStatus();
        

        public Form1()
        {
            InitializeComponent();
        }
       

      
        private void Form1_Load(object sender, EventArgs e)
        {     
           
            
        }

        public void enableLoginButton()
        {
            btnLogin.Enabled = true;
        }
        public void disableLoginButton()
        {
            btnLogin.Enabled = false;
        }


        public async Task loginpostAsync(string Id, string password)
        {
            try
            {
                LoginUserInfos.Clear();
                string url = "http://deephistapps.com/api/customer/defaultLogin";
                var client = new RestClient(url);
                var request = new RestRequest();
                var body = new LoginPost { userName = Id, password = password };
                request.AddJsonBody(body);
                var response = await client.PostAsync(request);
                loginresult = response.StatusCode.ToString();
                LoginUserInfos = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            }
            catch (Exception)
            {
                DialogWindows.showDialog("Check your internet connection", Properties.Resources.interneticons, "Connection Error");
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


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            AnimationForm a1 = new AnimationForm();
            //this.Hide();
            //a1.Show();           
            try
            {                                                          
                if (EthernetStatus.CheckForInternetConnection())
                {
                    string username = txtId.Text;
                    string password = txtSifre.Text;
                    if (username.Trim() != "" || password.Trim() != "")
                    {
                        try
                        {
                            this.Hide();
                            await loginpostAsync(username, password);
                            logintime = DateTime.Now;
                            if (loginresult.Equals("OK"))
                            {
                                //this.Hide();                                                               
                                //await WaitTwoSecondsAsync();
                                //a1.Close();
                                f2.Show();
                            }
                        }
                        catch (Exception)
                        {                        
                            DialogWindows.showDialog("Authentication failed! Check your username and password", Properties.Resources.authenticationFailed, "Authentication problem");
                            //this.Hide();
                            //await WaitTwoSecondsAsync();
                            //a1.Close();
                            this.Show();
                        }                                               
                    }
                    else if (username.Trim() == "" && password.Trim() == "")
                    {
                        DialogWindows.showDialog("Check your username and password", Properties.Resources.usernameNull,"Username or password null");
                        //this.Hide();
                        //await WaitTwoSecondsAsync();
                        //a1.Close();
                        this.Show();
                    }
                }
                else
                {              
                    DialogWindows.showDialog("Check your internet connection", Properties.Resources.interneticons,"Connection Error");
                    //this.Hide();
                    //await WaitTwoSecondsAsync();
                    //a1.Close();
                    this.Show();
                }
            }
            catch (Exception)
            {
                DialogWindows.showDialog("Try again! If you continue to receive this error, contact your system administrator.", Properties.Resources.tryAgain,"Unexpected Error");
                //this.Hide();
                //await WaitTwoSecondsAsync();
                //a1.Close();
                this.Show();
            }
        }

      

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtId_Click(object sender, EventArgs e)
        {            
            pictureUser.BackgroundImage = Properties.Resources.user_blue;
            userPanel.ForeColor = Color.FromArgb(78, 184, 206);
            txtId.ForeColor = Color.FromArgb(78, 184, 206);

            picturePassword.BackgroundImage = Properties.Resources.password_white;
            passwordPanel.ForeColor = Color.WhiteSmoke;
            txtSifre.ForeColor = Color.WhiteSmoke;
        }

       
        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtId_MouseEnter(object sender, EventArgs e)
        {
            pictureUser.Image = Properties.Resources.user_blue;
        }

        private void txtId_MouseLeave(object sender, EventArgs e)
        {
            pictureUser.Image = Properties.Resources.user_white;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.BackColor = Color.FromArgb(248, 143, 1);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(248, 143, 1);
            btnLogin.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void BtnCikis_MouseEnter(object sender, EventArgs e)
        {
            BtnCikis.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void BtnCikis_MouseLeave(object sender, EventArgs e)
        {
            BtnCikis.ForeColor = Color.White;           
        }

        private void txtSifre_MouseEnter(object sender, EventArgs e)
        {
            picturePassword.Image = Properties.Resources.password_blue;
        }

        private void txtSifre_MouseLeave(object sender, EventArgs e)
        {
            picturePassword.Image = Properties.Resources.password_white;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

      

        private void txtSifre_Click(object sender, EventArgs e)
        {
            pictureUser.BackgroundImage = Properties.Resources.user_white;
            userPanel.ForeColor = Color.WhiteSmoke;
            txtId.ForeColor = Color.WhiteSmoke;

            picturePassword.BackgroundImage = Properties.Resources.password_blue;
            passwordPanel.ForeColor = Color.FromArgb(78, 184, 206);
            txtSifre.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {

        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
