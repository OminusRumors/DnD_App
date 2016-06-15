using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Race
    {
        public string name;
        public int charis;
        public int con;
        public int dex;
        public int str;
        public int intel;
        public int wis;
        public int speed;

        public Race(string name, int v1, int v2, int v3, int v4, int v5, int v6,int speed)
        {
            this.name = name;
            this.str = v1;
            this.dex = v2;
            this.con = v3;
            this.wis = v4;
            this.intel = v5;
            this.charis = v6;
            this.speed = speed;
        }
    }
}
