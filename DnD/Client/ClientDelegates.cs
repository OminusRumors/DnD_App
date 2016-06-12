using DnD_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP;

namespace DnD
{
    public class ClientDelegates
    {
        public bool isClientConnected;
        private testForm testForm;

        public ClientDelegates(testForm t)
        {
            testForm = t;
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
            else if (msg.Action=="get_char_info")
            {
                Character c = new Character(msg.Properties["name"], Convert.ToInt32(msg.Properties["health"]));
                testForm.lb_name.Text = c.CharName;
                testForm.lbl_health.Text = c.CharHealth.ToString();
            }
        }
    }
}
