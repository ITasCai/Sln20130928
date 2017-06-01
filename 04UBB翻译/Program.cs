using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04UBB翻译
{
    class Program
    {
        static void Main(string[] args)
        {
            ////把ubb代码翻译成了html代码
            ////<b>加粗的字体</b>
            //string msg = "[b]加粗的字体[/b]哈哈哈哈[b]传智播客[/b][b]加粗的字体[/b]哈哈哈哈[b]传智播客[/b]";
            //msg = Regex.Replace(msg, @"\[b\](.+?)\[/b\]", "<b>$1</b>");
            //Console.WriteLine(msg);
            //Console.Read();

            //[b]新网站[/b]    <b>新网站</b>
            //[url=http://www.qq.com]秋秋[/url]  <a href="http://www.qq.com">秋秋</a>

            string ubb = "【你好，我发现一个[b]新网站[/b]，[b]大家[/b]来看呀[url=http://www.qq.com]秋秋[/url]，另外一个有时间也可以看看[url=http://www.rupeng.com]如鹏[/url]，还有[url=http://www.itcast.cn]传智播客[/url]】。吼吼！";

            //替换b标签
            string html = Regex.Replace(ubb, @"\[b\](.+?)\[/b\]", "<b>$1</b>", RegexOptions.IgnoreCase);

            //替换url标签  url=http://www.qq.com]秋秋[/url]
            html = Regex.Replace(html, @"\[url=(.+?)\](.+?)\[/url\]", "<a href=\"$1\">$2</a>", RegexOptions.IgnoreCase);

            //<a href=".+">.+</a>

            Console.WriteLine(html);
            Console.Read();


        }
    }
}
