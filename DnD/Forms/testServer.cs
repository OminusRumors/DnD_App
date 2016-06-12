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
using TCP;

namespace DnD.Forms
{
    public partial class testServer : Form
    {
        DnDServer server;
        ServerDelegates serverdelegates = new ServerDelegates();
        testForm tf = new testForm();
        
        public testServer()
        {
            InitializeComponent();
            tf.Show();
        }

        private void testServer_Load(object sender, EventArgs e)
        {
            server = new DnDServer(this, serverdelegates.clientConnected, serverdelegates.clientDisconnected, serverdelegates.clientMessage);
            server.setLogDelegate(serverdelegates.handleServerLog);
            server.start();
            Character c=new Character("george", 29);
            
        }
    }
}
