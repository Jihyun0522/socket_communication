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

        public client()
        {
            InitializeComponent();
        }

        private void Client_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Join_Click(object sender, EventArgs e)
        {
            /*try
            {
                tcpClient.Connect();
            }
            catch(Exception e)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                Application.Exit();
            }*/
        }
    }
}
