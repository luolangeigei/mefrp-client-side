using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Threading;
using System.Dynamic;
using static System.Windows.Forms.AxHost;

namespace $safeprojectname$
{
    
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
                string wj1 = File.ReadAllText(@AppDomain.CurrentDomain.BaseDirectory + "ovo.txt");
            char[] delimiterChars = { '\n' };
            string[] words = wj1.Split(delimiterChars);
            int a;
            for (a = 0; a < words.Length; a++)
                suidao_save.Items.Add(words[a]);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@AppDomain.CurrentDomain.BaseDirectory + "awa");
            string[] lines = { "[common]", "server_addr = " + t_server_addr.Text, "server_port =  " + t_server_port.Text, "token = Hello,MEFRP", "[" + token_text.Text + "]", "type = " + t_type.Text, "local_ip = " + t_local_ip.Text, "local_port = " + t_local_port.Text, "custom_domains = " + t_custom_domains.Text };
            System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + t_name.Text + ".ini", lines);
            System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "ovo.txt", File.ReadAllText(@AppDomain.CurrentDomain.BaseDirectory + "ovo.txt") + t_name.Text + "\n");
            common.awa = t_name.Text;
            Form2 f = new Form2();
            f.ShowDialog();

        }
        private void a()
        {


            //char[] delimiterChars = { '\n' };
            //string[] lines = { "[common]", "server_addr = " + t_server_addr.Text, "server_port =  " + t_server_port.Text, "token = Hello,MEFRP", "[" + token_text.Text + "]", "type = " + t_type.Text, "local_ip = " + t_local_ip.Text, "local_port = " + t_local_port.Text, "custom_domains = " + t_custom_domains.Text };
            //System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + t_name.Text + ".ini", lines);
            //System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "ovo.txt", t_name.Text + "\n");
            //RunCmd("cd " + AppDomain.CurrentDomain.BaseDirectory);    //执行命令
            //string fh_2 = RunCmd("frpc.exe -c awa\\" + t_name.Text + ".ini");
            //控制台输出返回结果
            //string[] words = fh_2.Split(delimiterChars);
            //int a;
            //for (a = 0; a < words.Length; a++)
            //{
            //fh_list.AddItem(words[a]);
            //  System.Windows.Forms.Application.DoEvents();
            //}
        }



        private void materialButton2_Click(object sender, EventArgs e)
        {
            common.awa = suidao_save.Text;
            Form2 f = new Form2();
            f.ShowDialog();
           // string fh_1 = RunCmd("cd " + AppDomain.CurrentDomain.BaseDirectory);    //执行命令
            //string fh_2 = RunCmd("frpc.exe -c awa\\" + suidao_save.Text + ".ini");
            //char[] delimiterChars = { '\n' };
            //string[] words = fh_2.Split(delimiterChars);
            //int a;
            //for (a = 0; a < words.Length; a++)
            //{
              //  fh_list.AddItem(words[a]);

            //}


        }
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        /// <summary>
        /// 执行cmd命令 返回cmd窗口显示的信息
        /// 多命令请使用批处理命令连接符：
        /// <![CDATA[
        /// &:同时执行两个命令
        /// |:将上一个命令的输出,作为下一个命令的输入
        /// &&：当&&前的命令成功时,才执行&&后的命令
        /// ||：当||前的命令失败时,才执行||后的命令]]>
        /// </summary>
        ///<param name="cmd">执行的命令</param>
        public static string RunCmd(string cmd)
        {
 
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = false; //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = false; //重定向标准错误输出
                p.StartInfo.CreateNoWindow = false; //不显示程序窗口
                p.Start();//启动程序
                
                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;
                p.StandardInput.Close();
                //获取cmd窗口的输出信息
               // string output = p.StandardOutput.ReadToEnd();  
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
                return "1";
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dash.laecloud.com/modules/tunnels/compact");
        }
    }

   
}
