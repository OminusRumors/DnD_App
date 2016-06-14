using DnD;
using System;
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
        public CharacterForm(DnDServer server, DnDClient client)
        {
            InitializeComponent();
            int [] skills=new int[6];
            //Character c = new Character("george", skills, 15, new Weapon());

            //DnDMessage msg = new DnDMessage("character_info", c.ToDictionary());
            //client.sendMessage(msg);
        }


        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }

    }
}
