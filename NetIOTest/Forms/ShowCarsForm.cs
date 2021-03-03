using NetIOTest.Entity;
using NetIOTest.Tools;
using System;
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

namespace NetIOTest.Forms
{
    public partial class ShowCarsForm : Form
    {
        CarInfo[] carInfos = new CarInfo[20];
        Label[] lab_carId = new Label[20];
        Label[] lab_Temp = new Label[20];
        Label[] lab_him = new Label[20];
        Label[] lab_vib = new Label[20];
        PictureBox[] pbox_lock = new PictureBox[20];
        Label[] lab_boxNum = new Label[20];
        Label[] lab_btattery = new Label[20];
        Label[] lab_lotId1 = new Label[20];
        Label[] lab_lotId2 = new Label[20];

        #region 网络通信参数

        private TcpClient tclient = null;
        private NetworkStream ns1;
        private NetworkStream ns2;
        string ip;
        string port;
        DateTime conntime = DateTime.Now;
        #endregion
        public ShowCarsForm()
        {
            
            for(int i=0;i<20;i++)
            {
                Enviroment enviroment = new Enviroment(0,0,0,false);
                carInfos[i] = new CarInfo("0000",enviroment);
            }
            InitializeComponent();
        }
        private void ShowCarsForm_Load(object sender, EventArgs e)
        {
            #region 绑定界面元素到数组。
            lab_carId = new Label[]{ lab_carId1, lab_carId2, lab_carId3, lab_carId4, lab_carId5, 
                lab_carId6, lab_carId7, lab_carId8, lab_carId9, lab_carId10,
            lab_carId11, lab_carId12, lab_carId13, lab_carId14, lab_carId15,
                lab_carId16, lab_carId17, lab_carId18, lab_carId19, lab_carId20,
            };
            lab_Temp = new Label[] { lab_Temp1, lab_Temp2, lab_Temp3, lab_Temp4, lab_Temp5,
                lab_Temp6, lab_Temp7, lab_Temp8, lab_Temp9, lab_Temp10,
                lab_Temp11, lab_Temp12, lab_Temp13, lab_Temp14, lab_Temp15,
                lab_Temp16, lab_Temp17, lab_Temp18, lab_Temp19, lab_Temp20,
            };
            lab_him = new Label[] { lab_him1, lab_him2, lab_him3, lab_him4, lab_him5,
                lab_him6, lab_him7, lab_him8, lab_him9, lab_him10,
             lab_him11, lab_him12, lab_him13, lab_him14, lab_him15,
                lab_him16, lab_him17, lab_him18, lab_him19, lab_him20,
            };
            lab_vib = new Label[] { lab_vib1, lab_vib2, lab_vib3, lab_vib4, lab_vib5,
                lab_vib6, lab_vib7, lab_vib8, lab_vib9, lab_vib10,
                 lab_vib11, lab_vib12, lab_vib13, lab_vib14, lab_vib15,
                lab_vib16, lab_vib17, lab_vib18, lab_vib19, lab_vib20,
            };
            pbox_lock = new PictureBox[] { pbox_lock1, pbox_lock2, pbox_lock3, pbox_lock4, pbox_lock5,
                pbox_lock6, pbox_lock7, pbox_lock8, pbox_lock9, pbox_lock10,
                pbox_lock11, pbox_lock12, pbox_lock13, pbox_lock14, pbox_lock15,
                pbox_lock16, pbox_lock17, pbox_lock18, pbox_lock19, pbox_lock20,
            };
            lab_boxNum = new Label[] { lab_boxNum1, lab_boxNum2, lab_boxNum3, lab_boxNum4, lab_boxNum5, 
                lab_boxNum6, lab_boxNum7, lab_boxNum8, lab_boxNum9, lab_boxNum10,
            lab_boxNum11, lab_boxNum12, lab_boxNum13, lab_boxNum14, lab_boxNum15,
                lab_boxNum16, lab_boxNum17, lab_boxNum18, lab_boxNum19, lab_boxNum20,
            };
            lab_btattery = new Label[] { lab_btattery1, lab_btattery2, lab_btattery3, lab_btattery4, lab_btattery5,
                lab_btattery6, lab_btattery7, lab_btattery8, lab_btattery9, lab_btattery10,
                lab_btattery11, lab_btattery12, lab_btattery13, lab_btattery14, lab_btattery15,
                lab_btattery16, lab_btattery17, lab_btattery18, lab_btattery19, lab_btattery20,
            };
            lab_lotId1 = new Label[] { lab_lotId1_1, lab_lotId1_2, lab_lotId1_3, lab_lotId1_4, lab_lotId1_5,
                lab_lotId1_6, lab_lotId1_7, lab_lotId1_8, lab_lotId1_9, lab_lotId1_10,
                lab_lotId1_11, lab_lotId1_12, lab_lotId1_13, lab_lotId1_14, lab_lotId1_15,
                lab_lotId1_16, lab_lotId1_17, lab_lotId1_18, lab_lotId1_19, lab_lotId1_20,
            };
            lab_lotId2 = new Label[] { lab_lotId2_1, lab_lotId2_2, lab_lotId2_3, lab_lotId2_4, lab_lotId2_5,
                lab_lotId2_6, lab_lotId2_7, lab_lotId2_8, lab_lotId2_9, lab_lotId2_10,
                lab_lotId2_11, lab_lotId2_12, lab_lotId2_13, lab_lotId2_14, lab_lotId2_15,
                lab_lotId2_16, lab_lotId2_17, lab_lotId2_18, lab_lotId2_19, lab_lotId2_20,
            };
            #endregion
            #region 设置第一行数据
            Enviroment enviroment = new Enviroment(0, 0, 0, true);
            carInfos[0] = new CarInfo("0001", enviroment);
            #endregion
            #region 读取环境范围
            List<EnviromentRange> ranges = EnviromentSettingsForm.GetEnviromentRanges();
            for (int i = 0; i < ranges.Count; i++)
            {
                if (ranges[i].selected)
                {
                    enviromentRange = ranges[i];
                }
            }
            if (enviromentRange == null)           //如果没有选中的范围，则设置第一个为当前范围。
            {
                enviromentRange = ranges[0];
            }
            #endregion
            #region 跟新数据到界面
            UpdateUiInfo();
            #endregion
            #region 读取网络配置参数
            string str = "";
            try
            {
                str = System.IO.File.ReadAllText("./network.cfg");
            }
            catch (Exception exp)
            {
                ip = "192.168.1.232";
                port = "10000";
                System.IO.File.WriteAllText("./network.cfg", $"{ip}:{port}");
            }
            if (str != "")
            {
                ip= str.Split(':')[0];
                port = str.Split(':')[1];
            }
            #endregion
            #region 连接到modbus服务器
            connectClient();
            #endregion

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        delegate void UpdateUiInfoInvoke();
        public void UpdateUiInfo()
        {
            int cnt = carInfos.Count();
            for(int i=0;i<cnt;i++)
            {
                if (carInfos[i].curEnviroment.temp < enviromentRange.enviromentMin.temp | carInfos[i].curEnviroment.temp > enviromentRange.enviromentMax.temp)
                {
                    lab_Temp[i].BackColor = Color.Red;
                }
                else
                {
                    lab_Temp[i].BackColor = Color.Blue;
                }
                if (carInfos[i].curEnviroment.humi < enviromentRange.enviromentMin.humi | carInfos[i].curEnviroment.humi > enviromentRange.enviromentMax.humi)
                {
                    lab_him[i].BackColor = Color.Red;
                }
                else
                {
                    lab_him[i].BackColor = Color.Blue;
                }
                if (carInfos[i].curEnviroment.vibr < enviromentRange.enviromentMin.vibr | carInfos[i].curEnviroment.vibr > enviromentRange.enviromentMax.vibr)
                {
                    lab_vib[i].BackColor = Color.Red;
                }
                else
                {
                    lab_vib[i].BackColor = Color.Blue;
                }
                lab_carId[i].Text = carInfos[i].sn;
                lab_Temp[i].Text = carInfos[i].curEnviroment.temp.ToString()+"°C";
                lab_him[i].Text = carInfos[i].curEnviroment.humi.ToString("0.00")+"%";
                lab_vib[i].Text = carInfos[i].curEnviroment.vibr.ToString("00.00")+"mm";
                if(carInfos[i].curEnviroment.locked)
                {
                    pbox_lock[i].Image = NetIOTest.Properties.Resources.locked;
                }
                else
                {
                    pbox_lock[i].Image = NetIOTest.Properties.Resources.unlock;
                }
                lab_boxNum[i].Text = carInfos[i].boxes.Count.ToString();
                lab_btattery[i].Text = carInfos[i].battery.ToString();
                lab_lotId1[i].Text = "0000";
                lab_lotId2[i].Text = "0000";
            }
        }

        #region 网络通信相关函数
        private void connectClient()
        {
            try
            {
                if (tclient == null)
                {
                    conntime = DateTime.Now;
                    tclient = new TcpClient();
                    tclient.BeginConnect(ip, Convert.ToInt32(port), new AsyncCallback(ConnectCallback), tclient);
                    this.Invoke((EventHandler)(delegate
                    {
                        Logger.LogInfo("请求建立连接");
                    }));
                }
            }
            catch (Exception ex)
            {
                tclient = null;
                DebugInfo(ex.Message, null, 0);
            }
        }
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            { 
                if (tclient.Connected == true)
                {
                    ns1 = tclient.GetStream();
                    ns2 = tclient.GetStream(); 
                    this.Invoke((EventHandler)(delegate
                    {
                        Logger.LogInfo("重新建立连接");
                    }));
                }
                else
                    connectClient();
            }
            catch (Exception exp)
            {
                connectClient();
                Logger.LogInfo("ConnectCallback:连接回调异常");
            }
        }
        private void DebugInfo(string infotxt, byte[] info, int len = 0)
        {
            string debuginfo;
            StringBuilder builder = new StringBuilder();
            if (info != null)
            {
                if (len == 0) len = info.Length; 
                for (int i = 0; i < len; i++)
                {
                    builder.Append(info[i].ToString("X2") + " ");
                }
            }
            debuginfo = string.Format("{0}:{1}\r\n", infotxt, builder.ToString()); 
            builder.Clear(); 
            this.Invoke((EventHandler)(delegate
            { 
                System.IO.File.AppendAllText("./DebugInfo.log", $"{DateTime.Now.ToString()}:{debuginfo}"); 
            }));
        }
        private byte[] RcvData()
        {
            byte[] info = new byte[2048 + 10];
            int len = 0;
            int retrycnt = 0;
            int timeout = 100;
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
                if (conntime.AddMilliseconds(5 * Convert.ToInt32(100)) < DateTime.Now)
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
        private byte[] analysisRcv(byte[] src, int len)
        {
            if (len < 6) return null;
            if (src[0] != 254) return null; 
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

        #endregion 
        int maxReadOverTimeCnt = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (maxReadOverTimeCnt <= 0)
            {
                Logger.LogInfo("连接超时！！即将退出程序");
                Application.Exit();
            }
            try
            {
                byte[] info = CModbusDll.ReadDI(254, 8);
                byte[] rst = sendinfo(info);
                ShowDI(rst);
                int donum = 8;
                info = CModbusDll.ReadDO(254, 8);
                rst = sendinfo(info);
                ShowDO(rst);
                int ainum = 8;
                info = CModbusDll.ReadAIInfo(254, 0, ainum);
                rst = sendinfo(info);
                ShowAI(rst);
                this.Invoke(new UpdateUiInfoInvoke(UpdateUiInfo));
                maxReadOverTimeCnt = 100;
            }
            catch (Exception exp)
            {
                maxReadOverTimeCnt--;
                Logger.LogInfo("发生异常：" + exp.Message);
            }
        }

        public void unlock()
        {
            byte[] info = CModbusDll.WriteAllDO(254, 8, true);
            byte[] rst = sendinfo(info);
        }
        public void locking()
        {
            byte[] info = CModbusDll.WriteAllDO(254, 8, false);
            byte[] rst = sendinfo(info);
        }
        private void ShowDO(byte[] rst)
        {  
        }
        private void ShowDI(byte[] rst)
        {
            if (rst == null) return; 
            if ((rst[0] & (1 << 7)) == 0x00)
            {
                carInfos[0].curEnviroment.locked = true; 
            }
            else
            {
                carInfos[0].curEnviroment.locked = false;
            } 
        }
        private void ShowAI(byte[] rst)
        {
            StringBuilder str = new StringBuilder(); 
            DebugInfo("recved from modbus server", rst);
            string[] readValue = new string[8];
            str.Append("\r\n读取AI：");
            if (!(rst is null) && rst.Length == 16)
            {
                for (int i = 0; i < rst.Length; i += 2)
                {
                    short ai = rst[i];
                    ai <<= 8;
                    ai += rst[i + 1];
                    str.Append(ai + ",");
                    readValue[i / 2] = ai.ToString();
                }
                str.Append(".\r\n"); 
                if (double.TryParse(readValue[0], out double Temp))
                {
                    if (Temp > 4000)
                    {
                        carInfos[0].curEnviroment.temp = ((Temp / 1000 - 4) * 10 - 44.5) ;
                    }
                }
                if (double.TryParse(readValue[1], out double Humi))
                {
                    if (Temp > 4000)
                    {
                        carInfos[0].curEnviroment.humi = ((Humi / 1000 - 4) * 6.25 + 0.5) ;
                    }
                }
                if (double.TryParse(readValue[2], out double HJ9002))
                {
                    if (Temp > 4000)
                    {
                        carInfos[0].curEnviroment.vibr = (HJ9002 / 800 - 5);
                    }
                } 
                Logger.LogInfo(str.ToString()); 
            } 
        }
        private void networkSetingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            netWorkSettingForm netSetting = new netWorkSettingForm();
               DialogResult result= netSetting.ShowDialog(); 

        }

        private void 重新连接ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            connectClient();
        }

        EnviromentRange enviromentRange = null;
        private void evnSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviromentSettingsForm EnvSetting = new EnviromentSettingsForm();
            DialogResult result = EnvSetting.ShowDialog();
            if(result==DialogResult.OK)
            {
                List<EnviromentRange> ranges= EnviromentSettingsForm.GetEnviromentRanges();
                for(int i=0;i<ranges.Count;i++)
                {
                    if(ranges[i].selected)
                    {
                        enviromentRange = ranges[i];
                    } 
                }
                if(enviromentRange==null)           //如果没有选中的范围，则设置第一个为当前范围。
                {
                    enviromentRange = ranges[0];
                }
            }
        }

        private void 开锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unlock();
        }

        private void 关锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locking();
        }
    }
}
