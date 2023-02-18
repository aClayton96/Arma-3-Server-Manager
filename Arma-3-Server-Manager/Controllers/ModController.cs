using Arma_3_Server_Manager.Classes;
using Arma_3_Server_Manager.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager.Controllers
{
    public static class ModController
    {
        public static List<Mod> GetAvailableMods()
        {
            return ModHandler.getAvailableMods();
        }
    }
}
