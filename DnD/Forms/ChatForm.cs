using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD.Forms
{
    public partial class ChatForm : Form
    {
        DnDClient client;

        public ChatForm(DnDClient client)
        {
            InitializeComponent();
            this.client = client;
            client.AddMessageDelegate(serverMessage);
        }

        public void serverMessage(DnDMessage msg)
        {
            if (msg.Action == "chat_message")
            {
                string user = msg.Properties["user"];
                string message = msg.Properties["message"];
                rtChatLog.AppendText(user + ": " + message + "\n");
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            DnDMessage msg = new DnDMessage("chat_message", new Dictionary<string, string> { { "user", "joe" }, { "message", txtMessage.Text } });
            client.sendMessage(msg);
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.RemoveMessageDelegate(serverMessage);
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
