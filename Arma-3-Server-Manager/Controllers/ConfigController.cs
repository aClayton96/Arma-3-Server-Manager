using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager.Controllers
{
    public static class ConfigController
    {
        public static bool SaveConfig(Dictionary<string, string> configValues)
        {
            ConfigHandler configHandler = new ConfigHandler("E:\\Arma 3 Server For C# Project\\Config");

            configHandler.WriteToFile(configValues);

            return true;
        }

        public static Dictionary<string, string> LoadConfig()
        {
            ConfigHandler configHandler = new ConfigHandler("E:\\Arma 3 Server For C# Project\\Config");

            return configHandler.LoadFromFile();
        }
    }
}
