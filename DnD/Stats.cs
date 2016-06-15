using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    [Serializable]
    public class Stats
    {
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int intel { get; set; }
        public int wis { get; set; }
        public int charis { get; set; }

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
