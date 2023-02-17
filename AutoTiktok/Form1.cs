using System;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Mở LDPlayer
            string ldPlayerPath = @"D:\LDPlayer\dnplayer.exe";
            Process ldPlayerProcess = Process.Start(ldPlayerPath);

            // Chờ LDPlayer khởi động
            Thread.Sleep(5000);

            // Gửi lệnh adb để mở TikTok Lite
            string adbPath = @"D:\LDPlayer\adb.exe";
            ProcessStartInfo adbStartInfo = new ProcessStartInfo(adbPath, @"-s 127.0.0.1:21503 shell am start -n com.ss.android.ugc.trill/com.ss.android.ugc.trill.main.MainActivity");
            Process adbProcess = Process.Start(adbStartInfo);
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-notifications"); // Tắt thông báo hiển thị trên trình duyệt
            chromeOptions.AddArguments("--disable-infobars"); // Tắt thanh trạng thái trên trình duyệt
            chromeOptions.AddArguments("--mute-audio"); // Tắt âm thanh trên trình duyệt

            // Khởi tạo trình điều khiển Chrome để tự động điều khiển trình duyệt
            var driver = new ChromeDriver(chromeOptions);

            // Mở trang web https://www.tiktok.com/@lycos.white
            driver.Navigate().GoToUrl("https://www.tiktok.com/@lycos.white");

            // Đóng trình duyệt
            driver.Quit();
        }
    }
}
