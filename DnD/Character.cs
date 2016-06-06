﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD_App
{

    // enum Race { human, elf, orc }
    public class Character
    {

        private string charName;
        private int charHealth;
        private Weapon charWeapon;
        private int[] charStats;
        private int charMaxHealth;
        private List<Item> charInventory;
        //private Profession charProfession;
        //private Race charRace;

        public Character(String _name, int[] stats, int armor, Weapon wpan)
        {
            charName = _name;
            this.CharStats = stats;
            this.charHealth = 100;
            this.CharArmor = armor;
            this.charWeapon = wpan;
            charStats = new int[6];
        }

        public List<Item> Inventory
        {
            get { return charInventory; }
            set { charInventory = value; }
        }

        public string CharName
        {
            get { return charName; }
            set { charName = value; }
        }
        public int CharHealth
        {
            get { return charHealth; }
            set { charHealth = value; }
        }
        public int CharMaxHealth
        {
            get { return charMaxHealth; }
            set { charMaxHealth = value; }
        }
        public Weapon CharWeapon
        {
            get { return charWeapon; }
            set { charWeapon = value; }
        }
        public int GetDamage()
        {
            return charWeapon.WeapAttack + charStats[charWeapon.WeapEffStat];
        }

        /// <summary>
        /// will take fields from the user(strength, dex,con,int,....)
        /// size of six;
        /// </summary>
        public int[] CharStats { get; set; }
        public int CharArmor { get; set; }
        //public List<Item> CharInventory { get; set; }
        //public Profession CharProfession { get; set; }

    }
}
