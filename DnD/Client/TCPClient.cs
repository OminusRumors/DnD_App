using DnD;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DnD
{
    public class TCPClient
    {
        private Socket _clientSocket;

        private const int _BUFFER_SIZE = 2048;
        private const int _PORT = 100;
        private static readonly byte[] _buffer = new byte[_BUFFER_SIZE];

        public delegate void ConnectDelegate();
        public delegate void DisconnectDelegate();
        public delegate void ServerMessageDelegate(DnDMessage message);

        Control control;

        public ConnectDelegate connectDelegate { get; set; } 
        public DisconnectDelegate disconnectDelegate { get; set; }

        private List<ServerMessageDelegate> messageDelegates = new List<ServerMessageDelegate>();

        public TCPClient(Control control)
        {
            this.control = control;
        }

        public TCPClient(Control control,ConnectDelegate connectDelegate, DisconnectDelegate disconnectDelegate, ServerMessageDelegate messageDelegate)
        {
            this.control = control;
            this.connectDelegate = connectDelegate;
            this.disconnectDelegate = disconnectDelegate;
            AddMessageDelegate(messageDelegate);
        }

        public void AddMessageDelegate(ServerMessageDelegate del)
        {
            messageDelegates.Add(del);
        }

        public void RemoveMessageDelegate(ServerMessageDelegate del)
        {
            messageDelegates.Remove(del);
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
                invokeMessageDelegates(messageDelegates, message);
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

        private void invokeMessageDelegates(List<ServerMessageDelegate> listDel, params object[] args)
        {
            foreach (ServerMessageDelegate del in listDel)
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
}