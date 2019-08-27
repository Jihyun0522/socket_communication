using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace m3501
{
    public partial class client : Form
    {
        TcpClient tcpClient = new TcpClient(); // socket
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
        string name;

        public client()
        {
            InitializeComponent();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            string stringIp = "";
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(client_ip.Text.ToString()); //127.0.0.1
                stringIp = ip.ToString();
                int port = Convert.ToInt32(client_port.Text);
                tcpClient.Connect(ip, port); //접속 IP 및 port
                stream = tcpClient.GetStream();
            }
            catch(Exception exception)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                Application.Exit();
            }

            Random random = new Random();
            int clientRandom = random.Next(1, 1000);
            name = "client_" + clientRandom;

            message = "채팅 서버에 연결되었습니다.";
            client_name.Text = name;
            DisplayText(message);
            client_myIp.Text = stringIp;

            byte[] buffer = Encoding.Unicode.GetBytes(this.client_name.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread threadHandler = new Thread(GetMessage);
            threadHandler.IsBackground = true;
            threadHandler.Start();
        }

        private void Client_send_Click(object sender, EventArgs e) // message 보내기
        {
            client_message.Focus();
            byte[] buffer = Encoding.UTF8.GetBytes(name + " >> " + client_message.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            client_message.Clear();
        }

        private void Client_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //엔터 키를 누를 때
            {
                client_message.Focus();
                byte[] buffer = Encoding.UTF8.GetBytes(name + " >> " + client_message.Text + "$");
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                client_message.Clear();
            }
        }

        private void GetMessage() //메세지 받기
        {
            while (true)
            {
                stream = tcpClient.GetStream();
                int bufferSize = tcpClient.ReceiveBufferSize;
                byte[] buffer = new byte[bufferSize];
                int bytes = stream.Read(buffer, 0, buffer.Length);

                string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                DisplayText(message);
            }
        }

        private void DisplayText(string text) // client에 message 출력
        {
            if (client_messageBox.InvokeRequired)
            {
                client_messageBox.BeginInvoke(new MethodInvoker(delegate
                {
                    client_messageBox.AppendText(text + Environment.NewLine);
                }));
            }
            else
            {
                client_messageBox.AppendText(text + Environment.NewLine);
            }
        }

        private void Client_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("leave Chat" + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            Environment.Exit(0);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("leave Chat" + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (client_name.Text != null)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(name + "님의 이름이 " + client_name.Text + "으로 변경되었습니다." + "$");
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush(); 
                name = client_name.Text;
            }
        }

        private void Client_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //엔터 키를 누를 때
            {
                byte[] buffer = Encoding.UTF8.GetBytes(name + "님의 이름이 " + client_name.Text + "으로 변경되었습니다." + "$");
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                name = client_name.Text;
            }
        }
    }
}
