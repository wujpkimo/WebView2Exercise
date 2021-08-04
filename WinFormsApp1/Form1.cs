using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using OpenQA.Selenium.Edge;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            var uri = new Uri("https://mi.bestyield.com/");
            webView.Source = uri;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var weight = 123;
            await webView.ExecuteScriptAsync($"document.getElementById('LoginId').value='{weight}'");
        }

        private void webView21_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            //button1.Left = this.ClientSize.Width - button1.Width;
            //button2.Width = button1.Left - button2.Left;
        }
    }
}