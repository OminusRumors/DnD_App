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
    public partial class PlayerForm : Form
    {
        TCPClient client;
        Character character;
        Dictionary<Character, Point> charPositions;
        public PlayerForm(Character c, TCPClient client)
        {
            InitializeComponent();
            pbGameGrid.Width = 900;
            pbGameGrid.Height = 495;
            this.character = c;
            this.client = client;
            DnDMessage msg = new DnDMessage("initialize_player", character.ToDictionary());
            client.sendMessage(msg);
            MessageBox.Show(c.CharName);
            msg = new DnDMessage("weapon", character.CharWeapon.ToDictionary());
            client.sendMessage(msg);
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            client.AddMessageDelegate(ServerMessage);
        }

        public void ServerMessage(DnDMessage msg)
        {
            if (msg.Action=="not_your_turn")
            {
                //deactivate what is not needed while it's not the player's turn
            }
            else if(msg.Action=="your_turn")
            {
                //activate the form controls
            }
        }

        public Character Character
        {
            set { this.character = value; }
            get { return this.character; }
        }

        public Dictionary<Character, Point> CharPositions
        {
            set { charPositions = value; }
            get { return charPositions; }
        }

        public Character GetCharacter(string name)
        {
            Character c = charPositions.FirstOrDefault(t => t.Key.CharName == name).Key;
            return c;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //the point where the player goes
            Point point = new Point(10, 10);

            //send the new location to the server
            DnDMessage msg = new DnDMessage("move_player", new Dictionary<string, string>{{"name", character.CharName},
            {"x",point.X.ToString()},{"y",point.Y.ToString()}});
            client.sendMessage(msg);
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            //TODO: get the point where the player wants to attack
            Point point = new Point(10, 10);

        }
    }
}
