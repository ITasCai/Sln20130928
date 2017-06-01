using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02单词的边界_断言__ｂ
{
    class Program
    {
        //  \zzr\G+\ylp
        static void Main(string[] args)
        {
            //string msg = "The The day after tomorrow is my wedding day.The row, we are looking for is .row. number 10.";

            //// \b就表示单词的边界，什么是单词的边界，
            ////单词的边界表示：一边是单词，一边不是单词，这个就是单词的边界。
            ////  \b表示的是一个断言，什么是断言：只验证，不匹配。
            //msg = Regex.Replace(msg, @"\brow\b", "line");
            //Console.WriteLine(msg);
            //Console.Read();


            #region 练习：Hi,how are you?Welcome to our country!请提取出3个字母的单词。

            ////D-Day
            ////VE-Day

            ////单词：\w  (0-9a-zA-Z_)
            ////环视，断言。
            ////  \w\b\W    \W\b\w
            //string msg = "Hi,how 12are12 you?Welcome to our country!";
            //MatchCollection matches = Regex.Matches(msg, @"\b[a-zA-Z]{3}\b");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.Read();

            #endregion


            #region MyRegion
            ////注意：\b必须是一边是单词，一边不是单词。这里所说的单词就是指的 \w
            //string msg = "# ## ### #### ## ### # ###.";
            //MatchCollection matches = Regex.Matches(msg, @"\b###\b");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.Write("ok");
            //Console.ReadKey();


            #endregion
        }
    }
}
