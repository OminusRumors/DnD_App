using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Classes
    {
        public int baseHealth;
        public string name;

        public Classes(string name, int v)
        {
            this.name = name;
            this.baseHealth = v;
        }
    }
}
