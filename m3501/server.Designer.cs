namespace m3501
{
    partial class server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.server_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.change = new System.Windows.Forms.Button();
            this.server_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.server_messageBox = new System.Windows.Forms.TextBox();
            this.server_message = new System.Windows.Forms.TextBox();
            this.server_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.server_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.server_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅방 정보";
            // 
            // server_port
            // 
            this.server_port.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_port.Location = new System.Drawing.Point(104, 80);
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(288, 30);
            this.server_port.TabIndex = 3;
            this.server_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Server_port_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // server_ip
            // 
            this.server_ip.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_ip.Location = new System.Drawing.Point(104, 37);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(288, 30);
            this.server_ip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.create.Location = new System.Drawing.Point(85, 157);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(123, 43);
            this.create.TabIndex = 1;
            this.create.Text = "생성";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stop.Location = new System.Drawing.Point(248, 157);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(123, 43);
            this.stop.TabIndex = 2;
            this.stop.Text = "중단";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.change);
            this.groupBox2.Controls.Add(this.server_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보 수정";
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.change.Location = new System.Drawing.Point(332, 34);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(74, 43);
            this.change.TabIndex = 5;
            this.change.Text = "변경";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.Change_Click);
            // 
            // server_name
            // 
            this.server_name.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_name.Location = new System.Drawing.Point(93, 41);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(228, 30);
            this.server_name.TabIndex = 1;
            this.server_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Server_name_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(38, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "이름";
            // 
            // server_messageBox
            // 
            this.server_messageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.server_messageBox.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_messageBox.Location = new System.Drawing.Point(12, 340);
            this.server_messageBox.Multiline = true;
            this.server_messageBox.Name = "server_messageBox";
            this.server_messageBox.ReadOnly = true;
            this.server_messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.server_messageBox.Size = new System.Drawing.Size(423, 346);
            this.server_messageBox.TabIndex = 5;
            // 
            // server_message
            // 
            this.server_message.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_message.Location = new System.Drawing.Point(12, 710);
            this.server_message.Name = "server_message";
            this.server_message.Size = new System.Drawing.Size(335, 29);
            this.server_message.TabIndex = 6;
            this.server_message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Server_message_KeyPress);
            // 
            // server_send
            // 
            this.server_send.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_send.Location = new System.Drawing.Point(361, 702);
            this.server_send.Name = "server_send";
            this.server_send.Size = new System.Drawing.Size(74, 43);
            this.server_send.TabIndex = 6;
            this.server_send.Text = "전송";
            this.server_send.UseVisualStyleBackColor = true;
            this.server_send.Click += new System.EventHandler(this.Server_send_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 754);
            this.Controls.Add(this.server_send);
            this.Controls.Add(this.server_message);
            this.Controls.Add(this.server_messageBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.create);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "server";
            this.Text = "server - 채팅방장";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server_messageBox;
        private System.Windows.Forms.TextBox server_message;
        private System.Windows.Forms.Button server_send;
    }
}