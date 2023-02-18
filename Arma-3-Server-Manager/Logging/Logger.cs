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

            if (!File.Exists($"{ManagerConstants.loggingLocation}\\{date}.txt"))
            {
                File.Create($"{ManagerConstants.loggingLocation}\\{date}.txt").Dispose();
            }
            File.AppendAllText($"{ManagerConstants.loggingLocation}\\{date}.txt", $"exception.Message \n");
        }

        public static void LogMessage(string message)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd-hh");
            
            if(!File.Exists($"{ManagerConstants.loggingLocation}\\{date}.txt"))
            {
                File.Create($"{ManagerConstants.loggingLocation}\\{date}.txt").Dispose();
            }
            File.AppendAllText($"{ManagerConstants.loggingLocation}\\{date}.txt", $"{message} \n");
        }
    }
}
