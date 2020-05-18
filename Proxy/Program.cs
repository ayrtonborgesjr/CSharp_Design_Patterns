using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy");
            Console.WriteLine();

            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
