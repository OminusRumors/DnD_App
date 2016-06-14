using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD;

namespace DnD
{
    public partial class MainForm : Form
    {
        DnDClient client;
        ClientDelegates clientdelegates;

        public MainForm()
        {
            InitializeComponent();
            clientdelegates = new ClientDelegates();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            DMpre f = new DMpre();
            f.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string address = tbIP.Text;
            client = new DnDClient(this, clientdelegates);
            client.connectTo(address);
            Character c = new Character("george", new int[] { 6, 6, 6, 6, 6, 6 }, 10, new Weapon(15), 200);
            PlayerForm pf = new PlayerForm(c, client);
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            var f = new CharacterForm();
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
