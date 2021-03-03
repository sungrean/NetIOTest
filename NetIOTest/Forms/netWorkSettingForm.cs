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
    public partial class netWorkSettingForm : Form
    {
        public netWorkSettingForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("./network.cfg", $"{tbox_ip.Text}:{tbox_port.Text}");
        }

        private void netWorkSettingForm_Load(object sender, EventArgs e)
        {
            string str = "";
            try
            {
                str = System.IO.File.ReadAllText("./network.cfg");
            }
            catch(Exception exp)
            {
                tbox_ip.Text= "192.168.1.232";
                tbox_port.Text = "10000"; 
                System.IO.File.WriteAllText("./network.cfg", $"{tbox_ip.Text}:{tbox_port.Text}");
            }
            if(str!="")
            {
                tbox_ip.Text = str.Split(':')[0];
                tbox_port.Text = str.Split(':')[1];
            }
        }
    }
}
