using DnD;
using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD
{
    public partial class CharacterForm : Form
    {
        private SaveLoadCharacter slc = new SaveLoadCharacter();
        private int str = 8;
        private int dex = 8;
        private int con = 8;
        private int intel = 8;
        private int wis = 8;
        private int charis = 8;
        private int points = 27;
        private List<Classes> classes = new List<Classes> { };
        private List<Race> races = new List<Race> { };
        private List<Weapon> weapons = new List<Weapon> { };
        private List<Armor> armors = new List<Armor> { };

        public CharacterForm()
        {
            InitializeComponent();
            RefreshTextBox();

            XmlTextReader readClass = new XmlTextReader("Class.xml");
            List<string> items = new List<string> { };
            while (readClass.Read())
            {
                switch (readClass.NodeType)
                {
                    case XmlNodeType.Text:
                        items.Add(readClass.Value);
                        break;
                }
            }

            for (int i = 0; i < items.Count; i = i + 2)
            {
                classes.Add(new Classes(items[i], Convert.ToInt32(items[i + 1])));
                cmbClass.Items.Add(items[i]);
            }

            XmlTextReader readRace = new XmlTextReader("Races.xml");
            items = new List<string> { };
            while (readRace.Read())
            {
                switch (readRace.NodeType)
                {
                    case XmlNodeType.Text:
                        items.Add(readRace.Value);
                        break;
                }
            }

            for (int i = 0; i < items.Count; i = i + 8)
            {
                races.Add(new Race(items[i], Convert.ToInt32(items[i + 1]), Convert.ToInt32(items[i + 2]), Convert.ToInt32(items[i + 3]), Convert.ToInt32(items[i + 4]), Convert.ToInt32(items[i + 5]), Convert.ToInt32(items[i + 6]),Convert.ToInt32(items[i+7])));
                cmbRace.Items.Add(items[i]);
            }

            XmlTextReader readWeapon = new XmlTextReader("Weapon.xml");
            items = new List<string> { };
            while (readWeapon.Read())
            {
                switch (readWeapon.NodeType)
                {
                    case XmlNodeType.Text:
                        items.Add(readWeapon.Value);
                        break;
                }
            }

            for (int i = 0; i < items.Count; i = i + 5)
            {
                weapons.Add(new Weapon(items[i], Convert.ToInt32(items[i + 1]), Convert.ToInt32(items[i + 2]), Convert.ToInt32(items[i + 3]), Convert.ToInt32(items[i + 4])));
                cmbMain.Items.Add(items[i]);
            }

            XmlTextReader readArmor = new XmlTextReader("Armour.xml");
            items = new List<string> { };
            while (readArmor.Read())
            {
                switch (readArmor.NodeType)
                {
                    case XmlNodeType.Text:
                        items.Add(readArmor.Value);
                        break;
                }
            }

            for (int i = 0; i < items.Count; i = i + 2)
            {
                armors.Add(new Armor(items[i], Convert.ToInt32(items[i + 1])));
                cmbArmor.Items.Add(items[i]);
            }
        }

        private void RefreshTextBox()
        {
            tbStrength.Text = str.ToString();
            tbDex.Text = dex.ToString();
            tbInt.Text = intel.ToString();
            tbCons.Text = con.ToString();
            tbChar.Text = charis.ToString();
            tbwis.Text = wis.ToString();
            tbPointsRemaining.Text = points.ToString();
        }

        private bool CheckChange(int value, int amount)
        {
            if (amount < 0)
            {
                if (value == 8)
                {
                    return false;
                }
                return true;
            }
            if (points<=0)
            {
                return false;
            }
            if (value > 12 && points < 2)
            {
                return false;
            }
            if (value > 15 && points < 3)
                return false;
            return true;
        }

        private int EditPoints(int value, int direction)
        {
            int pointValue = 1;
            if (value > 13)
                pointValue = 2;
            if (value > 15)
                pointValue = 3;
            if (direction < 0)
            {
                pointValue = pointValue * -1;
            }
            points -= pointValue;
            return pointValue;
        }

        private void btnStrDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(str, direction))
            {
                int temp = EditPoints(str, direction);
                str += temp;
            }
            RefreshTextBox();
        }

        private void btnStrUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(str, direction))
            {
                int temp = EditPoints(str, direction);
                str += temp;
            }
            RefreshTextBox();
        }

        private void btnDexDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(dex, direction))
            {
                int temp = EditPoints(dex, direction);
                dex += temp;
            }
            RefreshTextBox();
        }

        private void btnDexUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(dex, direction))
            {
                int temp = EditPoints(dex, direction);
                dex += temp;
            }
            RefreshTextBox();
        }

        private void btnConDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(con, direction))
            {
                int temp = EditPoints(con, direction);
                con += temp;
            }
            RefreshTextBox();
        }

        private void btnConUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(con, direction))
            {
                int temp = EditPoints(con, direction);
                con += temp;
            }
            RefreshTextBox();
        }

        private void btnIntDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(intel, direction))
            {
                int temp = EditPoints(intel, direction);
                intel += temp;
            }
            RefreshTextBox();
        }

        private void btnIntUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(intel, direction))
            {
                int temp = EditPoints(intel, direction);
                intel += temp;
            }
            RefreshTextBox();
        }

        private void btnWisDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(wis, direction))
            {
                int temp = EditPoints(wis, direction);
                wis += temp;
            }
            RefreshTextBox();
        }

        private void btnWisUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(wis, direction))
            {
                int temp = EditPoints(wis, direction);
                wis += temp;
            }
            RefreshTextBox();
        }

        private void btnCharDown_Click(object sender, EventArgs e)
        {
            int direction = -1;
            if (CheckChange(charis, direction))
            {
                int temp = EditPoints(charis, direction);
                charis += temp;
            }
            RefreshTextBox();
        }

        private void btnCharUp_Click(object sender, EventArgs e)
        {
            int direction = 1;
            if (CheckChange(charis, direction))
            {
                int temp = EditPoints(charis, direction);
                charis += temp;
            }
            RefreshTextBox();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Race r = races[cmbRace.SelectedIndex];
            Classes c = classes[cmbClass.SelectedIndex];
            Weapon w = weapons[cmbMain.SelectedIndex];
            Armor a = armors[cmbArmor.SelectedIndex];
            int tempStr = (str + r.str);
            int tempDex = (dex + r.dex);
            int tempCon = (con + r.con);
            int tempInt = (intel + r.intel);
            int tempWis = (wis + r.wis);
            int tempChar = (charis + r.charis);

            Stats stats = new Stats(tempStr, tempDex, tempCon, tempInt, tempWis, tempChar );

            Stats statsMod = new Stats( (int)Math.Round(((tempStr - 10) / 2F) - 0.5), (int)Math.Round(((tempDex - 10) / 2F) - 0.5), (int)Math.Round(((tempCon - 10) / 2f) - 0.5), (int)Math.Round(((tempInt - 10) / 2f) - 0.5), (int)Math.Round(((tempWis - 10) / 2f) - 0.5), (int)Math.Round(((tempChar - 10) / 2f) - 0.5) );

            Character character = new Character(tbName.Text, stats, statsMod, a.protection, w, (int)Math.Round(((tempCon - 10) / 2f) - 0.5) + c.baseHealth, r.speed);

            slc.SerializeObject<Character>(character, tbName.Text+".char");
            
            this.Close();

        }

        private void tbLevel_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(tbLevel.Text, out value))
            {
                points = 25 + value * 2;
                str = 8;
                dex = 8;
                con = 8;
                intel = 8;
                wis = 8;
                charis = 8;
            }
            else
            {
                points = 25;
                str = 8;
                dex = 8;
                con = 8;
                intel = 8;
                wis = 8;
                charis = 8;
            }
            RefreshTextBox();
        }
    }
}

