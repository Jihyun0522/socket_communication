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
    public partial class server : Form
    {
        TcpListener tcp = null; // 서버
        TcpClient tcpClient = null; // socket
        static int counter = 0; // 접속한 사용자 수
        string date; // 날짜
        string name;
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>(); // 각 client마다 리스트 추가

        public server()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            //Thread 생성
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
            server_name.Text = "server";
            name = "server";
        }

        private void InitSocket()
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(server_ip.Text.ToString()); //127.0.0.1
            int port = Convert.ToInt32(server_port.Text);
            tcp = new TcpListener(ip, port); // 서버 접속 IP, 포트
            tcpClient = default(TcpClient); // 소켓 설정
            tcp.Start(); // 서버 시작
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++; // Client 수 증가
                    tcpClient = tcp.AcceptTcpClient(); // client 소켓 접속 허용
                    DisplayText(">> Accept connection from client");

                    NetworkStream stream = tcpClient.GetStream();
                    byte[] buffer = new byte[1024]; // 버퍼
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string userName = Encoding.Unicode.GetString(buffer, 0, bytes);
                    userName = userName.Substring(0, userName.IndexOf("$")); // client 사용자 명

                    clientList.Add(tcpClient, userName); // cleint 리스트에 추가

                    SendMessageAll(userName + "님이 입장하셨습니다.", "", false); // 모든 client에게 메세지 전송

                    HandleClient handleClient = new HandleClient(); // client 추가
                    handleClient.OnReceived += new HandleClient.MessageDisplayHandler(OnReceived);
                    handleClient.OnDisconnected += new HandleClient.DisconnectedHandler(handleClient_OnDisconnected);
                    handleClient.StartClient(tcpClient, clientList);
                }
                catch (SocketException se)
                {
                    break;
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            tcpClient.Close(); // client 소켓 닫기
            tcp.Stop(); // 서버 종료
        }

        void handleClient_OnDisconnected(TcpClient tcpClient) // client 접속 해제 핸들러
        {
            if (clientList.ContainsKey(tcpClient))
                clientList.Remove(tcpClient);
        }

        private void OnReceived(string message, string userName) // client에게 받은 데이터
        {
            if(message.Equals("leave Chat"))
            {
                string displayMessage = "leave User : " + userName;
                DisplayText(displayMessage);
                SendMessageAll("leave Chat", userName, true);
            }
            else
            {
                string displayMessage = "From client - " + userName + " : " + message;
                DisplayText(displayMessage); // server 메세지 화면에 출력
                SendMessageAll(message, userName, true); // 모든 client에게 전송

            }
        }

        public void SendMessageAll(string message, string userName, bool flag)
        {
            foreach (var pair in clientList)
            {
                date = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"); // 현재 날짜
                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    if (message.Equals("leave Chat"))
                        buffer = Encoding.UTF8.GetBytes(userName + "님이 대화방을 나갔습니다.");
                    else
                        buffer = Encoding.UTF8.GetBytes("[" + date + "]" + userName + " : " + message);
                }
                else
                {
                    buffer = Encoding.UTF8.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length); // buffer 쓰기
                stream.Flush();
            }
        }

        private void DisplayText(string text) // server 화면에 출력
        {
            if (server_messageBox.InvokeRequired)
            {
                server_messageBox.BeginInvoke(new MethodInvoker(delegate
                {
                    server_messageBox.AppendText(text + Environment.NewLine);
                }));
            }
            else
            {
                server_messageBox.AppendText(text + Environment.NewLine);
            }
        }

        private void Server_send_Click(object sender, EventArgs e)
        {
            DisplayText(server_name.Text + ">> " + server_message.Text);
            SendMessageAll(server_message.Text, server_name.Text, true);
            server_message.Clear();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            /*tcpClient.Close(); // client 소켓 닫기
            tcp.Stop(); // 서버 종료*/
        }

        private void Server_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if(server_name.Text != null)
            {
                SendMessageAll(name + "님의 이름이 " + server_name.Text + "으로 변경되었습니다.", server_name.Text, false);
                DisplayText(name + "님의 이름이 " + server_name.Text + "으로 변경되었습니다.");
                name = server_name.Text;
            }
        }

        private void Server_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //엔터 키를 누를 때
            {
                SendMessageAll(name + "님의 이름이 " + server_name.Text + "으로 변경되었습니다.", server_name.Text, false);
                DisplayText(name + "님의 이름이 " + server_name.Text + "으로 변경되었습니다.");
                name = server_name.Text;
            }
        }

        private void Server_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //엔터 키를 누를 때
            {
                DisplayText(server_name.Text + ">> " + server_message.Text);
                SendMessageAll(server_message.Text, server_name.Text, true);
                server_message.Clear();
            }
        }
    }
}
