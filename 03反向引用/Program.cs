using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace _03反向引用
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            ////1.将”杨杨杨杨杨中中中中科科科科科”变成”杨中科”。
            ////string msg = "杨杨杨杨杨中中中中科科科科科";
            //string msg = "杨杨杨杨杨中中中中科科科科科AAAAAAAAAAABBBBBBBBBBBBC CCCCCCCCCCCCCCC啊啊啊啊啊啊啊啊啊啊啊买买买嘎嘎嘎嘎嘎得得得得";

            ////这个就是反向引用，在正则表达式内部,要引用内部的分组，则使用\1   \2   \3  \4 等来引用分组。
            //msg = Regex.Replace(msg, @"(.)\1+", "$1");
            //Console.WriteLine(msg);
            //Console.Read();





            //2.将"我...我我..我我我我....爱爱爱..爱..爱...你你...你..你你你..."，变成"我爱你"

            //string msg = "我...我我..我我我我....爱爱爱..爱..爱...你你...你..你你你...";
            //msg = msg.Replace(".", string.Empty);

            //msg = Regex.Replace(msg, @"(.)\1+", "$1");
            //Console.WriteLine(msg);
            //Console.Read();


            //string msg = "我...我我..我我我我....爱爱爱..爱..爱...你你...你..你你你...";
            //MatchCollection match = Regex.Matches(msg, @"((.)\2+\.+)+");
            //foreach (Match item in match)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine("共找到了：{0}个匹配。", match.Count);
            //Console.Read();

            #endregion


            #region MyRegion

            string filetxt = File.ReadAllText("英汉词典TXT格式.txt", Encoding.GetEncoding("gb2312"));
            MatchCollection matches = Regex.Matches(filetxt, @"[a-zA-Z]*([a-zA-Z])\1+[a-zA-Z]*");
            using (StreamWriter writer = new StreamWriter("words.txt"))
            {
                foreach (Match item in matches)
                {
                    //Console.WriteLine(item.Value);
                    writer.WriteLine(item.Value);
                }
            }
            Console.WriteLine(matches.Count);
            Console.WriteLine("ok");

            Console.Read();

            #endregion



        }
    }
}
