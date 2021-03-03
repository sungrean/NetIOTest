namespace NetIOTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ip = new System.Windows.Forms.TextBox();
            this.btnReadAI = new System.Windows.Forms.Button();
            this.txtAINum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReadDO = new System.Windows.Forms.Button();
            this.btnReadDI = new System.Windows.Forms.Button();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDINum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDONum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnDO8 = new System.Windows.Forms.Button();
            this.imglistDO = new System.Windows.Forms.ImageList(this.components);
            this.btnDO7 = new System.Windows.Forms.Button();
            this.btnDO6 = new System.Windows.Forms.Button();
            this.btnOpenAll = new System.Windows.Forms.Button();
            this.btnDO5 = new System.Windows.Forms.Button();
            this.btnDO4 = new System.Windows.Forms.Button();
            this.btnDO3 = new System.Windows.Forms.Button();
            this.btnDO2 = new System.Windows.Forms.Button();
            this.btnDO1 = new System.Windows.Forms.Button();
            this.btnDI8 = new System.Windows.Forms.Button();
            this.imglistDI = new System.Windows.Forms.ImageList(this.components);
            this.btnDI7 = new System.Windows.Forms.Button();
            this.btnDI6 = new System.Windows.Forms.Button();
            this.btnDI5 = new System.Windows.Forms.Button();
            this.btnDI4 = new System.Windows.Forms.Button();
            this.btnDI3 = new System.Windows.Forms.Button();
            this.btnDI2 = new System.Windows.Forms.Button();
            this.btnDI1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxRcv = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_AI8 = new System.Windows.Forms.TextBox();
            this.txt_AI7 = new System.Windows.Forms.TextBox();
            this.txt_AI6 = new System.Windows.Forms.TextBox();
            this.txt_AI5 = new System.Windows.Forms.TextBox();
            this.txt_AI4 = new System.Windows.Forms.TextBox();
            this.txt_AI3 = new System.Windows.Forms.TextBox();
            this.txt_AI2 = new System.Windows.Forms.TextBox();
            this.txt_AI1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(77, 20);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(121, 21);
            this.ip.TabIndex = 66;
            this.ip.Text = "192.168.1.232";
            // 
            // btnReadAI
            // 
            this.btnReadAI.Location = new System.Drawing.Point(604, 33);
            this.btnReadAI.Name = "btnReadAI";
            this.btnReadAI.Size = new System.Drawing.Size(75, 23);
            this.btnReadAI.TabIndex = 65;
            this.btnReadAI.Text = "读取AI";
            this.btnReadAI.UseVisualStyleBackColor = true;
            this.btnReadAI.Click += new System.EventHandler(this.btnReadAI_Click);
            // 
            // txtAINum
            // 
            this.txtAINum.Location = new System.Drawing.Point(526, 33);
            this.txtAINum.Name = "txtAINum";
            this.txtAINum.Size = new System.Drawing.Size(66, 21);
            this.txtAINum.TabIndex = 64;
            this.txtAINum.Text = "8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 63;
            this.label8.Text = "AI数量";
            // 
            // btnReadDO
            // 
            this.btnReadDO.Location = new System.Drawing.Point(156, 34);
            this.btnReadDO.Name = "btnReadDO";
            this.btnReadDO.Size = new System.Drawing.Size(75, 23);
            this.btnReadDO.TabIndex = 62;
            this.btnReadDO.Text = "读取DO";
            this.btnReadDO.UseVisualStyleBackColor = true;
            this.btnReadDO.Click += new System.EventHandler(this.btnReadDO_Click);
            // 
            // btnReadDI
            // 
            this.btnReadDI.Location = new System.Drawing.Point(392, 33);
            this.btnReadDI.Name = "btnReadDI";
            this.btnReadDI.Size = new System.Drawing.Size(75, 23);
            this.btnReadDI.TabIndex = 61;
            this.btnReadDI.Text = "读取DI";
            this.btnReadDI.UseVisualStyleBackColor = true;
            this.btnReadDI.Click += new System.EventHandler(this.btnReadDI_Click_1);
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(85, 58);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(66, 21);
            this.txtaddr.TabIndex = 58;
            this.txtaddr.Text = "254";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "设备地址";
            // 
            // txtDINum
            // 
            this.txtDINum.Location = new System.Drawing.Point(314, 34);
            this.txtDINum.Name = "txtDINum";
            this.txtDINum.Size = new System.Drawing.Size(66, 21);
            this.txtDINum.TabIndex = 56;
            this.txtDINum.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "DI数量";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(461, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "清空接收";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDONum
            // 
            this.txtDONum.Location = new System.Drawing.Point(75, 34);
            this.txtDONum.Name = "txtDONum";
            this.txtDONum.Size = new System.Drawing.Size(66, 21);
            this.txtDONum.TabIndex = 53;
            this.txtDONum.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 52;
            this.label3.Text = "DO数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "端口号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "IP:";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(293, 20);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(66, 21);
            this.txtport.TabIndex = 35;
            this.txtport.Text = "10000";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(365, 19);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 36;
            this.btnopen.Text = "打开连接";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseAll.ImageKey = "comclosed.ico";
            this.btnCloseAll.Location = new System.Drawing.Point(506, 58);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(100, 35);
            this.btnCloseAll.TabIndex = 38;
            this.btnCloseAll.Tag = "1";
            this.btnCloseAll.Text = "  关闭全部";
            this.btnCloseAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseAll.UseVisualStyleBackColor = false;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnDO8
            // 
            this.btnDO8.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO8.ImageIndex = 0;
            this.btnDO8.ImageList = this.imglistDO;
            this.btnDO8.Location = new System.Drawing.Point(387, 58);
            this.btnDO8.Name = "btnDO8";
            this.btnDO8.Size = new System.Drawing.Size(68, 32);
            this.btnDO8.TabIndex = 88;
            this.btnDO8.Tag = "8";
            this.btnDO8.Text = " DO8";
            this.btnDO8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO8.UseVisualStyleBackColor = false;
            this.btnDO8.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // imglistDO
            // 
            this.imglistDO.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistDO.ImageStream")));
            this.imglistDO.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistDO.Images.SetKeyName(0, "comclosed.ico");
            this.imglistDO.Images.SetKeyName(1, "comopened.ico");
            this.imglistDO.Images.SetKeyName(2, "24_Help.ico");
            // 
            // btnDO7
            // 
            this.btnDO7.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO7.ImageIndex = 0;
            this.btnDO7.ImageList = this.imglistDO;
            this.btnDO7.Location = new System.Drawing.Point(268, 58);
            this.btnDO7.Name = "btnDO7";
            this.btnDO7.Size = new System.Drawing.Size(68, 32);
            this.btnDO7.TabIndex = 87;
            this.btnDO7.Tag = "7";
            this.btnDO7.Text = " DO7";
            this.btnDO7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO7.UseVisualStyleBackColor = false;
            this.btnDO7.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDO6
            // 
            this.btnDO6.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO6.ImageIndex = 0;
            this.btnDO6.ImageList = this.imglistDO;
            this.btnDO6.Location = new System.Drawing.Point(149, 58);
            this.btnDO6.Name = "btnDO6";
            this.btnDO6.Size = new System.Drawing.Size(68, 32);
            this.btnDO6.TabIndex = 86;
            this.btnDO6.Tag = "6";
            this.btnDO6.Text = " DO6";
            this.btnDO6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO6.UseVisualStyleBackColor = false;
            this.btnDO6.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenAll.ImageKey = "comopened.ico";
            this.btnOpenAll.Location = new System.Drawing.Point(505, 20);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(100, 35);
            this.btnOpenAll.TabIndex = 39;
            this.btnOpenAll.Tag = "1";
            this.btnOpenAll.Text = "  打开全部";
            this.btnOpenAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAll.UseVisualStyleBackColor = false;
            this.btnOpenAll.Click += new System.EventHandler(this.btnOpenAll_Click);
            // 
            // btnDO5
            // 
            this.btnDO5.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO5.ImageIndex = 0;
            this.btnDO5.ImageList = this.imglistDO;
            this.btnDO5.Location = new System.Drawing.Point(30, 58);
            this.btnDO5.Name = "btnDO5";
            this.btnDO5.Size = new System.Drawing.Size(68, 32);
            this.btnDO5.TabIndex = 85;
            this.btnDO5.Tag = "5";
            this.btnDO5.Text = " DO5";
            this.btnDO5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO5.UseVisualStyleBackColor = false;
            this.btnDO5.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDO4
            // 
            this.btnDO4.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO4.ImageIndex = 0;
            this.btnDO4.ImageList = this.imglistDO;
            this.btnDO4.Location = new System.Drawing.Point(386, 20);
            this.btnDO4.Name = "btnDO4";
            this.btnDO4.Size = new System.Drawing.Size(68, 32);
            this.btnDO4.TabIndex = 84;
            this.btnDO4.Tag = "4";
            this.btnDO4.Text = " DO4";
            this.btnDO4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO4.UseVisualStyleBackColor = false;
            this.btnDO4.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDO3
            // 
            this.btnDO3.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO3.ImageIndex = 0;
            this.btnDO3.ImageList = this.imglistDO;
            this.btnDO3.Location = new System.Drawing.Point(267, 20);
            this.btnDO3.Name = "btnDO3";
            this.btnDO3.Size = new System.Drawing.Size(68, 32);
            this.btnDO3.TabIndex = 83;
            this.btnDO3.Tag = "3";
            this.btnDO3.Text = " DO3";
            this.btnDO3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO3.UseVisualStyleBackColor = false;
            this.btnDO3.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDO2
            // 
            this.btnDO2.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO2.ImageIndex = 0;
            this.btnDO2.ImageList = this.imglistDO;
            this.btnDO2.Location = new System.Drawing.Point(148, 20);
            this.btnDO2.Name = "btnDO2";
            this.btnDO2.Size = new System.Drawing.Size(68, 32);
            this.btnDO2.TabIndex = 82;
            this.btnDO2.Tag = "2";
            this.btnDO2.Text = " DO2";
            this.btnDO2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO2.UseVisualStyleBackColor = false;
            this.btnDO2.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDO1
            // 
            this.btnDO1.BackColor = System.Drawing.SystemColors.Control;
            this.btnDO1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDO1.ImageIndex = 0;
            this.btnDO1.ImageList = this.imglistDO;
            this.btnDO1.Location = new System.Drawing.Point(29, 20);
            this.btnDO1.Name = "btnDO1";
            this.btnDO1.Size = new System.Drawing.Size(68, 32);
            this.btnDO1.TabIndex = 40;
            this.btnDO1.Tag = "1";
            this.btnDO1.Text = " DO1";
            this.btnDO1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDO1.UseVisualStyleBackColor = false;
            this.btnDO1.Click += new System.EventHandler(this.btnDO1_Click);
            // 
            // btnDI8
            // 
            this.btnDI8.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI8.FlatAppearance.BorderSize = 0;
            this.btnDI8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI8.ImageIndex = 0;
            this.btnDI8.ImageList = this.imglistDI;
            this.btnDI8.Location = new System.Drawing.Point(419, 19);
            this.btnDI8.Name = "btnDI8";
            this.btnDI8.Size = new System.Drawing.Size(55, 55);
            this.btnDI8.TabIndex = 48;
            this.btnDI8.Tag = "8";
            this.btnDI8.Text = "DI8";
            this.btnDI8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI8.UseVisualStyleBackColor = true;
            // 
            // imglistDI
            // 
            this.imglistDI.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistDI.ImageStream")));
            this.imglistDI.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistDI.Images.SetKeyName(0, "comclosed.ico");
            this.imglistDI.Images.SetKeyName(1, "comopened.ico");
            this.imglistDI.Images.SetKeyName(2, "24_Help.ico");
            // 
            // btnDI7
            // 
            this.btnDI7.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI7.FlatAppearance.BorderSize = 0;
            this.btnDI7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI7.ImageIndex = 0;
            this.btnDI7.ImageList = this.imglistDI;
            this.btnDI7.Location = new System.Drawing.Point(362, 19);
            this.btnDI7.Name = "btnDI7";
            this.btnDI7.Size = new System.Drawing.Size(55, 55);
            this.btnDI7.TabIndex = 47;
            this.btnDI7.Tag = "7";
            this.btnDI7.Text = "DI7";
            this.btnDI7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI7.UseVisualStyleBackColor = true;
            // 
            // btnDI6
            // 
            this.btnDI6.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI6.FlatAppearance.BorderSize = 0;
            this.btnDI6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI6.ImageIndex = 0;
            this.btnDI6.ImageList = this.imglistDI;
            this.btnDI6.Location = new System.Drawing.Point(305, 19);
            this.btnDI6.Name = "btnDI6";
            this.btnDI6.Size = new System.Drawing.Size(55, 55);
            this.btnDI6.TabIndex = 46;
            this.btnDI6.Tag = "6";
            this.btnDI6.Text = "DI6";
            this.btnDI6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI6.UseVisualStyleBackColor = true;
            // 
            // btnDI5
            // 
            this.btnDI5.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI5.FlatAppearance.BorderSize = 0;
            this.btnDI5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI5.ImageIndex = 0;
            this.btnDI5.ImageList = this.imglistDI;
            this.btnDI5.Location = new System.Drawing.Point(248, 19);
            this.btnDI5.Name = "btnDI5";
            this.btnDI5.Size = new System.Drawing.Size(55, 55);
            this.btnDI5.TabIndex = 45;
            this.btnDI5.Tag = "5";
            this.btnDI5.Text = "DI5";
            this.btnDI5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI5.UseVisualStyleBackColor = true;
            // 
            // btnDI4
            // 
            this.btnDI4.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI4.FlatAppearance.BorderSize = 0;
            this.btnDI4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI4.ImageIndex = 0;
            this.btnDI4.ImageList = this.imglistDI;
            this.btnDI4.Location = new System.Drawing.Point(191, 19);
            this.btnDI4.Name = "btnDI4";
            this.btnDI4.Size = new System.Drawing.Size(55, 55);
            this.btnDI4.TabIndex = 44;
            this.btnDI4.Tag = "4";
            this.btnDI4.Text = "DI4";
            this.btnDI4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI4.UseVisualStyleBackColor = true;
            // 
            // btnDI3
            // 
            this.btnDI3.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI3.FlatAppearance.BorderSize = 0;
            this.btnDI3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI3.ImageIndex = 0;
            this.btnDI3.ImageList = this.imglistDI;
            this.btnDI3.Location = new System.Drawing.Point(134, 19);
            this.btnDI3.Name = "btnDI3";
            this.btnDI3.Size = new System.Drawing.Size(55, 55);
            this.btnDI3.TabIndex = 43;
            this.btnDI3.Tag = "3";
            this.btnDI3.Text = "DI3";
            this.btnDI3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI3.UseVisualStyleBackColor = true;
            // 
            // btnDI2
            // 
            this.btnDI2.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI2.FlatAppearance.BorderSize = 0;
            this.btnDI2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI2.ImageIndex = 0;
            this.btnDI2.ImageList = this.imglistDI;
            this.btnDI2.Location = new System.Drawing.Point(77, 19);
            this.btnDI2.Name = "btnDI2";
            this.btnDI2.Size = new System.Drawing.Size(55, 55);
            this.btnDI2.TabIndex = 42;
            this.btnDI2.Tag = "2";
            this.btnDI2.Text = "DI2";
            this.btnDI2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI2.UseVisualStyleBackColor = true;
            // 
            // btnDI1
            // 
            this.btnDI1.BackColor = System.Drawing.SystemColors.Control;
            this.btnDI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDI1.FlatAppearance.BorderSize = 0;
            this.btnDI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDI1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDI1.ImageIndex = 0;
            this.btnDI1.ImageList = this.imglistDI;
            this.btnDI1.Location = new System.Drawing.Point(20, 19);
            this.btnDI1.Name = "btnDI1";
            this.btnDI1.Size = new System.Drawing.Size(55, 55);
            this.btnDI1.TabIndex = 41;
            this.btnDI1.Tag = "1";
            this.btnDI1.Text = "DI1";
            this.btnDI1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDI1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxRcv
            // 
            this.txtBoxRcv.Location = new System.Drawing.Point(723, 12);
            this.txtBoxRcv.Multiline = true;
            this.txtBoxRcv.Name = "txtBoxRcv";
            this.txtBoxRcv.Size = new System.Drawing.Size(373, 472);
            this.txtBoxRcv.TabIndex = 89;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_AI8);
            this.groupBox4.Controls.Add(this.txt_AI7);
            this.groupBox4.Controls.Add(this.txt_AI6);
            this.groupBox4.Controls.Add(this.txt_AI5);
            this.groupBox4.Controls.Add(this.txt_AI4);
            this.groupBox4.Controls.Add(this.txt_AI3);
            this.groupBox4.Controls.Add(this.txt_AI2);
            this.groupBox4.Controls.Add(this.txt_AI1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(5, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 83);
            this.groupBox4.TabIndex = 90;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AI输入";
            // 
            // txt_AI8
            // 
            this.txt_AI8.Location = new System.Drawing.Point(493, 50);
            this.txt_AI8.Name = "txt_AI8";
            this.txt_AI8.Size = new System.Drawing.Size(84, 21);
            this.txt_AI8.TabIndex = 59;
            this.txt_AI8.Text = "0";
            // 
            // txt_AI7
            // 
            this.txt_AI7.Location = new System.Drawing.Point(342, 50);
            this.txt_AI7.Name = "txt_AI7";
            this.txt_AI7.Size = new System.Drawing.Size(84, 21);
            this.txt_AI7.TabIndex = 59;
            this.txt_AI7.Text = "0";
            // 
            // txt_AI6
            // 
            this.txt_AI6.Location = new System.Drawing.Point(191, 50);
            this.txt_AI6.Name = "txt_AI6";
            this.txt_AI6.Size = new System.Drawing.Size(84, 21);
            this.txt_AI6.TabIndex = 59;
            this.txt_AI6.Text = "0";
            // 
            // txt_AI5
            // 
            this.txt_AI5.Location = new System.Drawing.Point(40, 50);
            this.txt_AI5.Name = "txt_AI5";
            this.txt_AI5.Size = new System.Drawing.Size(84, 21);
            this.txt_AI5.TabIndex = 59;
            this.txt_AI5.Text = "0";
            // 
            // txt_AI4
            // 
            this.txt_AI4.Location = new System.Drawing.Point(493, 14);
            this.txt_AI4.Name = "txt_AI4";
            this.txt_AI4.Size = new System.Drawing.Size(84, 21);
            this.txt_AI4.TabIndex = 59;
            this.txt_AI4.Text = "0";
            // 
            // txt_AI3
            // 
            this.txt_AI3.Location = new System.Drawing.Point(342, 14);
            this.txt_AI3.Name = "txt_AI3";
            this.txt_AI3.Size = new System.Drawing.Size(84, 21);
            this.txt_AI3.TabIndex = 59;
            this.txt_AI3.Text = "0";
            // 
            // txt_AI2
            // 
            this.txt_AI2.Location = new System.Drawing.Point(191, 14);
            this.txt_AI2.Name = "txt_AI2";
            this.txt_AI2.Size = new System.Drawing.Size(84, 21);
            this.txt_AI2.TabIndex = 59;
            this.txt_AI2.Text = "0";
            // 
            // txt_AI1
            // 
            this.txt_AI1.Location = new System.Drawing.Point(40, 14);
            this.txt_AI1.Name = "txt_AI1";
            this.txt_AI1.Size = new System.Drawing.Size(84, 21);
            this.txt_AI1.TabIndex = 59;
            this.txt_AI1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 52;
            this.label14.Text = "AI8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(308, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 52;
            this.label13.Text = "AI7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 52;
            this.label12.Text = "AI6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 52;
            this.label11.Text = "AI5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 52;
            this.label10.Text = "AI4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 52;
            this.label9.Text = "AI3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "AI2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "AI1";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(293, 58);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(66, 21);
            this.txtInterval.TabIndex = 80;
            this.txtInterval.Text = "1000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "打开定时器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDI8);
            this.groupBox5.Controls.Add(this.btnDI1);
            this.groupBox5.Controls.Add(this.btnDI7);
            this.groupBox5.Controls.Add(this.btnDI2);
            this.groupBox5.Controls.Add(this.btnDI6);
            this.groupBox5.Controls.Add(this.btnDI3);
            this.groupBox5.Controls.Add(this.btnDI5);
            this.groupBox5.Controls.Add(this.btnDI4);
            this.groupBox5.Location = new System.Drawing.Point(5, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(712, 86);
            this.groupBox5.TabIndex = 91;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DI输入";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDO1);
            this.groupBox1.Controls.Add(this.btnCloseAll);
            this.groupBox1.Controls.Add(this.btnDO2);
            this.groupBox1.Controls.Add(this.btnDO8);
            this.groupBox1.Controls.Add(this.btnDO3);
            this.groupBox1.Controls.Add(this.btnDO7);
            this.groupBox1.Controls.Add(this.btnDO4);
            this.groupBox1.Controls.Add(this.btnDO6);
            this.groupBox1.Controls.Add(this.btnDO5);
            this.groupBox1.Controls.Add(this.btnOpenAll);
            this.groupBox1.Location = new System.Drawing.Point(5, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 100);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtInterval);
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Controls.Add(this.btnopen);
            this.groupBox2.Controls.Add(this.txtport);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtaddr);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 100);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备信息及设置";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 90;
            this.label15.Text = "定时间隔：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDINum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDONum);
            this.groupBox3.Controls.Add(this.btnReadAI);
            this.groupBox3.Controls.Add(this.btnReadDI);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAINum);
            this.groupBox3.Controls.Add(this.btnReadDO);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(5, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 79);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置点数";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtBoxRcv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReadAI;
        public System.Windows.Forms.TextBox txtAINum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReadDO;
        private System.Windows.Forms.Button btnReadDI;
        public System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDINum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtDONum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnDO8;
        private System.Windows.Forms.Button btnDO7;
        private System.Windows.Forms.Button btnDO6;
        private System.Windows.Forms.Button btnOpenAll;
        private System.Windows.Forms.Button btnDO5;
        private System.Windows.Forms.Button btnDO4;
        private System.Windows.Forms.Button btnDO3;
        private System.Windows.Forms.Button btnDO2;
        private System.Windows.Forms.Button btnDO1;
        private System.Windows.Forms.Button btnDI8;
        private System.Windows.Forms.Button btnDI7;
        private System.Windows.Forms.Button btnDI6;
        private System.Windows.Forms.Button btnDI5;
        private System.Windows.Forms.Button btnDI4;
        private System.Windows.Forms.Button btnDI3;
        private System.Windows.Forms.Button btnDI2;
        private System.Windows.Forms.Button btnDI1;
        private System.Windows.Forms.ImageList imglistDO;
        private System.Windows.Forms.ImageList imglistDI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBoxRcv;
        public System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txt_AI8;
        public System.Windows.Forms.TextBox txt_AI7;
        public System.Windows.Forms.TextBox txt_AI6;
        public System.Windows.Forms.TextBox txt_AI5;
        public System.Windows.Forms.TextBox txt_AI4;
        public System.Windows.Forms.TextBox txt_AI3;
        public System.Windows.Forms.TextBox txt_AI2;
        public System.Windows.Forms.TextBox txt_AI1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer2;
    }
}

