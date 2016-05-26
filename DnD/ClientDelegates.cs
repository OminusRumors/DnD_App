using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using TCP;namespace DnD
{
    class ClientDelegates
    {
        public bool isClientConnected;

        public ClientDelegates()
        {
            this.isClientConnected = false;
        }
        public void connectedToServer()
        {
            isClientConnected = true;
        }

        public void disconnectedFromServer()
        {
            isClientConnected = false;
        }

        public void serverMessage(DnDMessage msg)
        {
            if (msg.Action == "text")
            {
                //MessageBox.Show("Server says: " + msg.Properties["value"]);
            }
        }
    }
}
