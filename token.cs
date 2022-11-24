using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class token : MaterialForm
    {
        public token()
        {
            InitializeComponent();
        }

        private void token_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@AppDomain.CurrentDomain.BaseDirectory + "token.txt", token_text.Text);
            MessageBox.Show("登录成功！", "提示");
            System.Windows.Forms.Application.Restart();
        }

        private void token_text_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.laecloud.com/");
        }
    }
}
