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
        private int[] charStats;
        private int charMaxHealth;
        private List<Item> charInventory;

        public Character(string name, int[] stats, int armor, Weapon weapon, int maxHealth)
        {
            this.charName = name;
            this.charStats = stats;
            this.charArmor = armor;
            this.charWeapon = weapon;
            this.charMaxHealth = maxHealth;
            this.charHealth = maxHealth;
        }

        public Character(string name, int[] stats, int armor, int maxHealth, int currentHealth)
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
        public int GetDamage()
        {
            return charWeapon.WeapAttack + charStats[charWeapon.WeapEffStat];
        }

        public Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("name", charName);
            dict.Add("health", charHealth.ToString());
            dict.Add("maxHealth", charMaxHealth.ToString());
            dict.Add("armor", charArmor.ToString());

            for (int i = 0; i < charStats.Length; i++)
            {
                string stat = i.ToString();
                dict.Add(stat, charStats[i].ToString());
            }

            return dict;
        }
    }
}
