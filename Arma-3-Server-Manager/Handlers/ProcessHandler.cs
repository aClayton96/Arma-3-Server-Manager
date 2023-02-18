using System.Diagnostics;
using Arma_3_Server_Manager.Logging;
using System.Management;
using System;

namespace Arma_3_Server_Manager.Handlers
{
    public static class ProcessHandler
    {

        public static Process LaunchProcess(ProcessStartInfo processStartInfo) => Process.Start(processStartInfo);

        public static Process StopProcess(Process process)
        {
            try
            {
                process.Kill();
                return process;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return process;
            }
        }

        public static Process MonitorProcess(Process process)
        {
            throw new NotImplementedException();
        }
    }
}
