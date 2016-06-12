using DnD;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCP
{
    public class DnDClient
    {
        private Socket _clientSocket;

        private const int _BUFFER_SIZE = 2048;
        private const int _PORT = 100;
        private static readonly byte[] _buffer = new byte[_BUFFER_SIZE];

        public delegate void ConnectDelegate();
        public delegate void DisconnectDelegate();
        public delegate void ServerMessageDelegate(DnDMessage message);

        Control control;

        ConnectDelegate connectDelegate;
        DisconnectDelegate disconnectDelegate;
        ServerMessageDelegate messageDelegate;

        public DnDClient(Control control)
        {
            this.control = control;
        }

        public DnDClient(Control control, ClientDelegates clientDel)
        {
            this.control = control;
            this.connectDelegate = clientDel.connectedToServer;
            this.disconnectDelegate = clientDel.disconnectedFromServer;
            this.messageDelegate = clientDel.serverMessage;
        }

        public DnDClient(Control control,ConnectDelegate connectDelegate, DisconnectDelegate disconnectDelegate, ServerMessageDelegate messageDelegate)
        {
            this.control = control;
            this.connectDelegate = connectDelegate;
            this.disconnectDelegate = disconnectDelegate;
            this.messageDelegate = messageDelegate;
        }

        internal void connectTo(string address)
        {

            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int attempts = 0;

            //while (!_clientSocket.Connected)
            //{
                try
                {
                    attempts++;
                    Debug.WriteLine("Client Connection attempt " + attempts);
                    _clientSocket.Connect(address, _PORT);
                }
                catch (SocketException)
                {
                    return;
                }
            //}
            Debug.WriteLine("Client Connected");
            invokeDelegate(connectDelegate);

            _clientSocket.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, _clientSocket);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                disconnect();
                return;
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(_buffer, recBuf, received);
            if (received > 0)
            {
                DnDMessage message = DnDMessage.createFromByteArray(recBuf);
                invokeDelegate(messageDelegate, message);
            }
            else
            {
                byte[] data = Encoding.ASCII.GetBytes(" ");
                try
                {
                    current.Send(data);
                }
                catch (SocketException) { }
            }

            try
            {
                current.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
            }
            catch (SocketException)
            {
                disconnect();
                return;
            }

        }

        internal void disconnect()
        {
            //SendString("exit"); // Tell the server we re exiting
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            invokeDelegate(disconnectDelegate);
        }

        public void sendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public void sendMessage(DnDMessage msg)
        {
            byte[] buffer = msg.ToByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void invokeDelegate(Delegate del, params object[] args)
        {
            if (del != null)
            {
                try
                {
                    control.Invoke((MethodInvoker)delegate {
                        del.DynamicInvoke(args);
                    });
                }
                catch (ObjectDisposedException) { }
            }
        }

    }
}