using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIOTest.Entity
{
   public  class Enviroment
    {
        public Enviroment()
        { 
        }
        public Enviroment(double temp1,double humi1,double vibr1,bool clocked1)
        {
            temp = temp1;
            humi = humi1;
            vibr = vibr1;
            locked = clocked1;
        }
        /// <summary>
        /// 温度
        /// </summary>
        public double temp;
        /// <summary>
        /// 湿度
        /// </summary>
        public double humi;
        /// <summary>
        /// 震动
        /// </summary>
        public double vibr;
        /// <summary>
        /// 上锁
        /// </summary>
        public bool locked;

    }
}
