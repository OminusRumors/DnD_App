using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    [Serializable]
    class Stats
    {
        public int str { get; private set; }
        public int dex { get; private set; }
        public int con { get; private set; }
        public int intel { get; private set; }
        public int wis { get; private set; }
        public int charis { get; private set; }

        public Stats()
        { }

        public Stats(int str, int dex,int con,int intel,int wis,int charis)
        {
            this.str = str;
            this.dex = dex;
            this.con = con;
            this.intel = intel;
            this.wis = wis;
            this.charis = charis;
        }
    }
}
