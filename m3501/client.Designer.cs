namespace m3501
{
    partial class client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.client_send = new System.Windows.Forms.Button();
            this.client_message = new System.Windows.Forms.TextBox();
            this.client_messageBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.client_myIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.client_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.join = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.client_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // client_send
            // 
            this.client_send.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_send.Location = new System.Drawing.Point(361, 744);
            this.client_send.Name = "client_send";
            this.client_send.Size = new System.Drawing.Size(74, 43);
            this.client_send.TabIndex = 12;
            this.client_send.Text = "전송";
            this.client_send.UseVisualStyleBackColor = true;
            this.client_send.Click += new System.EventHandler(this.Client_send_Click);
            // 
            // client_message
            // 
            this.client_message.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_message.Location = new System.Drawing.Point(12, 752);
            this.client_message.Name = "client_message";
            this.client_message.Size = new System.Drawing.Size(335, 25);
            this.client_message.TabIndex = 13;
            this.client_message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Client_message_KeyPress);
            // 
            // client_messageBox
            // 
            this.client_messageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client_messageBox.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_messageBox.Location = new System.Drawing.Point(12, 381);
            this.client_messageBox.Multiline = true;
            this.client_messageBox.Name = "client_messageBox";
            this.client_messageBox.ReadOnly = true;
            this.client_messageBox.Size = new System.Drawing.Size(423, 346);
            this.client_messageBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.client_myIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.change);
            this.groupBox2.Controls.Add(this.client_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보 수정";
            // 
            // client_myIp
            // 
            this.client_myIp.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_myIp.Location = new System.Drawing.Point(93, 37);
            this.client_myIp.Name = "client_myIp";
            this.client_myIp.ReadOnly = true;
            this.client_myIp.Size = new System.Drawing.Size(288, 26);
            this.client_myIp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "내 IP";
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.change.Location = new System.Drawing.Point(332, 82);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(74, 43);
            this.change.TabIndex = 5;
            this.change.Text = "변경";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.Change_Click);
            // 
            // client_name
            // 
            this.client_name.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_name.Location = new System.Drawing.Point(93, 89);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(228, 26);
            this.client_name.TabIndex = 1;
            this.client_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Client_name_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름";
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stop.Location = new System.Drawing.Point(248, 155);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(123, 43);
            this.stop.TabIndex = 9;
            this.stop.Text = "중단";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // join
            // 
            this.join.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join.Location = new System.Drawing.Point(85, 155);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(123, 43);
            this.join.TabIndex = 8;
            this.join.Text = "참여";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.Join_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.client_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.client_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 131);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅방 정보";
            // 
            // client_port
            // 
            this.client_port.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_port.Location = new System.Drawing.Point(104, 80);
            this.client_port.Name = "client_port";
            this.client_port.Size = new System.Drawing.Size(288, 26);
            this.client_port.TabIndex = 3;
            this.client_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Client_port_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // client_ip
            // 
            this.client_ip.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.client_ip.Location = new System.Drawing.Point(104, 37);
            this.client_ip.Name = "client_ip";
            this.client_ip.Size = new System.Drawing.Size(288, 26);
            this.client_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 795);
            this.Controls.Add(this.client_send);
            this.Controls.Add(this.client_message);
            this.Controls.Add(this.client_messageBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.join);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client - 채팅방 참여";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button client_send;
        private System.Windows.Forms.TextBox client_message;
        private System.Windows.Forms.TextBox client_messageBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button join;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox client_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox client_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox client_myIp;
        private System.Windows.Forms.Label label3;
    }
}