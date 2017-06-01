using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06委托介绍
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 c1 = new ClassLibrary1.Class1();

            //把M1方法赋值给了委托变量method,这样method就可以使用了，并且里面存储的就是M1方法
            //c1.method = M1;
            c1.Do(M1);
            Console.Read();
        }

        static void M1()
        {
            Console.WriteLine("当前时间：{0}", DateTime.Now);
        }
    }
}
