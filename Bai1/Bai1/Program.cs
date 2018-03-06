using System;
using System.Net;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry iphost = Dns.GetHostByAddress(IPAddress.Loopback);
            Console.WriteLine("host name: " + iphost.HostName);
            Console.WriteLine("Day IP: ");
            foreach (IPAddress ip in iphost.AddressList)
            {
                Console.WriteLine(ip);
            }
            Console.ReadLine();
        }
    }
}
