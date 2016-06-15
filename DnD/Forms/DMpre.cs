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
    public partial class DMpre : Form
    {
        Character player1;
        Character player2;
        Character npc1;
        Character npc2;
        Trap trap1;
        Trap trap2;
        DnDServer server;
        ServerDelegates serverDelegates;

        public DMpre()
        {
            InitializeComponent();
            serverDelegates = new ServerDelegates();
            server = new DnDServer(this, serverDelegates);
            server.setLogDelegate(serverDelegates.handleServerLog);
            lbHostIp.Text = server.GetLocalIPAddress();
            server.start();

            int[] stats = new int[] { 4, 4, 4, 4, 4, 4 };
            //player1 = new Character("player1", stats, 10, new Weapon(10, 2, 3, 2), 200);
            //player2 = new Character("player2", stats, 11, new Weapon(10, 2, 3, 2), 300);
            //npc1 = new Character("npc1", stats, 4, new Weapon(5, 2, 3, 2), 100);
            //npc2 = new Character("npc2", stats, 5, new Weapon(6, 1, 2, 1), 100);
            trap1 = new Trap(0, 4, 2);
            trap2 = new Trap(1, 4, 2);
        }

        private void btnPlaceNPCs_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Dictionary<Character, Point> charDict = new Dictionary<Character, Point>();
            charDict.Add(player1, new Point(50, 50));
            charDict.Add(player2, new Point(100, 50));

            Dictionary<Character, Point> npcDict = new Dictionary<Character, Point>();
            npcDict.Add(npc1, new Point(100, 100));
            npcDict.Add(npc2, new Point(50, 100));

            //Game game = new Game(charDict, npcDict, new Dictionary<Trap, Point> { { trap1, new Point(25, 25) } });
            //DMaft form = new DMaft(server, game);
        }
    }
}
