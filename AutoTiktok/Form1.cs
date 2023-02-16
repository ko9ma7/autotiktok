using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace AutoTiktok
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Thay đổi IP cho DCOM
        public static string ResetDCOM(string modemUrl, string username, string password)
        {
            var client = new RestClient(modemUrl);
            client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("api/dialup/mobiledata", Method.POST);
            request.AddParameter("xml", "<?xml version=\"1.0\" encoding=\"UTF-8\"?><request><Control>1</Control></request>");

            IRestResponse response = client.Execute(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                // handle error
                return "Error: " + response.ErrorMessage;
            }
            else
            {
                return "IP address changed successfully";
            }
        }
        //Chọn đường dẫn File chứa tài khoản mật khẩu tiktok
        private void btn_acc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Chọn tệp tin";
            openFileDialog1.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tất cả các tệp tin (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLinkAcc.Text = openFileDialog1.FileName;
            }
        }

        private void btn_ConfigB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Chọn tệp tin";
            openFileDialog1.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tất cả các tệp tin (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C:\\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtConfig.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtWinCount.Text);
            for (int i = 0; i < count; i++)
            {
                Process ldProcess = new Process();
                ldProcess.StartInfo.FileName = "C:\\Program Files\\LDPlayer\\LDPlayer4.0\\LDPlayer4.0\\dnplayer.exe";
                ldProcess.Start();

                Thread.Sleep(5000);

                IntPtr hwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, null, "LDPlayer");
                if (hwnd == IntPtr.Zero)
                {
                    MessageBox.Show("Cannot find LDPlayer window.");
                    return;
                }

                StringBuilder sb = new StringBuilder(256);
                GetWindowText(hwnd, sb, sb.Capacity);

                int chromeCount = 0;
                EnumChildWindows(hwnd, (handle, param) =>
                {
                    var childTitle = new StringBuilder(256);
                    GetWindowText(handle, childTitle, childTitle.Capacity);
                    if (childTitle.ToString() == "Chrome")
                    {
                        chromeCount++;
                        PostMessage(handle, WM_KEYDOWN, VK_CONTROL, 0);
                        PostMessage(handle, WM_KEYDOWN, VK_L, 0);
                        PostMessage(handle, WM_KEYUP, VK_L, 0);
                        PostMessage(handle, WM_KEYUP, VK_CONTROL, 0);
                    }
                    return true;
                }, IntPtr.Zero);

                if (chromeCount == 0)
                {
                    MessageBox.Show("Cannot find Chrome window.");
                    return;
                }
            }
        }
    }
}
