using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager
{
    public class ConfigHandler
    {
        string configLocation;

        public ConfigHandler(string _configLocation)
        {
            configLocation = _configLocation;

            if (!Directory.Exists(configLocation))
            {
                DirectoryInfo di = Directory.CreateDirectory(configLocation);
            }

            if (!File.Exists($"{configLocation}\\Server_Config.cfg"))
            {
                File.Create($"{configLocation}\\Server_Config.cfg");
            }
        }

        public void WriteToFile(Dictionary<string, string> values)
        {
            List<string> lines = new List<string>();

            foreach(var line in values)
            {
                lines.Add(line.Key + "=" + line.Value);
            }

            File.WriteAllLinesAsync($"{configLocation}\\Server_Config.cfg", lines);
        }

        public Dictionary<string, string> LoadFromFile()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            var config = File.ReadAllLines($"{configLocation}\\Server_Config.cfg");

            foreach (var c in config)
            {
                var key = c.Split('=')[0];
                var value = c.Split('=')[1];

                values.Add(key, value);
            }

            return values;
        }
    }
}
