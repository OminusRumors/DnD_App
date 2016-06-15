using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Armor
    {
        public string name;
        public int protection;

        public Armor(string name,int protection)
        {
            this.name = name;
            this.protection = protection;
        }
    }
}
