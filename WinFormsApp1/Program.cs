using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //EdgeOptions edgeOptions = new EdgeOptions();
            ////Set edgeOptions to use Chromium and WebView2
            //edgeOptions.UseChromium = true;
            //edgeOptions.UseWebView = true;

            ////Set the BinaryLocation to the filepath of the WebView2API Sample runtime
            ////edgeOptions.BinaryLocation = @"C:\Users\Jason.Wu\source\repos\ConsoleApp1\WinFormsApp1\bin\Debug\net5.0-windows\WinFormsApp1.exe";
            //edgeOptions.BinaryLocation = @"C:\path\to\your\webview2\project.exe";

            //EdgeDriver e = new EdgeDriver(edgeOptions);
            ////Navigate the WebView2API Sample from bing.com to microsoft.com
            //e.Url = @"https://www.microsoft.com";

            ////Exit Microsoft Edge Driver
            //e.Quit();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}