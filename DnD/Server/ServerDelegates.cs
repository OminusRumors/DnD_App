using DnD_App;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD;

namespace DnD
{
    class ServerDelegates
    {
        Game game = new Game();
        public ServerDelegates()
        {

        }

        public void StartServer(DnDServer server)
        {
            server.start();
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
            else if (action == "character_info")
            {
                Character c = new Character(msg.Properties["name"], Convert.ToInt32(msg.Properties["health"]));
                game.CharList.Add(c, new Point());
                DnDMessage resp = new DnDMessage("get_char_info", c.ToDictionary());
                client.Send(resp.ToByteArray());
            }
        }

        public void handleServerLog(string msg, ListBox lb)
        {
            lb.Items.Add(msg);
        }
    }
}
