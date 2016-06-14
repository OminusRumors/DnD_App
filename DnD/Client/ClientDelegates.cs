using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DnD
{
    public class ClientDelegates
    {
        public bool isClientConnected;
        private PlayerForm playerForm;

        public ClientDelegates()
        {
            //testForm = t;
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
                MessageBox.Show("Server says: " + msg.Properties["value"]);
            }
            else if (msg.Action=="move_player")
            {
                Character c = playerForm.GetCharacter(msg.Properties["name"]);
                playerForm.CharPositions[c] = new Point(Convert.ToInt32(msg.Properties["x"]), Convert.ToInt32(msg.Properties["y"]));
            }
            else if(msg.Action=="update_health")
            {
                playerForm.Character.CharHealth = Convert.ToInt32(msg.Properties["health"]);
            }
            //else if (msg.Action=="get_char_info")
            //{
            //    Character c = new Character(msg.Properties["name"], Convert.ToInt32(msg.Properties["health"]));
            //    testForm.lb_name.Text = c.CharName;
            //    testForm.lbl_health.Text = c.CharHealth.ToString();
            //}
        }
    }
}
