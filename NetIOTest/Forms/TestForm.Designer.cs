namespace NetIOTest.Forms
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbox_unlockKeepTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_intervalUnlock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_intervalComm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_clock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_vibr = new System.Windows.Forms.TextBox();
            this.tbox_humi = new System.Windows.Forms.TextBox();
            this.tbox_temp = new System.Windows.Forms.TextBox();
            this.txt_debugInfo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.tbn_read = new System.Windows.Forms.Button();
            this.tbn_openTimer = new System.Windows.Forms.Button();
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tim_envSpy = new System.Windows.Forms.Timer(this.components);
            this.tim_openLocker = new System.Windows.Forms.Timer(this.components);
            this.btn_lock = new System.Windows.Forms.Button();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电池";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "锁控制";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(425, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 555);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "网络测试";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbox_clock);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tbox_vibr);
            this.groupBox5.Controls.Add(this.tbox_humi);
            this.groupBox5.Controls.Add(this.tbox_temp);
            this.groupBox5.Controls.Add(this.txt_debugInfo);
            this.groupBox5.Location = new System.Drawing.Point(16, 144);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(677, 394);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "实时通信";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.tbox_unlockKeepTime);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.tbox_intervalUnlock);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.tbox_intervalComm);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(28, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(614, 111);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "测试任务";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "开锁保持(s)";
            // 
            // tbox_unlockKeepTime
            // 
            this.tbox_unlockKeepTime.Location = new System.Drawing.Point(481, 20);
            this.tbox_unlockKeepTime.Name = "tbox_unlockKeepTime";
            this.tbox_unlockKeepTime.Size = new System.Drawing.Size(82, 21);
            this.tbox_unlockKeepTime.TabIndex = 14;
            this.tbox_unlockKeepTime.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "开锁间隔(min)";
            // 
            // tbox_intervalUnlock
            // 
            this.tbox_intervalUnlock.Location = new System.Drawing.Point(300, 20);
            this.tbox_intervalUnlock.Name = "tbox_intervalUnlock";
            this.tbox_intervalUnlock.Size = new System.Drawing.Size(82, 21);
            this.tbox_intervalUnlock.TabIndex = 12;
            this.tbox_intervalUnlock.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "通讯间隔(s)";
            // 
            // tbox_intervalComm
            // 
            this.tbox_intervalComm.Location = new System.Drawing.Point(99, 20);
            this.tbox_intervalComm.Name = "tbox_intervalComm";
            this.tbox_intervalComm.Size = new System.Drawing.Size(82, 21);
            this.tbox_intervalComm.TabIndex = 10;
            this.tbox_intervalComm.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(437, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "测试项：实时（1s/次） 环境（温湿度、震动、锁）监控  + 10s/30min 保持开锁";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "锁";
            // 
            // tbox_clock
            // 
            this.tbox_clock.Location = new System.Drawing.Point(560, 20);
            this.tbox_clock.Name = "tbox_clock";
            this.tbox_clock.Size = new System.Drawing.Size(82, 21);
            this.tbox_clock.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "振动";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "湿度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "温度";
            // 
            // tbox_vibr
            // 
            this.tbox_vibr.Location = new System.Drawing.Point(406, 20);
            this.tbox_vibr.Name = "tbox_vibr";
            this.tbox_vibr.Size = new System.Drawing.Size(82, 21);
            this.tbox_vibr.TabIndex = 3;
            // 
            // tbox_humi
            // 
            this.tbox_humi.Location = new System.Drawing.Point(241, 20);
            this.tbox_humi.Name = "tbox_humi";
            this.tbox_humi.Size = new System.Drawing.Size(82, 21);
            this.tbox_humi.TabIndex = 2;
            // 
            // tbox_temp
            // 
            this.tbox_temp.Location = new System.Drawing.Point(76, 20);
            this.tbox_temp.Name = "tbox_temp";
            this.tbox_temp.Size = new System.Drawing.Size(82, 21);
            this.tbox_temp.TabIndex = 1;
            // 
            // txt_debugInfo
            // 
            this.txt_debugInfo.Location = new System.Drawing.Point(21, 191);
            this.txt_debugInfo.Multiline = true;
            this.txt_debugInfo.Name = "txt_debugInfo";
            this.txt_debugInfo.Size = new System.Drawing.Size(628, 185);
            this.txt_debugInfo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_unlock);
            this.groupBox4.Controls.Add(this.btn_lock);
            this.groupBox4.Controls.Add(this.btn_read);
            this.groupBox4.Controls.Add(this.tbn_read);
            this.groupBox4.Controls.Add(this.tbn_openTimer);
            this.groupBox4.Controls.Add(this.tbox_ip);
            this.groupBox4.Controls.Add(this.btn_conn);
            this.groupBox4.Controls.Add(this.tbox_port);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtaddr);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(677, 118);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "连接设置";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(620, 16);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(51, 23);
            this.btn_read.TabIndex = 103;
            this.btn_read.Text = "读数据";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // tbn_read
            // 
            this.tbn_read.Location = new System.Drawing.Point(523, 22);
            this.tbn_read.Name = "tbn_read";
            this.tbn_read.Size = new System.Drawing.Size(75, 23);
            this.tbn_read.TabIndex = 102;
            this.tbn_read.Text = "读取数据";
            this.tbn_read.UseVisualStyleBackColor = true;
            this.tbn_read.Click += new System.EventHandler(this.tbn_read_Click);
            // 
            // tbn_openTimer
            // 
            this.tbn_openTimer.Location = new System.Drawing.Point(421, 65);
            this.tbn_openTimer.Name = "tbn_openTimer";
            this.tbn_openTimer.Size = new System.Drawing.Size(94, 23);
            this.tbn_openTimer.TabIndex = 100;
            this.tbn_openTimer.Text = "执行测试任务";
            this.tbn_openTimer.UseVisualStyleBackColor = true;
            this.tbn_openTimer.Click += new System.EventHandler(this.tbn_openTimer_Click);
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(111, 24);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.Size = new System.Drawing.Size(121, 21);
            this.tbox_ip.TabIndex = 98;
            this.tbox_ip.Text = "192.168.1.232";
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(421, 24);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(94, 23);
            this.btn_conn.TabIndex = 92;
            this.btn_conn.Text = "打开连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // tbox_port
            // 
            this.tbox_port.Location = new System.Drawing.Point(344, 24);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(66, 21);
            this.tbox_port.TabIndex = 91;
            this.tbox_port.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 93;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 94;
            this.label2.Text = "端口号：";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(111, 65);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(121, 21);
            this.txtaddr.TabIndex = 97;
            this.txtaddr.Text = "254";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(523, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 95;
            this.btnClear.Text = "清空接收";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 96;
            this.label5.Text = "设备地址";
            // 
            // tim_envSpy
            // 
            this.tim_envSpy.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tim_openLocker
            // 
            this.tim_openLocker.Tick += new System.EventHandler(this.tim_openLocker_Tick);
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(620, 45);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(51, 23);
            this.btn_lock.TabIndex = 104;
            this.btn_lock.Text = "上锁";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // btn_unlock
            // 
            this.btn_unlock.Location = new System.Drawing.Point(620, 74);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(51, 23);
            this.btn_unlock.TabIndex = 105;
            this.btn_unlock.Text = "开锁";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.Text = "测试程序";
            this.Load += new System.EventHandler(this.CarsInfoForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_debugInfo;
        private System.Windows.Forms.Button tbn_openTimer;
        public System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.Button btn_conn;
        public System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_clock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_vibr;
        private System.Windows.Forms.TextBox tbox_humi;
        private System.Windows.Forms.TextBox tbox_temp;
        private System.Windows.Forms.Timer tim_envSpy;
        private System.Windows.Forms.Button tbn_read;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tim_openLocker;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbox_unlockKeepTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_intervalUnlock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_intervalComm;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Button btn_lock;
    }
}