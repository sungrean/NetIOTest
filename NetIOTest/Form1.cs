﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetIOTest
{
    public partial class Form1 : Form
    {
        private TcpClient tclient = null;
        private NetworkStream ns1;
        private NetworkStream ns2;
        DateTime conntime = DateTime.Now;
        int ledmode = 0;//
        int ioindex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (tclient != null) tclient.Close();
            tclient = null;
            connectClient();
            timer1.Interval = 1000;
            timer2.Interval = 5000;
            
            //  timer1.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxRcv.Clear();
        }
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                //tclient = (TcpClient)ar.AsyncState;
                if (tclient.Connected == true)
                {
                    ns1 = tclient.GetStream();
                    ns2 = tclient.GetStream();

                    //因为要访问ui资源，所以需要使用invoke方式同步ui。
                    this.Invoke((EventHandler)(delegate
                    {
                        //追加的形式添加到文本框末端，并滚动到最后。
                        txtBoxRcv.AppendText("\r\n连接成功\r\n");
                        btnopen.Text = "连接成功";
                    }));
                }
                else
                    connectClient();
            }
            catch (Exception)
            {
                connectClient();
            }
        }
        private void connectClient()
        {
            try
            {
                if (tclient == null)
                {
                    conntime = DateTime.Now;
                    tclient = new TcpClient();
                    tclient.BeginConnect(ip.Text, Convert.ToInt32(txtport.Text), new AsyncCallback(ConnectCallback), tclient);
                    //因为要访问ui资源，所以需要使用invoke方式同步ui。
                    this.Invoke((EventHandler)(delegate
                    {
                        //追加的形式添加到文本框末端，并滚动到最后。
                        txtBoxRcv.AppendText(string.Format("\r\n重新连接中：{0}：{1}\r\n", ip.Text, Convert.ToInt32(txtport.Text)));
                    }));
                }
            }
            catch (Exception ex)
            {
                tclient = null;
                DebugInfo(ex.Message, null, 0);
            }
        }
        private void ShowDO(byte[] rst)
        {
            if (rst == null) return;
            Button[] btns = {
                btnDO1 , btnDO2 , btnDO3 , btnDO4 , btnDO5, btnDO6 , btnDO7 , btnDO8
                };

            for (int j = 0; j < rst.Length & j < 1; j++)
            {
                byte status = rst[j];
                for (int i = 0; i < 8; i++)
                {
                    if ((status & (1 << i)) == 0x00)
                        btns[j * 8 + i].ImageIndex = 0;
                    else
                        btns[j * 8 + i].ImageIndex = 1;
                }
            }

        }
        private void ShowDI(byte[] rst)
        {
            if (rst == null) return;
            Button[] btns = {
                btnDI1, btnDI2, btnDI3, btnDI4, btnDI5, btnDI6, btnDI7, btnDI8
                };

            for (int j = 0; j < rst.Length & j < 1; j++)
            {
                byte status = rst[j];
                for (int i = 0; i < 8; i++)
                {
                    if ((status & (1 << i)) == 0x00)
                        btns[j * 8 + i].ImageIndex = 0;
                    else
                        btns[j * 8 + i].ImageIndex = 1;
                }
            }
        }

        private void ReadDODIAddr()
        {
            byte[] info = CModbusDll.ReadAIInfo(Convert.ToInt16(txtaddr.Text), 1000, 6);
            byte[] rst = sendinfo(info);

            if (rst == null) return;
            if (rst.Length != 12) return;
            ushort baseaddr = 0;
            ushort equipid = 0;
            byte[] dostatus = new byte[4];
            byte[] distatus = new byte[4];

            baseaddr = rst[0];
            baseaddr <<= 8;
            baseaddr |= rst[1];

            equipid = rst[2];
            equipid <<= 8;
            equipid |= rst[3];

            for (int i = 0; i < 4; i++)
            {
                dostatus[i] = rst[4 + i];
                distatus[i] = rst[8 + i];
            }

            ShowDO(dostatus);
            ShowDI(distatus);
        }



        private byte[] analysisRcv(byte[] src, int len)
        {
            if (len < 6) return null;
            if (src[0] != Convert.ToInt16(txtaddr.Text)) return null;

            switch (src[1])
            {
                case 0x01:
                    if (CMBRTU.CalculateCrc(src, src[2] + 5) == 0x00)
                    {
                        byte[] dst = new byte[src[2]];
                        for (int i = 0; i < src[2]; i++)
                            dst[i] = src[3 + i];
                        return dst;
                    }
                    break;
                case 0x02:
                    if (CMBRTU.CalculateCrc(src, src[2] + 5) == 0x00)
                    {
                        byte[] dst = new byte[src[2]];
                        for (int i = 0; i < src[2]; i++)
                            dst[i] = src[3 + i];
                        return dst;
                    }
                    break;
                case 0x04:
                    if (CMBRTU.CalculateCrc(src, src[2] + 5) == 0x00)
                    {
                        byte[] dst = new byte[src[2]];
                        for (int i = 0; i < src[2]; i++)
                            dst[i] = src[3 + i];
                        return dst;
                    }
                    break;
                case 0x05:
                    if (CMBRTU.CalculateCrc(src, 8) == 0x00)
                    {
                        byte[] dst = new byte[1];
                        dst[0] = src[4];
                        return dst;
                    }
                    break;
                case 0x0f:
                    if (CMBRTU.CalculateCrc(src, 8) == 0x00)
                    {
                        byte[] dst = new byte[1];
                        dst[0] = 1;
                        return dst;
                    }
                    break;
                case 0x06:
                    if (CMBRTU.CalculateCrc(src, 8) == 0x00)
                    {
                        byte[] dst = new byte[4];
                        dst[0] = src[2];
                        dst[1] = src[3];
                        dst[2] = src[4];
                        dst[3] = src[5];
                        return dst;
                    }
                    break;
                case 0x10:
                    if (CMBRTU.CalculateCrc(src, 8) == 0x00)
                    {
                        byte[] dst = new byte[4];
                        dst[0] = src[2];
                        dst[1] = src[3];
                        dst[2] = src[4];
                        dst[3] = src[5];
                        return dst;
                    }
                    break;
            }
            return null;
        }


        private void DebugInfo(string infotxt, byte[] info, int len = 0)
        {
            string debuginfo;
            StringBuilder builder = new StringBuilder();
            if (info != null)
            {
                if (len == 0) len = info.Length;
                //判断是否是显示为16禁止
                //依次的拼接出16进制字符串
                for (int i = 0; i < len; i++)
                {
                    builder.Append(info[i].ToString("X2") + " ");
                }
            }
            debuginfo = string.Format("{0}:{1}\r\n", infotxt, builder.ToString());
            builder.Clear();

            //追加的形式添加到文本框末端，并滚动到最后。


            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                txtBoxRcv.AppendText(debuginfo);
                if (txtBoxRcv.TextLength > 1000) txtBoxRcv.Clear();
            }));
        }
        private byte[] RcvData()
        {
            byte[] info = new byte[2048 + 10];
            int len = 0;
            int retrycnt = 0;
            int timeout = Convert.ToInt32(txtInterval.Text);

            Thread.Sleep(10);
            while (timeout > 0)
            {
                timeout -= 20;
                ns2.ReadTimeout = 5;
                try
                {
                    byte[] rcv = new byte[2048 + 10];
                    int rdlen = ns2.Read(rcv, 0, 2048);
                    for (int i = 0; i < rdlen; i++)
                    {
                        if (len < 2048) info[len++] = rcv[i];
                    }

                    if (rdlen > 0) retrycnt = 0;
                }
                catch (Exception)
                {

                }
                if (len > 0)
                {
                    retrycnt++;
                    if (retrycnt > 3) timeout = 0;
                }
            }
            if (len < 5) return null;
            byte[] rst = new byte[len];
            for (int i = 0; i < len; i++)
                rst[i] = info[i];
            return rst;
        }
        private byte[] sendinfo(byte[] info)
        {
            if (tclient == null)
            {
                connectClient();
                return null;
            }

            if (tclient.Connected == false)
            {
                if (conntime.AddMilliseconds(5 * Convert.ToInt32(txtInterval.Text)) < DateTime.Now)
                {
                    tclient.Close();
                    tclient = null;
                }
                return null;
            }
            tclient.SendTimeout = 10;
            tclient.ReceiveTimeout = 10;
            try
            {

                try
                {
                    ns1.WriteTimeout = 3 + info.Length;
                    ns1.Write(info, 0, info.Length);
                    DebugInfo("发送", info);
                }
                catch (Exception)
                {
                    tclient = null;
                    return null;
                }


                byte[] data = RcvData();
                if (data == null) return null;
                DebugInfo("接收", data);
                return analysisRcv(data, data.Length);
            }
            catch (Exception)
            {

            }
            return null;
        }

        private void btnDO1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            bool isopen = (btn.ImageIndex == 0) ? false : true;

            int io = Convert.ToInt32(btn.Tag);
            if (isopen) CloseDO(io);
            else OpenDO(io);
        }

        private void OpenDO(int io)
        {
            Button[] btns = {
                btnDO1 , btnDO2 , btnDO3 , btnDO4 , btnDO5, btnDO6 , btnDO7 , btnDO8
            };
            byte[] info = CModbusDll.WriteDO(Convert.ToInt16(txtaddr.Text), io - 1, true);
            byte[] rst = sendinfo(info);
            if (rst != null)
            {
                btns[io - 1].ImageIndex = (rst[0] == 0) ? 0 : 1;
            }
        }
        private void CloseDO(int io)
        {
            Button[] btns = {
                btnDO1 , btnDO2 , btnDO3 , btnDO4 , btnDO5, btnDO6 , btnDO7 , btnDO8
            };
            byte[] info = CModbusDll.WriteDO(Convert.ToInt16(txtaddr.Text), io - 1, false);
            byte[] rst = sendinfo(info);
            if (rst != null)
            {
                btns[io - 1].ImageIndex = (rst[0] == 0) ? 0 : 1;
            }
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            byte[] info = CModbusDll.WriteAllDO(Convert.ToInt16(txtaddr.Text), Convert.ToInt16(txtDONum.Text), false);
            byte[] rst = sendinfo(info);
            if (rst != null)
            {
                byte[] doinfo = new byte[4];
                doinfo[0] = 0x00;
                doinfo[1] = 0x00;
                doinfo[2] = 0x00;
                doinfo[3] = 0x00;
                ShowDO(doinfo);
            }
        }

        private void btnOpenAll_Click(object sender, EventArgs e)
        {
            byte[] info = CModbusDll.WriteAllDO(Convert.ToInt16(txtaddr.Text), Convert.ToInt16(txtDONum.Text), true);
            byte[] rst = sendinfo(info);
            if (rst != null)
            {
                byte[] doinfo = new byte[4];
                doinfo[0] = 0xff;
                doinfo[1] = 0xff;
                doinfo[2] = 0xff;
                doinfo[3] = 0xff;
                ShowDO(doinfo);
            }
        }

        private void btnReadDI_Click_1(object sender, EventArgs e)
        {
            byte[] info = CModbusDll.ReadDI(Convert.ToInt16(txtaddr.Text), Convert.ToInt16(txtDINum.Text));
            byte[] rst = sendinfo(info);
            ShowDI(rst);
        }

        private void btnReadDO_Click(object sender, EventArgs e)
        {
            int donum = Convert.ToInt16(txtDONum.Text);
            byte[] info = CModbusDll.ReadDO(Convert.ToInt16(txtaddr.Text), Convert.ToInt16(txtDONum.Text));
            byte[] rst = sendinfo(info);
            ShowDO(rst);
        }

        private void btnReadAI_Click(object sender, EventArgs e)
        {
            ReadAIAddr();
        }

        private void ReadAIAddr()
        {
            int ainum = Convert.ToInt16(txtAINum.Text);
            byte[] info = CModbusDll.ReadAIInfo(Convert.ToInt16(txtaddr.Text), 0, ainum);
            byte[] rst = sendinfo(info);
            ShowAI(rst);
        }

        private void ShowAI(byte[] rst)
        {
            StringBuilder str = new StringBuilder();
            TextBox[] textBoxes = new TextBox[8] { txt_AI1, txt_AI2, txt_AI3, txt_AI4, txt_AI5, txt_AI6, txt_AI7, txt_AI8 };
            DebugInfo("1wswwsswww", rst);
            string[] readValue = new string[8];
            str.Append("\r\n读取AI：");
            if (!(rst is null) && rst.Length==16)
            {
                for (int i = 0; i < rst.Length; i += 2)
                {
                    short ai = rst[i];
                    ai <<= 8;
                    ai += rst[i + 1];
                    str.Append(ai + ",");
                    readValue[i/2] = ai.ToString();
                }
                str.Append(".\r\n");

                if (double.TryParse(readValue[0], out double Temp))
                {
                    if (Temp > 4000)
                    {
                        txt_AI1.Text = ((Temp / 1000 - 4) * 10 - 44.5).ToString();
                    }
                }
                if (double.TryParse(readValue[1], out double Humi))
                {
                    if (Temp > 4000)
                    {
                        txt_AI2.Text = ((Humi / 1000 - 4) * 6.25+0.5).ToString();
                    }
                }
                if (double.TryParse(readValue[2], out double HJ9002))
                {
                    if (Temp > 4000)
                    {
                        txt_AI3.Text = (HJ9002/800-5).ToString();
                    }
                }

                txtBoxRcv.AppendText(str.ToString());

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnReadDO_Click(null, null);
            btnReadDI_Click_1(null, null);
            btnReadAI_Click(null, null);

            //ReadAIAddr();
            //Thread.Sleep(2000);
            //ReadDODIAddr();

            //FE 04 10 2C 5F 29 0E 0F D5 00 00 00 00 00 00 00 00 00 00 E1 B5 FE 04 10 2C 5F 29 0E 0F D5 00 00 00 00 00 00 00 00 00 00 E1 B5 
            //FE 04 0C                         00 01 00 1B 00 00 00 00 00 00 00 00 90 FB FE 04 0C 00 01 00 1B 00 00 00 00 00 00 00 00 90 FB 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval =int.Parse(txtInterval.Text);
            timer1.Enabled = !timer1.Enabled;
           // timer2.Enabled = !timer2.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
           // ReadAIAddr();
        }
    }
}
