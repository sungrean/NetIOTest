using NetIOTest.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetIOTest.Forms
{
    public partial class BaseInfoForm : Form
    {
        public CarInfo carInfo;

        public BaseInfoForm()
        {
            InitializeComponent();
        }
        
        public BaseInfoForm(CarInfo carInfo)
        {
            this.carInfo = carInfo; 
            InitializeComponent();
        }

        private void BaseInfoForm_Load(object sender, EventArgs e)
        {
            if(carInfo==null)
            {
                pnl_content.Visible = false;
                pnl_head.Visible =true ;
                this.Height = pnl_head.Height;
                this.Parent.Height = this.Height;
            }
            else
            {
                pnl_content.Visible = true;
                pnl_head.Visible = false;
                this.Height = pnl_content.Height;
                this.Parent.Height = this.Height;
            }
            //boxIds = new TextBox[] {tbox_boxId1,tbox_boxId2,tbox_boxId3,tbox_boxId4 };
            //lotIds=new TextBox[] { tbox_lotId1,tbox_lotId2,tbox_lotId3,tbox_lotId4};
        }
        bool pnl_boxContentOpend = false; 
        //private void led_box_Click(object sender, EventArgs e)
        //{
        //    if(!carInfo.notEmpty)       //如果是空不显示box
        //    {
        //        return;
        //    }
        //    if(pnl_boxContentOpend)
        //    {
        //        pnl_boxContentOpend = false;
        //        pnl_boxContent.Visible = false;
        //        this.Height = pnl_content.Height;
        //        this.Parent.Height = this.Height;
        //    }
        //    else
        //    {
        //        pnl_boxContentOpend = true;
        //        pnl_boxContent.Visible = true;
        //        this.Height = pnl_content.Height + pnl_boxContent.Height;
        //        this.Parent.Height = this.Height;
        //    }
        //    this.Parent.Refresh();
        //}
       
        /// <summary>
        /// 更新小车信息。
        /// </summary>
        /// <param name="carInfo"></param>
        public void updateInfo(CarInfo carInfo)
        {
            this.carInfo = carInfo;
            updateUi();
        }
        TextBox[] boxIds;
        TextBox[] lotIds;
        public void updateUi()
        {  
            //if (carInfo.envAlrm)
            //{
            //    led_arlm.BackgroundImage = NetIOTest.Properties.Resources.led_blue;
            //}
            //else
            //{
            //    led_arlm.BackgroundImage = NetIOTest.Properties.Resources.led_gray;
            //}

            //if (carInfo.notEmpty)
            //{
            //    led_box.BackgroundImage = NetIOTest.Properties.Resources.led_green;
            //}
            //else
            //{
            //    led_box.BackgroundImage = NetIOTest.Properties.Resources.led_gray;
            //}

            //tbox_humi.Text = carInfo.curEnviroment.humi.ToString();
            //tbox_sn.Text = carInfo.sn.ToString();
            //tbox_temp.Text = carInfo.curEnviroment.temp.ToString();
            //tbox_virb.Text = carInfo.curEnviroment.vibr.ToString();
            //tbox_locked.Text = carInfo.curEnviroment.clocked ? "关闭" : "打开";

            //int boxNum = carInfo.boxes.Count;
            //for (int i = 0; i < 4; i++)
            //{
            //    if(i<boxNum)
            //    {
            //        boxIds[i].Text = carInfo.boxes[i].boxId.ToString();
            //        lotIds[i].Text = carInfo.boxes[i].lotId.ToString();
            //    }
            //}
             

        }

        private void pnl_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
