using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Trap : IObject
    {
        private string trapId;
        private int trapDamage;
        private bool trapVisibility;
        private bool trapTraversible;

        public Trap()
        { }

        public Trap(string id, int damage, bool visibility,bool traversal)
        {
            this.trapId = id;
            this.trapDamage = damage;
            this.trapVisibility = visibility;
            this.trapTraversible = traversal;
        }

        public string TrapId
        {
            get { return trapId; }
            set { trapId = value; }
        }

        public int TrapDamage
        {
            get { return trapDamage; }
            set { trapDamage = value; }
        }

        public bool TrapVisibility
        {
            get { return trapVisibility; }
            set { trapVisibility = value; }
        }

        public bool TrapTraversible
        {
            get { return trapTraversible; }
            set { trapTraversible = value; }
        }
    }
}
