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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uri = new Uri("https://mi.bestyield.com/");
            webView21.Source = uri;
        }

        private void webView21_Click(object sender, EventArgs e)
        {
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            var weight = 123;
            await webView21.ExecuteScriptAsync($"document.getElementById('LoginId').value='{weight}'");
        }
    }
}