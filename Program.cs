using System;
using System.Xml;
using System.IO;
using log4net;

namespace test_log4net
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("Hello World! from log4net");
            Console.WriteLine("Hello World!");
        }
    }
}
