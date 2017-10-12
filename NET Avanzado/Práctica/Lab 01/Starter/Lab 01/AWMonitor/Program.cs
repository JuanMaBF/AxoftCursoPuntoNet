using System;
using System.IO;

namespace AWMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            FSW.Watcher w = new FSW.Watcher();
            w.StartWatch(@"C:\Lab 01\Receive", "*.xml");
            Watch(w);

            Console.WriteLine("Presione ENTER cuando desee finalizar.\r\n\r\n");
            Console.ReadLine();
        }

        private static void onNotificationArrived(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Nueva PO: " + e.FullPath);
        }

        public static void Watch(FSW.Watcher w)
        {
            w.NewFileHandler += new FSW.Watcher.NewFileEventHandler(onNotificationArrived);
        }
    }
}
