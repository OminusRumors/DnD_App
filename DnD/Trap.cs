using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD_App
{
    public class Trap
    {
        private int trapId;
        private int trapDamage;
        private int trapVisibility;
        private bool trapTraversible;

        public int TrapId
        {
            get { return trapId; }
            set { trapId = value; }
        }

        public int TrapDamage
        {
            get { return trapDamage; }
            set { trapDamage = value; }
        }

        public int TrapVisibility
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
