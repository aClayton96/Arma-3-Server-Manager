using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arma_3_Server_Manager.Classes;

namespace Arma_3_Server_Manager.Logging
{
    public static class Logger
    {
        public static void LogError(Exception exception)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd-hh");

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + ManagerConstants.loggingFolderName;

            if(!System.IO.Directory.Exists(fileName))
            {
                System.IO.Directory.CreateDirectory(fileName);
            }

            if (!File.Exists($"{fileName}\\{date}.txt"))
            {
                File.Create($"{fileName}\\{date}.txt").Dispose();
            }
            File.AppendAllText($"{fileName}\\{date}.txt", $"{exception.Message} \n");
        }

        public static void LogMessage(string message)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd-hh");

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + ManagerConstants.loggingFolderName;

            if (!System.IO.Directory.Exists(fileName))
            {
                System.IO.Directory.CreateDirectory(fileName);
            }

            if (!File.Exists($"{fileName}\\{date}.txt"))
            {
                File.Create($"{fileName}\\{date}.txt").Dispose();
            }
            File.AppendAllText($"{fileName}\\{date}.txt", $"{message} \n");
        }
    }
}
