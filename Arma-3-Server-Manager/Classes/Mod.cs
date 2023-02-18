using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arma_3_Server_Manager.Classes
{
    public class Mod
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Tag { get; set; }
        public bool IsActive { get; set; }

        public Mod(string _name, string _directory, string _tag)
        {
            Name = _name;
            Directory = _directory;
            Tag = _tag;
            IsActive = false;
        }
    }
}
