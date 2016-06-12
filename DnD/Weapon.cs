using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD_App
{
    public class Weapon
    {
        private int weapAttack;
        private int weapRange;
        /// <summary>
        /// Maximum of 10
        /// </summary>
        private int weapCriticalChance;
        private int weapEffectiveStat;

        public Weapon()
        { }

        public Weapon(int attack, int range, int critChance, int effStat)
        {
            this.weapAttack = attack;
            this.weapRange = range;
            this.weapCriticalChance = critChance;
            this.weapEffectiveStat = effStat;
        }

        public int WeapAttack
        {
            get { return weapAttack; }
            set { weapAttack = value; }
        }
        public int WeapRange
        {
            get { return weapRange; }
            set { weapRange = value; }
        }
        public int WeapCriticalChance
        {
            get { return weapCriticalChance; }
            set { weapCriticalChance = value; }
        }
        public int WeapEffStat
        {
            get { return weapEffectiveStat; }
            set { weapEffectiveStat = value; }
        }
    }
}
