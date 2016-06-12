using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using DnD;

namespace TCP
{
    public class DnDServer
    {

        private static Socket _serverSocket;
        private static readonly List<Socket> _clientSockets = new List<Socket>();
        private const int _BUFFER_SIZE = 2048;
        private const int _PORT = 100;
        private static readonly byte[] _buffer = new byte[_BUFFER_SIZE];

        public delegate void ClientConnectDelegate(Socket client);
        public delegate void ClientDisconnectDelegate(Socket client);
        public delegate void ClientMessageDelegate(Socket client, DnDMessage message);

        public delegate void ServerLogDelegate(string message, ListBox listBox);

        Control control;
        ClientMessageDelegate messageDelegate;
        ClientConnectDelegate connectDelegate;
        ClientDisconnectDelegate disconnectDelegate;
        ServerLogDelegate logDelegate;

        public DnDServer(Control control)
        {
            this.control = control;
        }

        public DnDServer(Control control, ClientConnectDelegate connectDelegate, ClientDisconnectDelegate disconnectDelegate,
            ClientMessageDelegate listener)
        {
            this.messageDelegate = listener;
            this.disconnectDelegate = disconnectDelegate;
            this.connectDelegate = connectDelegate;
            this.control = control;
        }

        public void setClientConnectDelegate(ClientConnectDelegate connectDelegate)
        {
            this.connectDelegate = connectDelegate;
        }

        public void setClientDisconnectDelegate(ClientDisconnectDelegate disconnectDelegate)
        {
            this.disconnectDelegate = disconnectDelegate;
        }

        public void setClientMessageDelegate(ClientMessageDelegate messageDelegate)
        {
            this.messageDelegate = messageDelegate;
        }

        public void setLogDelegate(ServerLogDelegate logDelegate)
        {
            this.logDelegate = logDelegate;
        }

        public void start()
        {
            Log("Setting up server on " + GetLocalIPAddress() + ":" + _PORT);
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, _PORT));
            _serverSocket.Listen(5);
            _serverSocket.BeginAccept(AcceptCallback, null);
            Log("Server setup complete");
        }

        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients)
        /// </summary>
        public void stop()
        {
            foreach (Socket socket in _clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            _serverSocket.Close();
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = _serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            _clientSockets.Add(socket);
            socket.BeginReceive(_buffer, 0, _BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Log("Client connected, waiting for request...");

            //Return connect message to control
            invokeDelegate(connectDelegate, socket);

            _serverSocket.BeginAccept(AcceptCallback, null);
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
                disconnectSocket(current);
                return;
            }
            catch (ObjectDisposedException) {
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(_buffer, recBuf, received);
            if (received > 0)
            {
                DnDMessage message = DnDMessage.createFromByteArray(recBuf);
                invokeDelegate(messageDelegate, current, message);
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
                disconnectSocket(current);
                return;
            }

        }

        private void disconnectSocket(Socket current)
        {
            Log("Client forcefully disconnected");
            invokeDelegate(disconnectDelegate,current);
            current.Close(); // Dont shutdown because the socket may be disposed and its disconnected anyway
            _clientSockets.Remove(current);
        }

        public void SendToAll(byte[] data)
        {
            foreach(Socket client in _clientSockets)
            {
                client.Send(data);
            }
        }

        // ======================================= //
        // ============   HELPERS   ============== //
        // ======================================= //

        private void Log(string message)
        {
            Debug.WriteLine(message);
            invokeDelegate(logDelegate, message);
        }

        public static byte[] EncodeString(string message)
        {
            return Encoding.ASCII.GetBytes(message);
        }

        public static string GetIPAddressFromSocket(Socket s)
        {
            return ((IPEndPoint)(s.RemoteEndPoint)).Address.ToString();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
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
                catch (Exception)
                {
                    control.Invoke((MethodInvoker)delegate { del.DynamicInvoke(args); }, args);
                }
            }
        }

    }
}