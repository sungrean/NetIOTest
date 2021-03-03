using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIOTest
{
    public static class GlobalVariable
    {
        /// <summary>
        /// 模块IP
        /// </summary>
        public static string ip { get; set; } = "127.0.0.1";
        /// <summary>
        /// 模块端口
        /// </summary>
        public static string port { get; set; } = "127.0.0.1";
        /// <summary>
        /// 模块DI数量
        /// </summary>
        public static string dinum { get; set; } = "127.0.0.1";
        /// <summary>
        /// 模块DO数量
        /// </summary>
        public static string donum { get; set; } = "127.0.0.1";
        /// <summary>
        /// 设备地址
        /// </summary>
        public static string addr { get; set; } = "127.0.0.1";
        /// <summary>
        /// 采集时间间隔
        /// </summary>
        public static int itimeInverse { get; set; } = 1000;
    }
}
