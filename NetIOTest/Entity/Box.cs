using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIOTest.Entity
{
    public class Box
    {
        /// <summary>
        /// 设置盒子ID和lotId
        /// </summary>
        /// <param name="boxId1">盒子Id</param>
        /// <param name="lotId1">LotId</param>
        public Box(string boxId1, string lotId1)
        {
            boxId = boxId1;
            lotId = lotId1;
        }
        public Box(string boxId1, string lotId1,string goodsType1)
        {
            boxId = boxId1;
            lotId = lotId1;
            goodsType = goodsType1;
        }
        /// <summary>
        /// 盒子编号
        /// </summary>
        public  string boxId;
        /// <summary>
        /// lotId
        /// </summary>
        public string lotId;
        /// <summary>
        /// 货物名称、类型
        /// </summary>
        public string goodsType;
    }
}
