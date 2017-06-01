using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion

            ////委托类型变量只能赋值委托对象，看起来把一个方法赋值给了一个委托变量，其实内部也帮我们创建了一个委托对象，把方法作为委托的参数传了进去。
            //Delegate1 md = new Delegate1(M1); //M1;

            //// md();
            //md.Invoke(); //等价于md();
            //Console.WriteLine("ok");
            //Console.Read();

            ////委托其实编译的时候就是编译成了一个类。
            ////并且这个类继承自 MulticastDelegate,并且这个类又继承自Delegate，所以说Delegate是所有委托的祖宗类
            #endregion

            #region MyRegion

            ////带2个参数，带1个返回值的委托

            //Delegate3 md = Add;
            //int n = md(10, 20);
            //Console.WriteLine(n);
            //Console.Read();


            #endregion


            #region 匿名方法与lambda表达式λ

            //匿名方法

            //无参数无返回值的写法
            //Delegate1 md = delegate()
            //{
            //    Console.WriteLine("我是一个匿名方法！！");
            //};
            //md();


            ////lambda
            //Delegate1 md = () => { Console.WriteLine("我就是一个匿名函数"); };
            //md();
            //Console.Read();



            //有一个参数，有一个返回值的写法

            //Delegate4 md = M2;
            //int x= md(10);
            //Console.WriteLine(x);

            //Delegate4 md = delegate(int c)
            //{
            //    return c * 2;
            //};
            //int x = md(10);
            //Console.WriteLine(x);

            //() => { };

            ////lambda
            //Delegate4 md = x => x * 2;   //(x) => { return x * 2; };
            //int result = md(10);
            //Console.WriteLine(result);
            //Console.Read();



            ////带两个参数，带一个返回值的委托的写法
            //Delegate3 md = delegate(int n, int m)
            //{
            //    return n + m;
            //};
            //int result = md(100, 200);
            //Console.WriteLine(result);

            //Delegate3 md = (x, y) => x + y;
            //int r = md(100, 200);
            //Console.WriteLine(r);
            //Console.Read();


            //Console.Read();

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var item in list.Where(CheckIsGreaterThan5))//list.Where(x => x > 5))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.Read();

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           







            #endregion

        }

        static bool CheckIsGreaterThan5(int x)
        {
            return x > 5;
        }

        static int M2(int n)
        {
            return n * 2;
        }

        static void M1()
        {
            Console.WriteLine("M1方法");
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //要保存这个方法我们可以再写一个委托来实现。
        static int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

    }
    //有一个参数有一个返回值的委托
    public delegate int Delegate4(int n);
    public delegate void Delegate1();

    public delegate void Delegate2(int n);

    public delegate int Delegate3(int n, int m);
}
