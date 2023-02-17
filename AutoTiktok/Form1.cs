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
using System.Collections.Generic;
using System.Text.RegularExpressions;


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

 
        //Mở ưng dung LDplayer theo số luơng cai đăt
        private void OpenLD()
        {
            int windowCount = int.Parse(txtWinCount.Text);
            for (int i = 1; i <= windowCount; i++)
            {
                // Khởi động LDPlayer
                Process.Start("cmd.exe", "/c \"D:\\LDPlayer\\dnconsole.exe create --index " + i + " --resolution 720,1280 --dpi 320 --type 0 && D:\\LDPlayer\\dnconsole.exe launch --index " + i + "\"");
                // Chờ LDPlayer khởi động trong 30 giây
                Thread.Sleep(1000);
            }
        }
        //Mở ưng dung tiktok trong LDplayer
        private void OpenTiktok()
        {
            // Lấy danh sách các thiết bị đang kết nối
            var devices = new List<string>();
            var adbProcess = new Process();
            adbProcess.StartInfo.FileName = "D:\\LDPlayer\\adb.exe";
            adbProcess.StartInfo.Arguments = "devices";
            adbProcess.StartInfo.UseShellExecute = false;
            adbProcess.StartInfo.RedirectStandardOutput = true;
            adbProcess.Start();

            // Đọc kết quả trả về từ adb devices
            string output = adbProcess.StandardOutput.ReadToEnd();
            string[] lines = output.Split('\n');
            foreach (string line in lines)
            {
                if (line.Contains("emulator-"))
                {
                    string device = line.Replace("\tdevice", "");
                    devices.Add(device);
                }
            }
            adbProcess.WaitForExit();

            // Mở ứng dụng TikTok trên từng thiết bị
            foreach (string device in devices)
            {
                Process.Start("cmd.exe", "/c \"D:\\LDPlayer\\adb.exe -s " + device + " shell am start -n com.ss.android.ugc.trill/com.ss.android.ugc.aweme.splash.SplashActivity\"");
                Thread.Sleep(1000);
            }
        }
        //Săp xêp cac cưa sổ LDplayer
        private void sortLDWindows()
        {
            List<string> windowList = new List<string>();
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c adb.exe shell dumpsys window windows | findstr /E \"SurfaceView\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                windowList.Add(line);
            }
            process.WaitForExit();

            windowList.Sort();

            for (int i = 0; i < windowList.Count; i++)
            {
                int index = int.Parse(Regex.Match(windowList[i], @"init=(\d+),").Groups[1].Value);
                Process.Start("cmd.exe", $"/c \"D:\\LDPlayer\\LDPlayer4.0\\dnconsole.exe move --index {index} --position {i}\"");
            }
        }
        //Đong tât cả cưa sổ LDplayer đang mở
        private void CloseLDPlayers()
        {
            // Lấy danh sách tất cả các tiến trình có tên "ldplayer.exe"
            Process[] processes = Process.GetProcessesByName("dnplayer");

            // Duyệt qua danh sách các tiến trình và đóng chúng
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            OpenLD();
        }

        private void btn_tiktok_Click(object sender, EventArgs e)
        {
            OpenTiktok();
        }

        private void btn_sortLD_Click(object sender, EventArgs e)
        {
            sortLDWindows();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            CloseLDPlayers();
        }
    }
}
