using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace _01替换邮箱用户名部分
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            //string msg = "我的邮箱是zxh@itcast.cn杨中科的邮箱是yzk365@chezhihui.com减肥看到了撒steve_zhao@163.com发动机是啦";

            ////通过委托实现的字符串替换
            //msg = Regex.Replace(msg, @"([-a-zA-Z0-9_.]+)(@[-a-zA-Z0-9]+(\.[a-zA-Z0-9]+){1,})", GetReplaceString);
            //Console.WriteLine(msg);
            //Console.Read();

            #endregion


            #region MyRegion


            ////WebClient类的主要目的就是从网络上上传或下载内容
            //WebClient wc = new WebClient();


            ////WebRequest
            ////  WebResponse

            ////wc.DownloadFile("http://fdsfdsfdsfdsfasdf", @"c:\");
            ////wc.DownloadString();
            ////wc.DownloadData();

            ////wc.UploadData();
            ////wc.UploadFile();
            ////wc.UploadString();
            #endregion


            #region MyRegion


          

            #endregion
        }

        public static string GetReplaceString(Match match)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < match.Groups[1].Length; i++)
            {
                sb.Append("*");
            }
            sb.Append(match.Groups[2].Value);
            return sb.ToString();
        }


        //static string GetString(string can)
        //{
        //    return "AAA";
        //}

    }
}
