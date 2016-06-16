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
    public partial class DMaft : Form
    {
        TCPClient client;
        public DMaft(Game game, TCPClient client)
        {
            InitializeComponent();
            pbGameGrid.Width = 900;
            pbGameGrid.Height = 495;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.client = client;
            //int[] stats = new int[] { 4, 4, 4, 4, 4, 4 };
            //npc1 = new Character("npc1", stats, 4, new Weapon(5, 2, 3, 2), 100);
            //npc2 = new Character("npc2", stats, 5, new Weapon(6, 1, 2, 1), 100);
            //trap1 = new Trap(0, 4, 2);
            //trap2 = new Trap(1, 4, 2);
        }

        private void DMaft_Load(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            DnDMessage msg = new DnDMessage("end_turn");
            client.sendMessage(msg);
        }
    }
}
