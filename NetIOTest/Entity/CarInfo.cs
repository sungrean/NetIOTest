using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIOTest.Entity
{
   public  class CarInfo
    {
        public CarInfo()
        {
            sn = "";
            curEnviroment = new Enviroment();
            envRecord = new List<Enviroment>();
            boxes = new List<Box>();
        }
        public CarInfo(string sn1, Enviroment env)
        {
            sn = sn1;
            curEnviroment = env;
            envRecord = new List<Enviroment>();
            boxes = new List<Box>();
        }
        public CarInfo(string sn1, Enviroment env,List<Enviroment> envRec)
        {
            sn = sn1;
            curEnviroment = env;
            envRecord = envRec;
            boxes = new List<Box>();
        }
        /// <summary>
        /// 小车编号
        /// </summary>
        public string sn;
        /// <summary>
        /// 当前环境
        /// </summary>
        public Enviroment curEnviroment;
        /// <summary>
        /// 环境变化记录
        /// </summary>
        public List<Enviroment> envRecord;
        /// <summary>
        /// 车上的盒子
        /// </summary>
        public List<Box> boxes;
        /// <summary>
        /// 环境报警
        /// </summary>
        public bool envAlrm;
        /// <summary>
        /// 小车有货
        /// </summary>
        public bool notEmpty;
        /// <summary>
        /// 电量
        /// </summary>
        public int battery;

    }
}
