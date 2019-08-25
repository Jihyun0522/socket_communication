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
        TcpListener tcp = null; //서버
        TcpClient clientSocket = null; //socket
        static int counter = 0; //접속한 사용자 수
        string date; //날짜
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>(); //각 client마다 리스트 추가

        public server()
        {
            InitializeComponent();
            //Thread 생성
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void InitSocket()
        {
            tcp = new TcpListener(IPAddress.Any, 9999); // 서버 접속 IP, 포트
            clientSocket = default(TcpClient); // 소켓 설정
            tcp.Start(); // 서버 시작
            server_messageBox.Text = ">> Server Started\n";
            
            while (true)
            {
                try
                {
                    counter++; // Client 수 증가
                    clientSocket = tcp.AcceptTcpClient(); // client 소켓 접속 허용
                    server_messageBox.AppendText(">> Accept connection From client\n");

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024]; // 버퍼
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$")); // client 사용자 명

                    clientList.Add(clientSocket, user_name); // cleint 리스트에 추가

                    SendMessageAll(user_name + " 님이 입장하셨습니다.", "", false); // 모든 client에게 메세지 전송

                    handleClient h_client = new handleClient(); // 클라이언트 추가

                    h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                    h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                    h_client.startClient(clientSocket, clientList);
                }
                catch (SocketException se) { break; }
                catch (Exception ex) { break; }
            }
            clientSocket.Close(); // client 소켓 닫기
            tcp.Stop(); // 서버 종료
        }
    }
}
