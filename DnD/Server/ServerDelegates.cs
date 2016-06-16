using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD
{
    public class ServerDelegates
    {
        DnDServer server;
        Game game;
        Dictionary<Character, Socket> playerListIP;

        public ServerDelegates()
        {
            game = new Game();
            server = new DnDServer(this);
            playerListIP = new Dictionary<Character, Socket>();
        }

        public void StartServer()
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
            }else if (action == "chat_message")
            {
                server.SendToAll(msg.ToByteArray());
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
            else if (action == "initilize_player")
            {
                int[] stats = new int[6];
                for (int i = 0; i < stats.Length; i++)
                {
                    stats[i] = Convert.ToInt32(msg.Properties[i.ToString()]);
                }

                DnDMessage response = DnDMessage.createWithText("hello )");
                client.Send(response.ToByteArray());
                //Character character = new Character(msg.Properties["name"], stats, Convert.ToInt32(msg.Properties["armor"]),
                // Convert.ToInt32(msg.Properties["maxHealth"]), Convert.ToInt32(msg.Properties["health"]));
                //game.AddCharacter(character);
            }
            else if (action=="weapon")
            {
                Weapon weapon = new Weapon(msg.Properties["player"], Convert.ToInt32(msg.Properties["attack"]),
                    Convert.ToInt32(msg.Properties["range"]), Convert.ToInt32(msg.Properties["critical"]),
                    Convert.ToInt32(msg.Properties["effective"]));
                game.AddWeapon(weapon);
            }
            else if (action == "attack_char")
            {
                Point point = new Point(Convert.ToInt32(msg.Properties["x"]), Convert.ToInt32(msg.Properties["y"]));
                Character c = game.GetCharacter(point);
                /*bool result = game.Attack(game.CurrentCharacter, c, 10);
                if (result)
                {
                    DnDMessage resp = new DnDMessage("update_health", new Dictionary<string, string> { { "health", c.CharHealth.ToString() } });
                    Socket defender = playerListIP[c];
                    defender.Send(resp.ToByteArray());
                }*/
            }
            else if (action == "move_player")
            {
                Character chara = game.GetCharacter(msg.Properties["name"]);
                Point p = new Point(Convert.ToInt32(msg.Properties["x"]), Convert.ToInt32(msg.Properties["y"]));
                game.UpdateCharPosition(chara, p);
                foreach (Character character in playerListIP.Keys)
                {
                    client = playerListIP[character];
                    DnDMessage resp = new DnDMessage("move_player", new Dictionary<string, string>{
                        {"name", chara.CharName},
                        {"x",p.X.ToString()},
                        {"y",p.Y.ToString()}});
                    client.Send(resp.ToByteArray());
                }
            }
            else if (action == "character_info")
            {
                Character chara = new Character(msg.Properties["name"], Convert.ToInt32(msg.Properties["health"]));
                game.CharList.Add(chara, new Point());
                DnDMessage resp = new DnDMessage("get_char_info", chara.ToDictionary());
                client.Send(resp.ToByteArray());
            }
        }

        public void handleServerLog(string msg, ListBox lb)
        {
            lb.Items.Add(msg);
        }
    }
}
