using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form2 : MaterialForm
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public static extern void FreeConsole();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

              AllocConsole();
            Console.WriteLine("     __  __ ___   ___\r\n    /  \\/  / __/ / __/ _ ___\r\n   / /\\// / _/  / _/ '_/ '_\\\r\n  /_/  /_/___/ /_//_/ / .__/\r\n                     /_/\r\n ME Frp 服务即将启动\n下方出现 start proxy success 即为隧道启动成功，否则隧道尚未启动。");
            //Thread.Sleep(1000);
            //Form1.RunCmd("cd " + AppDomain.CurrentDomain.BaseDirectory);    //执行命令
            string fh_2 = Form1.RunCmd("frpc.exe -c awa\\" + common.awa + ".ini");
            fh_text.Text=common.awa+"正在运行......";
            //char[] delimiterChars = { '\n' };
            //string[] words = fh_2.Split(delimiterChars);
            //int a;
            //for (a = 0; a < words.Length; a++)
            //{
            //  fh_list.AddItem(words[a]);
            //}
            //fh_text.Text = fh_2;
        }

        private void fh_text_Click(object sender, EventArgs e)
        {

        }
    }
}
