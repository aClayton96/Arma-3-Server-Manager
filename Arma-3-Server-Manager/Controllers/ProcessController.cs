using System.Diagnostics;
using Arma_3_Server_Manager.Logging;
using Arma_3_Server_Manager.Handlers;
using System.Linq;
using System;

namespace Arma_3_Server_Manager.Controllers
{
    public static class ProcessController
    {
        public static Process StartServer()
        {
            ProcessStartInfo start = new ProcessStartInfo();

            ConfigHandler configHandler = new ConfigHandler("E:\\Arma 3 Server For C# Project\\Config");

            var config = configHandler.LoadFromFile();

            var port = "2312";

            string modList = string.Join(";", ModHandler.getAvailableMods().Where(m => m.IsActive == true).Select(m => m.Tag));

            start.Arguments = $"-port={port} -config=\"CONFIG_server.cfg\" -world=empty \"-mod={modList}\"";

            start.FileName = "E:\\Arma 3 Server For C# Project\\Arma 3 Server\\arma3server_x64.exe";

            start.WindowStyle = ProcessWindowStyle.Normal;

            start.CreateNoWindow = false;

            int exitCode;

            Logger.LogMessage("Server starting");

            Logger.LogMessage($"{start.Arguments}");

            Logger.LogMessage($"{start.FileName}");

            try
            {
                return ProcessHandler.LaunchProcess(start);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return null;
            }
        }

        public static Process StopServer(Process process)
        {
            return ProcessHandler.StopProcess(process);
        }
    }
}
