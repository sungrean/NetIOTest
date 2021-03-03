using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetIOTest.Tools
{
   public static class Logger
    { 
        public static void LogInfo(string str)
        {
            try
            {
                System.IO.File.AppendAllText("./DebugInfo.log", $"logger:{DateTime.Now.ToString()}:{str}");
            }
            catch(Exception exp)            //文件操作发生异常，延迟一毫秒再操作。
            {
                Thread.Sleep(1);
                System.IO.File.AppendAllText("./DebugInfo.log", $"logger:{DateTime.Now.ToString()}:{str}"); 
            }
        }
    }
}
