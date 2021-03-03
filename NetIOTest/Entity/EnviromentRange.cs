using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIOTest.Entity
{
   public  class EnviromentRange
    {
        public EnviromentRange(Enviroment min, Enviroment max,bool selected1)
        {
            enviromentMin = min;
            enviromentMax = max;
            selected = selected1;
        } 
        /// <summary>
        /// 环境报警下限
        /// </summary>
        public Enviroment enviromentMin;

        /// <summary>
        /// 环境报警上限 
        /// </summary>
        public Enviroment enviromentMax;

        /// <summary>
        /// 是否作为当前环境范围
        /// </summary>
        public bool selected;
    }
}
