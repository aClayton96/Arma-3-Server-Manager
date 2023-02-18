using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager.Handlers
{
    public class SteamHandler
    {
        private string Username;
        private string Password;

        public SteamHandler()
        {
            Username = "Default";
            Password = "Default";
        }

        public List<string> GetDownloadUrls(string HTML)
        {
            List<string> downloadUrls = new List<string>();

            return downloadUrls;
        }

        public void DownloadMod(string downloadUrl)
        {
            //Take URL

            //Send command to SteamCMD
        }

        public void InstallServerInstance()
        {
            //Grab URL from constants

            //Send command to SteamCMD
        }

    }
}
