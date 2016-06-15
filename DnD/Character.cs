using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnD
{

    // enum Race { human, elf, orc }
    [Serializable]
    public class Character
    {

        private string charName;
        private int charHealth;
        private Weapon charWeapon;
        private int charArmor;
        private Stats charStats;
        private int charMaxHealth;
        private List<Item> charInventory;
        private Stats charStatsMod;
        private int speed;

        public Character()
        {

        }

        public Character(string name, Stats stats, int armor, Weapon weapon, int maxHealth)
        {
            this.charName = name;
            this.charStats = stats;
            this.charArmor = armor;
            this.charWeapon = weapon;
            this.charMaxHealth = maxHealth;
            this.charHealth = maxHealth;
        }

        //this is used by character creation 
        public Character(string name, Stats stats, Stats statsMod, int armor, Weapon weapon, int maxHealth, int speed)
        {
            this.charName = name;
            this.charStats = stats;
            this.charStatsMod = statsMod;
            this.charArmor = armor;
            this.charWeapon = weapon;
            this.charMaxHealth = maxHealth;
            this.charHealth = maxHealth;
            this.speed = speed;
        }

        public Character(string name, Stats stats, int armor, int maxHealth, int currentHealth)
        {
            this.charName = name;
            this.charStats = stats;
            this.charArmor = armor;
            this.charMaxHealth = maxHealth;
            this.charHealth = maxHealth;
        }

        public Character(string name, int health)
        {
            charName = name;
            charHealth = health;
        }

        public int CharArmor
        {
            get { return charArmor; }
            set { charArmor = value; }
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

        public Stats CharStats
        {
            get { return charStats; }
            set { charStats = value; }
        }

        public Stats CharStatsMod
        {
            get { return charStatsMod; }
            set { charStatsMod = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int GetDamage()
        {
            return charWeapon.WeapAttack + charStatsMod.str;
        }

        public Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("name", charName);
            dict.Add("health", charHealth.ToString());
            dict.Add("maxHealth", charMaxHealth.ToString());
            dict.Add("armor", charArmor.ToString());
            return dict;
        }
    }
}
