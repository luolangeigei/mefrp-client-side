
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    
    public partial class Form4 : MaterialForm
    {
        string wj1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "token.txt"))
            {
                Form f = new token();
                f.ShowDialog();
            }
            wj1 = System.IO.File.ReadAllText(@AppDomain.CurrentDomain.BaseDirectory + "token.txt");
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://api.lae.yistars.net/api/users");
            request.Headers["name"] = "csrf-token";//创建一个请求示例 
            request.Headers["content"] = wj1;//创建一个请求示例
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();  //获取响应，即发送请求
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
            string str = streamReader.ReadToEnd();
           // System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "cs.txt",str);
            JObject obj1 = JObject.Parse(str);
            string balance = obj1["data"]["balance"].ToString();
            string name1 = obj1["data"]["name"].ToString();
            string id1 = obj1["data"]["id"].ToString();
            drops_text.Text = "余额："+balance;
            name_text.Text="用户名："+name1;
            id_text.Text = "ID：" + id1;
            HttpWebRequest request2 = (HttpWebRequest)HttpWebRequest.Create("https://api.lae.yistars.net/api/hosts/usages");
            request2.Headers["name"] = "csrf-token";//创建一个请求示例 
            request2.Headers["content"] = wj1;//创建一个请求示例
            request2.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            request2.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();  //获取响应，即发送请求
            Stream responseStream2 = response2.GetResponseStream();
            StreamReader streamReader2 = new StreamReader(responseStream2, Encoding.UTF8);
            string str2 = streamReader2.ReadToEnd();
            System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "cs.txt", str2);
            //JObject obj2 = JObject.Parse(str2);
            //string balance2 = obj1["data"]["balance"].ToString();



            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create("https://api.lae.yistars.net/api/modules/frp/hosts/");
            request1.Headers["name"] = "_token";//创建一个请求示例 
            request1.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();  //获取响应，即发送请求
            Stream responseStream1 = response1.GetResponseStream();
            StreamReader streamReader1 = new StreamReader(responseStream1, Encoding.UTF8);
            string str1 = streamReader1.ReadToEnd();
            JObject obj = Newtonsoft.Json.Linq.JObject.Parse(str1);

           string RecordData = obj["data"].ToString();

            JArray array = Newtonsoft.Json.Linq.JArray.Parse(RecordData);

            foreach (var ss in array)  //遍历JArray 数组
            {
                //id
                string id = ss["id"].ToString();
                //名字
                string name = ss["name"].ToString();
                //传输方式
                string protocol = ss["protocol"].ToString();
                //域名
                string custom_domain = ss["custom_domain"].ToString();
                //需要分割！！！！！本地ip和端口
                string local_address = ss["local_address"].ToString();
                //密钥
                string client_token = ss["client_token"].ToString();
                //服务器地址
                string server_adress = ss["server"]["server_address"].ToString();
                //服务器端口
                string server_port = ss["server"]["server_port"].ToString();
                //本地端口本地ip
                string[] cocal_id = local_address.Split(':');



                //判断是否是最后一条数据
                if (ss == array[array.Count() - 1])
                {
                    Directory.CreateDirectory(@AppDomain.CurrentDomain.BaseDirectory + "awa");
                    string[] lines = { "[common]", "server_addr = " + server_adress, "server_port = " + server_port, "token = Hello,MEFRP", "[" + client_token + "]", "type = " + protocol, "local_ip = " + cocal_id[0], "local_port = " + cocal_id[1], "custom_domains = " + custom_domain };

                    System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + name + ".ini", lines);
                    server_list.Items.Add(name);


                }
                else
                {
                    Directory.CreateDirectory(@AppDomain.CurrentDomain.BaseDirectory + "awa");
                    string[] lines = { "[common]", "server_addr = " + server_adress, "server_port = " + server_port, "token = Hello,MEFRP", "[" + client_token + "]", "type = " + protocol, "local_ip = " + cocal_id[0], "local_port = " + cocal_id[1], "custom_domains = " + custom_domain };

                    System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + name + ".ini", lines);
                    server_list.Items.Add(name);
                }
            }


        }

        private void shuax()
        {
            string wj2 = System.IO.File.ReadAllText(@AppDomain.CurrentDomain.BaseDirectory + "ovo.txt");
            char[] delimiterChars = { '\n' };
            string[] words = wj2.Split(delimiterChars);
            int a;
            for (a = 0; a < words.Length; a++)
                server_list.Items.Add(words[a]);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        { 
            HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create("https://api.lae.yistars.net/api/modules/frp/hosts/");
            request1.Headers["name"] = "_token";//创建一个请求示例 
            request1.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();  //获取响应，即发送请求
            Stream responseStream1 = response1.GetResponseStream();
            StreamReader streamReader1 = new StreamReader(responseStream1, Encoding.UTF8);
            string str1 = streamReader1.ReadToEnd();
            JObject obj = Newtonsoft.Json.Linq.JObject.Parse(str1);

            string RecordData = obj["data"].ToString();

            JArray array = Newtonsoft.Json.Linq.JArray.Parse(RecordData);

            foreach (var ss in array)  //遍历JArray 数组
            {
                //id
                string id = ss["id"].ToString();
                //名字
                string name = ss["name"].ToString();
                //传输方式
                string protocol = ss["protocol"].ToString();
                //域名
                string custom_domain = ss["custom_domain"].ToString();
                //需要分割！！！！！本地ip和端口
                string local_address = ss["local_address"].ToString();
                //密钥
                string client_token = ss["client_token"].ToString();
                //服务器地址
                string server_adress = ss["server"]["server_address"].ToString();
                //服务器端口
                string server_port = ss["server"]["server_port"].ToString();
                //本地端口本地ip
                string[] cocal_id = local_address.Split(':');



                //判断是否是最后一条数据
                if (ss == array[array.Count() - 1])
                {
                    Directory.CreateDirectory(@AppDomain.CurrentDomain.BaseDirectory + "awa");
                    string[] lines = { "[common]", "server_addr = " + server_adress, "server_port = " + server_port, "token = Hello,MEFRP", "[" + client_token + "]", "type = " + protocol, "local_ip = " + cocal_id[0], "local_port = " + cocal_id[1], "custom_domains = " + custom_domain };

                    System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + name + ".ini", lines);
                    server_list.Items.Add(name);


                }
                else
                {
                    Directory.CreateDirectory(@AppDomain.CurrentDomain.BaseDirectory + "awa");
                    string[] lines = { "[common]", "server_addr = " + server_adress, "server_port = " + server_port, "token = Hello,MEFRP", "[" + client_token + "]", "type = " + protocol, "local_ip = " + cocal_id[0], "local_port = " + cocal_id[1], "custom_domains = " + custom_domain };

                    System.IO.File.WriteAllLines(@AppDomain.CurrentDomain.BaseDirectory + "awa//" + name + ".ini", lines);
                    server_list.Items.Add(name);
                }
            }

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            common.awa = server_list.Text;
            Form2 f = new Form2();
            f.ShowDialog();
            string fh_2 = RunCmd("frpc.exe -c awa\\" + server_list.Text + ".ini");
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

        private void materialButton3_Click(object sender, EventArgs e)
        {

          
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            System.IO.File.Delete(@AppDomain.CurrentDomain.BaseDirectory + "token.txt");
            token f = new token();
            f.ShowDialog();
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            wt f = new wt();
            f.ShowDialog();
        }
    }
    public class Rootobject
    {
        public Datum[] data { get; set; }
        public int status { get; set; }
            public int success { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string module_id { get; set; }
            public int user_id { get; set; }
            public int price { get; set; }
            public string managed_price { get; set; }
            public object configuration { get; set; }
            public string status { get; set; }
            public object suspended_at { get; set; }
            public object deleted_at { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public Module module { get; set; }

            public static implicit operator Datum(string v)
            {
                throw new NotImplementedException();
            }
        }

        public class Module
        {
            public string id { get; set; }
            public string name { get; set; }
        }



    }

