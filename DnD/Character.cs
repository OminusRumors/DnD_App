using System;
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
        private int[] charStats = new int[6];
        //private Armor charArmor;
        //public List<Item> charInventory;
        //private Profession charProfession;
        //private Race charRace;

        public Character(String _name,int[] stats,int armor, Weapon wpan)
        {
            charName = _name;
            this.CharStats = stats;
            //Will change later
            this.charHealth = 50;
            this.CharArmor = armor;
            this.charWeapon = wpan;
           
        }


        public string CharName { get; set; }
        public int CharHealth { get; set; }
        public Weapon CharWeapon { get; set; }
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
