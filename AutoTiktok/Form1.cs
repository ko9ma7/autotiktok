using System;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace AutoTiktok
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        private const int VK_L = 0x4C;
        private const int VK_CONTROL = 0x11;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_Start_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtWinCount.Text);
            for (int i = 0; i < count; i++)
            {
                Process ldProcess = new Process();
                ldProcess.StartInfo.FileName = "D:\\LDPlayer\\dnplayer.exe"; 
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
                    if (childTitle.ToString() == "Tiktok Lite")
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
                    MessageBox.Show("Cannot find Tiktok Lite window.");
                    return;
                }
            }
        }
    }
}
