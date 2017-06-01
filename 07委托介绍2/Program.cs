using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _07委托介绍2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();
            //c1.method = M2;
            c1.Do(M2);
            Console.Read();
        }
        static void M2()
        {
            File.WriteAllText("datetime.txt", System.DateTime.Now.ToString());
            Console.WriteLine("时间已经写入到了datetime.txt文件中了。");
        }

    }
}
