using DnD_App;
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
using DnD;

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

        public CharacterForm()
        {
            InitializeComponent();
            RefreshTextBox();
            doc.LoadXml("<character></character>");
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
            tempElement = doc.CreateElement("name");
            tempElement.InnerText = tbName.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("level");
            tempElement.InnerText = tbLevel.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("Strength");
            tempElement.InnerText = tbStrength.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("dexterity");
            tempElement.InnerText = tbDex.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("constitution");
            tempElement.InnerText = tbCons.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("inteligence");
            tempElement.InnerText = tbInt.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("wisdom");
            tempElement.InnerText = tbDex.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("dexterity");
            tempElement.InnerText = tbDex.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("charisma");
            tempElement.InnerText = tbChar.Text;
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("strMod");
            tempElement.InnerText = Convert.ToString(Math.Round((str - 10) / 2F));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("dexMod");
            tempElement.InnerText = Convert.ToString(Math.Round((dex - 10) / 2F));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("conMod");
            tempElement.InnerText = Convert.ToString(Math.Round((con - 10) / 2f));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("wisMod");
            tempElement.InnerText = Convert.ToString(Math.Round((wis - 10) / 2f));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("intMod");
            tempElement.InnerText = Convert.ToString(Math.Round((intel - 10) / 2f));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("chaMod");
            tempElement.InnerText = Convert.ToString(Math.Round((charis - 10) / 2f));
            newElements.Add(tempElement);

            tempElement = doc.CreateElement("health");
            tempElement.InnerText = Convert.ToString(Math.Round((str - 10) / 2f));
            newElements.Add(tempElement);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            foreach(XmlElement xml in newElements)
            {
                doc.DocumentElement.AppendChild(xml);
            }

            XmlWriter writer = XmlWriter.Create(tbName.Text+".xml", settings);
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

