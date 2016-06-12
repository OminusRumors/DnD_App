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
using TCP;

namespace DnD
{
    public partial class MainForm : Form
    {
        DnDServer server;
        DnDClient client;
        ServerDelegates serverdelegates;
        ClientDelegates clientdelegates;

        public MainForm()
        {
            InitializeComponent();
            serverdelegates = new ServerDelegates();
            //clientdelegates = new ClientDelegates();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            server = new DnDServer(this, serverdelegates.clientConnected, serverdelegates.clientDisconnected, serverdelegates.clientMessage);
            server.setLogDelegate(serverdelegates.handleServerLog);
            server.start();
            CharacterForm f = new CharacterForm(server, client);
            f.Show();
        }



        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!clientdelegates.isClientConnected)
            {
                // Connect
                string address = tbIP.Text;
                client = new DnDClient(this, clientdelegates.connectedToServer, clientdelegates.disconnectedFromServer, clientdelegates.serverMessage);
                client.connectTo(address);
            }
            else
            {
                //Disconnect
                client.disconnect();
            }
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            //CharacterForm f = new CharacterForm();
            //f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
