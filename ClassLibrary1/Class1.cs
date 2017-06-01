using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public class Class1
    {
        ////第二步：通过委托类型，声明一个委托变量。
        //public T1Delegate method;

        public void Do(T1Delegate method)
        {

            Console.WriteLine("==================");
            Console.WriteLine("==================");
            //因为委托是引用类型，而引用类型的默认值都是null,所以在使用委托变量之前要进行非空校验
            if (method != null)
            {
                //这个委托变量method里面将来存储的就是一个方法，所以可以直接调用该变量，就相当于是调用了里面的方法
                method(); //method.Invoke();
            }
            Console.WriteLine("==================");
            Console.WriteLine("==================");
        }
        //下面的这个T1方法就没有用了。
        private void T1()
        {
            //Console.WriteLine("这个是T1方法，当前时间：{0}", DateTime.Now.ToString());
            File.WriteAllText("datetime.txt", DateTime.Now.ToString());
            Console.WriteLine("时间写入完毕！");
        }
    }
}
