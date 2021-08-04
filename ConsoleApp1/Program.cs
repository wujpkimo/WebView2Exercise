using System;
using System.Linq;
using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 取得本機名稱
            String strHostName = Dns.GetHostName();

            // 取得本機的 IpHostEntry 類別實體
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // 取得所有 IP 位址
            int num = 1;

            var ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            Console.WriteLine(ip);

            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + num + ": " + ipaddress.ToString());
                num = num + 1;
            }

            //var ip = Dns.GetHostByName(Dns.GetHostName()).AddressList[1];
        }
    }
}