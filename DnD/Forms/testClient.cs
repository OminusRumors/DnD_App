using DnD_App;
using System;
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
    public partial class testForm : Form
    {
        DnDClient client;
        ClientDelegates clientdel;
        public testForm()
        {
            InitializeComponent();
            client = new DnDClient(this);
            clientdel = new ClientDelegates(this);
        }

        private void testForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Return && !clientdel.isClientConnected)
            {
                string ip = tb_ip.Text;
                client = new DnDClient(this, clientdel);
                client.connectTo(ip);
                Character c = new Character("gfd", 50);
                label1.Text = c.CharName;
                label2.Text = c.CharHealth.ToString();
                DnDMessage msg = new DnDMessage("character_info", c.ToDictionary());
                client.sendMessage(msg);
            }
        }
    }
}
