using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace m3501
{
    class HandleClient
    {
        TcpClient tcpClient = null;
        public Dictionary<TcpClient, string> clientList = null;

        public void StartClient(TcpClient tcpClient, Dictionary<TcpClient, string> clientList)
        {
            this.tcpClient = tcpClient;
            this.clientList = clientList;

            Thread Hthread = new Thread(doChat);
            Hthread.IsBackground = true;
            Hthread.Start();
        }

        public delegate void MessageDisplayHandler(string message, string userName);
        public event MessageDisplayHandler OnReceived;

        public delegate void DisconnectedHandler(TcpClient clientSocket);
        public event DisconnectedHandler OnDisconnected;

        private void doChat()
        {
            NetworkStream stream = null;

            try
            {
                byte[] buffer = new byte[1024];
                string message = string.Empty;
                int bytes = 0;
                int MessageCount = 0;

                while (true)
                {
                    MessageCount++;
                    stream = tcpClient.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    message = Encoding.UTF8.GetString(buffer, 0, bytes);
                    message = message.Substring(0, message.IndexOf("$"));

                    if(OnReceived != null)
                    {
                        OnReceived(message, clientList[tcpClient].ToString());
                    }
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("doChat - SocketException : {0}", se.Message));

                if(tcpClient != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(tcpClient);

                    tcpClient.Close();
                    stream.Close();
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(string.Format("doChat - Exception : {0}", e.Message));

                if (tcpClient != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(tcpClient);

                    tcpClient.Close();
                    stream.Close();
                }
            }
        }
    }
}
