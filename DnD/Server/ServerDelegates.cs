using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCP;

namespace DnD
{
    class ServerDelegates
    {
        public ServerDelegates()
        {

        }
        public void clientConnected(Socket client)
        {
            string ip = DnDServer.GetIPAddressFromSocket(client);
        }

        public void clientDisconnected(Socket client)
        {
            string ip = DnDServer.GetIPAddressFromSocket(client);
        }

        public void clientMessage(Socket client, DnDMessage msg)
        {
            string action = msg.Action;
            if (action == "text")
            {
                string ip = DnDServer.GetIPAddressFromSocket(client);
                string text = msg.Properties["value"];

                DnDMessage response = DnDMessage.createWithText(text + " :)");
                client.Send(response.ToByteArray());
            }
            else if (action == "time")
            {
                DnDMessage response = DnDMessage.createWithText(DateTime.Now.ToShortTimeString());
                //server.SendToAll(response.ToByteArray());
            }
            else if (action == "error")
            {
                DnDMessage response = DnDMessage.createWithText(msg.Action + ": Invalid request\n");
                client.Send(response.ToByteArray());
            }
        }

        public void handleServerLog(string msg)
        {
        }
    }
}
