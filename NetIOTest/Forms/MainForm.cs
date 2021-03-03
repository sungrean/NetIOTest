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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<BaseInfoForm> baseInfoForms = new List<BaseInfoForm>();

        private bool AllowDrag = true;
        private int _DDradius = 45;
        private bool _isDragging = false;
        private int _mX = 0;
        private int _mY = 0;
        Panel panl = null;
        PictureBox pbox = null;
        private void MainForm_Load(object sender, EventArgs e)
        {
            baseInfoForms.Add(new BaseInfoForm());
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));
            baseInfoForms.Add(new BaseInfoForm(new Entity.CarInfo("", new Entity.Enviroment(), new List<Entity.Enviroment>())));

            baseInfoForms[1].carInfo.sn = "ts152100";
            baseInfoForms[1].carInfo.envAlrm = true;
            baseInfoForms[1].carInfo.notEmpty = true;
            baseInfoForms[1].carInfo.curEnviroment.locked = false;
            baseInfoForms[1].carInfo.curEnviroment.humi = 55.6;
            baseInfoForms[1].carInfo.curEnviroment.temp = 22.5;
            baseInfoForms[1].carInfo.curEnviroment.vibr = 55.6;
            baseInfoForms[1].carInfo.boxes.Add(new Entity.Box("box1552", "t1121"));
            baseInfoForms[1].carInfo.boxes.Add(new Entity.Box("box1553", "t1121"));
            baseInfoForms[1].carInfo.boxes.Add(new Entity.Box("box1554", "t1121"));
            baseInfoForms[1].carInfo.boxes.Add(new Entity.Box("box1555", "t1122"));
            for (int i=0;i<baseInfoForms.Count;i++ )
            {
                Panel panl = new Panel();
                panl.Name = string.Format("pic{0}", this.flp_container.Controls.Count);//Name属性
                panl.Width = 1246;
                panl.Height =  85;
                panl.AllowDrop = true;
                panl.BackColor = Color.Gainsboro; 
                BaseInfoForm bif = baseInfoForms[i];
                bif.Name = "bif" + i;
                bif.TopLevel = false;
                bif.Parent = panl;
                panl.Controls.Add(bif);
                bif.Show(); 
                flp_container.Controls.Add(panl);
            } 
            baseInfoForms[1].updateUi();

            

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //flp_container.Refresh();
        }
    }
}
