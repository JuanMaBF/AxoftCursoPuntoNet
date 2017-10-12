using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AWMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            FSW.Watcher w = new FSW.Watcher();
            w.StartWatch(@"C:\NET 2.0 Avanzado\Labfiles\Lab 01\Receive", "*.xml");
            Watch(w);

            Console.WriteLine("Presione ENTER cuando desee finalizar.\r\n\r\n");
            Console.ReadLine();
        }

     

        public static void Watch(FSW.Watcher w)
        {
            w.NewFileHandler += new FSW.Watcher.NewFileEventHandler(onNotificationArrived);
            w.NewFileHandler += W_NewFileHandler;
        }

        private static void W_NewFileHandler(object sender, FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void onNotificationArrived(object sender, FileSystemEventArgs e)
        {
            try
            {
                Console.WriteLine("Nueva PO: " + e.FullPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
