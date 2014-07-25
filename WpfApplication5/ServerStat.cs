using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace LoginIndicator
{
    class ServerStat
    {
       
        public static string ShowStat(string IP_str)
        {
            string ServerSTAT = "";
           
            string ipStr = IP_str;
            //构造Ping实例  
            Ping pingSender = new Ping();
            //Ping 选项设置  
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            //测试数据  
            string data = "test data abcabc";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //设置超时时间  
            int timeout = 120;
            //调用同步 send 方法发送数据,将返回结果保存至PingReply实例  
            PingReply reply = pingSender.Send(ipStr, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                ServerSTAT = "稼動中";            
            }
            else 
            {
                ServerSTAT = "停止中";
            }
            return ServerSTAT;
        }
        public static string ShowLat(string IP_str)
        {
          
            string ServerLat = "";
            //远程服务器IP  
            string ipStr = IP_str;
            //构造Ping实例  
            Ping pingSender = new Ping();
            //Ping 选项设置  
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            //测试数据  
            string data = "test data abcabc";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            //设置超时时间  
            int timeout = 120;
            //调用同步 send 方法发送数据,将返回结果保存至PingReply实例  
            PingReply reply = pingSender.Send(ipStr, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {            
                ServerLat = "" + reply.RoundtripTime + "";
            }
            else
            {
                ServerLat = "N/A";
            }
            return ServerLat;
        }
    
    }
}
