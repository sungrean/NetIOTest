using NetIOTest.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetIOTest.Forms
{
    public partial class EnviromentSettingsForm : Form
    {
        List<EnviromentRange> ranges = new List<EnviromentRange>();
        public EnviromentSettingsForm()
        {
            InitializeComponent();
        }

        private void tbox_ip_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnviromentSettingsForm_Load(object sender, EventArgs e)
        {
            ranges = GetEnviromentRanges();
            chkBoxs = new CheckBox[] {checkBox1,checkBox2,checkBox3 };
            UpdateInfoToUI();
        }
        public static List<EnviromentRange> GetEnviromentRanges()
        {
            List<EnviromentRange> result = new List<EnviromentRange>();
            try
            {
                foreach (string line in File.ReadLines(@"./enviromentRange.cfg"))
                {
                    string[] strRange = line.Split('|');
                    string strMin = strRange[0];
                    string strMax = strRange[1];
                    string strSelected = strRange[2];
                    string[] minProp = strMin.Split(':');
                    string[] maxProp = strMax.Split(':');
                    Enviroment envMin = new Enviroment(double.Parse(minProp[0]), double.Parse(minProp[1]), double.Parse(minProp[2]), bool.Parse(minProp[3]));
                    Enviroment envMax = new Enviroment(double.Parse(maxProp[0]), double.Parse(maxProp[1]), double.Parse(maxProp[2]), bool.Parse(maxProp[3]));
                    result.Add(new EnviromentRange(envMin, envMax, bool.Parse(strSelected))); 
                }
            }
            catch (Exception exp)
            {
                string[] strRange = new string[3]; 
                for(int i=0;i<3;i++)
                {
                    Enviroment envMin = new Enviroment(0, 0, -10, false);
                    Enviroment envMax = new Enviroment(60, 80, 10, false);
                    result.Add(new EnviromentRange(envMin, envMax, false));
                    strRange[i] = $"{envMin.temp}:{envMin.humi}:{envMin.vibr}:{envMin.locked}|{envMax.temp}:{envMax.humi}:{envMax.vibr}:{envMax.locked}|{false}";
                }
                File.Delete(@"./enviromentRange.cfg");
                File.AppendAllLines(@"./enviromentRange.cfg", strRange); 
            }
            if(result.Count==0)
            {
                string[] strRange = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    Enviroment envMin = new Enviroment(20, 20, -10, false);
                    Enviroment envMax = new Enviroment(60, 80, 10, false);
                    result.Add(new EnviromentRange(envMin, envMax, false));
                    strRange[i] = $"{envMin.temp}:{envMin.humi}:{envMin.vibr}:{envMin.locked}|{envMax.temp}:{envMax.humi}:{envMax.vibr}:{envMax.locked}|{false}";
                }
                File.Delete(@"./enviromentRange.cfg");
                File.AppendAllLines(@"./enviromentRange.cfg", strRange);
            }
            return result;
        }

        public void UpdateInfoToUI()
        {
            checkBox1.Checked = ranges[0].selected;
            tbox_tempMin1.Text = ranges[0].enviromentMin.temp.ToString();
            tbox_humiMin1.Text = ranges[0].enviromentMin.humi.ToString();
            tbox_vibrMin1.Text = ranges[0].enviromentMin.vibr.ToString();
            tbox_tempMax1.Text = ranges[0].enviromentMax.temp.ToString();
            tbox_humiMax1.Text = ranges[0].enviromentMax.humi.ToString();
            tbox_vibrMax1.Text = ranges[0].enviromentMax.vibr.ToString();

            checkBox2.Checked = ranges[1].selected;
            tbox_tempMin2.Text = ranges[1].enviromentMin.temp.ToString();
            tbox_humiMin2.Text = ranges[1].enviromentMin.humi.ToString();
            tbox_vibrMin2.Text = ranges[1].enviromentMin.vibr.ToString();
            tbox_tempMax2.Text = ranges[1].enviromentMax.temp.ToString();
            tbox_humiMax2.Text = ranges[1].enviromentMax.humi.ToString();
            tbox_vibrMax2.Text = ranges[1].enviromentMax.vibr.ToString();

            checkBox3.Checked = ranges[2].selected;
            tbox_tempMin3.Text = ranges[2].enviromentMin.temp.ToString();
            tbox_humiMin3.Text = ranges[2].enviromentMin.humi.ToString();
            tbox_vibrMin3.Text = ranges[2].enviromentMin.vibr.ToString();
            tbox_tempMax3.Text = ranges[2].enviromentMax.temp.ToString();
            tbox_humiMax3.Text = ranges[2].enviromentMax.humi.ToString();
            tbox_vibrMax3.Text = ranges[2].enviromentMax.vibr.ToString();
        }
        public void GetInfoFromUI()
        {
            ranges[2].selected = checkBox3.Checked;
            ranges[1].selected = checkBox2.Checked;
            ranges[0].selected = checkBox1.Checked;
            ranges[0].enviromentMin.temp = double.Parse(tbox_tempMin1.Text);
            ranges[0].enviromentMin.humi = double.Parse(tbox_humiMin1.Text);
            ranges[0].enviromentMin.vibr = double.Parse(tbox_vibrMin1.Text);
            ranges[0].enviromentMax.temp = double.Parse(tbox_tempMax1.Text);
            ranges[0].enviromentMax.humi = double.Parse(tbox_humiMax1.Text);
            ranges[0].enviromentMax.vibr = double.Parse(tbox_vibrMax1.Text);
            ranges[1].enviromentMin.temp = double.Parse(tbox_tempMin2.Text);
            ranges[1].enviromentMin.humi = double.Parse(tbox_humiMin2.Text);
            ranges[1].enviromentMin.vibr = double.Parse(tbox_vibrMin2.Text);
            ranges[1].enviromentMax.temp = double.Parse(tbox_tempMax2.Text);
            ranges[1].enviromentMax.humi = double.Parse(tbox_humiMax2.Text);
            ranges[1].enviromentMax.vibr = double.Parse(tbox_vibrMax2.Text);
            ranges[2].enviromentMin.temp = double.Parse(tbox_tempMin3.Text);
            ranges[2].enviromentMin.humi = double.Parse(tbox_humiMin3.Text);
            ranges[2].enviromentMin.vibr = double.Parse(tbox_vibrMin3.Text);
            ranges[2].enviromentMax.temp = double.Parse(tbox_tempMax3.Text);
            ranges[2].enviromentMax.humi = double.Parse(tbox_humiMax3.Text);
            ranges[2].enviromentMax.vibr = double.Parse(tbox_vibrMax3.Text);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            GetInfoFromUI();

            string[] strRange = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Enviroment envMin = ranges[i].enviromentMin;
                Enviroment envMax = ranges[i].enviromentMax; 
                strRange[i] = $"{envMin.temp}:{envMin.humi}:{envMin.vibr}:{envMin.locked}|{envMax.temp}:{envMax.humi}:{envMax.vibr}:{envMax.locked}|{chkBoxs[i].Checked}";
            }
            File.Delete(@"./enviromentRange.cfg");
            File.AppendAllLines(@"./enviromentRange.cfg", strRange);
        }
        CheckBox[] chkBoxs = null;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (chkBoxs != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (chkBoxs[i] == sender)
                    {
                        ranges[i].selected = true;
                        chkBoxs[i].CheckState = CheckState.Checked;
                    }
                    else
                    {
                        ranges[i].selected = false;
                        chkBoxs[i].Checked = false;
                    }
                }
            }

        }
    }
}
