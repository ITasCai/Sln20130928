using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    //第一步：定义委托类型。
    //定义了一个委托类型。
    //这里就像是定义了一个Person类一样，将来要用的时候还得声明该类型的变量才能使用。
    public delegate void T1Delegate();


    public delegate void T2Delegate(int n);
}
