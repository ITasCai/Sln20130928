using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary2;

namespace Wt调用者2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            string[] names = new string[] {
            "John","Bob","Chris","Steve","Johnny"
            };
            c1.ChangeStrings(names, M2);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        static string M2(string msg)
        {
            return msg.ToUpper();
        }
    }
}
