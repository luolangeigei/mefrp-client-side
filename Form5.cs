using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : MaterialForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string wj1 = System.IO.File.ReadAllText(@AppDomain.CurrentDomain.BaseDirectory + "token.txt");
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://api.lae.yistars.net/api/work-orders?title=来自donet客户端的工单rp&module_id=frp&content="+materialMultiLineTextBox21.Text+"&host_id=171");
            request.Headers["name"] = "csrf-token";//创建一个请求示例 
            request.Headers["content"] = wj1;//创建一个请求示例
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + wj1);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();  //获取响应，即发送请求
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
            string str = streamReader.ReadToEnd();
            System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "cs.txt", str);
            JObject obj1 = JObject.Parse(str);
            string success = obj1["success"].ToString();
            if (success == "1")
            {
                MessageBox.Show("提交成功！", "提示");
            }
            else
            {
                MessageBox.Show("提交失败！", "提示");
            }
        }
    }
}
