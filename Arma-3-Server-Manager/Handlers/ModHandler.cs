using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arma_3_Server_Manager.Logging;
using Arma_3_Server_Manager.Classes;
using System.IO;
using System.Collections.ObjectModel;

namespace Arma_3_Server_Manager.Handlers
{
    public static class ModHandler
    {

        public static List<Mod> getAvailableMods()
        {

            List<Mod> availableMods = new List<Mod>();
            try
            {
                var modFolders = Directory.GetDirectories(ManagerConstants.modDirectory).Where(c => c.Contains("@"));

                foreach (var modFolder in modFolders)
                {

                    var tag = Path.GetFileName(modFolder);
                    var name = tag.Substring(1);

                    availableMods.Add(new Mod(name, modFolder, tag));
                }

                return availableMods;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return new List<Mod>();
            }
            
        }
     }
}
