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
        private int str;
        private int dex;
        private int con;
        private int intel;
        private int wis;
        private int charis;

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
