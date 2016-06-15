﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{
    [Serializable]
    public class Weapon
    {
        private string wepName;
        private int weapAttack;
        private int weapRange;
        /// <summary>
        /// Maximum of 10
        /// </summary>
        private int weapCriticalChance;
        private int weapEffectiveStat;
        
        public Weapon()
        { }
        /*
        public Weapon(int attack)
        {
            this.weapAttack = attack;
            this.weapRange = 2;
            this.weapCriticalChance = 3;
            this.weapEffectiveStat = 1;
        }
        */
        public Weapon(string wepName, int attack, int range, int critChance, int effStat)
        {
            this.wepName = wepName;
            this.weapAttack = attack;
            this.weapRange = range;
            this.weapCriticalChance = critChance;
            this.weapEffectiveStat = effStat;
        }

        public Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("weapon", wepName);
            dict.Add("attack", weapAttack.ToString());
            dict.Add("range", weapRange.ToString());
            dict.Add("critical", weapCriticalChance.ToString());
            dict.Add("effective", weapEffectiveStat.ToString());
            return dict;
        }

        public string GetName
        {
            get { return wepName; }
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
