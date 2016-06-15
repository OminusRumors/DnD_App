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
        private int str = 8;
        private int dex = 8;
        private int con = 8;
        private int intel = 8;
        private int wis = 8;
        private int charis = 8;
        private int points = 27;
        private XmlDocument doc = new XmlDocument();
        private List<Classes> classes = new List<Classes> { };
        private List<Race> races = new List<Race> { };

        public CharacterForm()
        {
            InitializeComponent();
            RefreshTextBox();
            doc.LoadXml("<character></character>");
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
            if (value > 12 && points < 2)
            {
                return false;
            }
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
            List<XmlElement> newElements = new List<XmlElement> { };
            XmlElement tempElement;
            Race r = races[cmbRace.SelectedIndex];
            Classes c = classes[cmbClass.SelectedIndex];
            int tempStr = (str + r.str);
            int tempDex = (dex + r.dex);
            int tempCon = (con + r.con);
            int tempInt = (intel + r.intel);
            int tempWis = (wis + r.wis);
            int tempChar = (charis + r.charis);

            tempElement = doc.CreateElement("name");
            tempElement.InnerText = tbName.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("class");
            tempElement.InnerText = c.name;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("race");
            tempElement.InnerText = r.name;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("level");
            tempElement.InnerText = tbLevel.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("Strength");
            tempElement.InnerText = tempStr.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("dexterity");
            tempElement.InnerText = tempDex.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("constitution");
            tempElement.InnerText = tempCon.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("inteligence");
            tempElement.InnerText = tempInt.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("wisdom");
            tempElement.InnerText = tempWis.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("charisma");
            tempElement.InnerText = tempChar.ToString();
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("strMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempStr - 10) / 2F) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("dexMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempDex - 10) / 2F) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("conMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempCon - 10) / 2f) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("wisMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempWis - 10) / 2f) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("intMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempInt - 10) / 2f) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("chaMod");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempChar - 10) / 2f) - 0.5));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("health");
            tempElement.InnerText = Convert.ToString(Math.Round(((tempCon - 10) / 2f) - 0.5) + c.baseHealth);
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("speed");
            tempElement.InnerText = Convert.ToString(r.speed);
            newElements.Add(tempElement);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            foreach (XmlElement xml in newElements)
            {
                doc.DocumentElement.AppendChild(xml);
            }

            XmlWriter writer = XmlWriter.Create(tbName.Text + ".xml", settings);
            doc.Save(writer);
        }

        private void tbLevel_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(tbLevel.Text, out value))
            {
                points = 25 + value * 2;
            }
            else
            {
                points = 25;
            }
            RefreshTextBox();
        }
    }
}

