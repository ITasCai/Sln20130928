using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    public class Class1
    {



        /// <summary>
        /// 修改字符串数组中的每个元素的内容
        /// </summary>
        /// <param name="array"></param>
        public void ChangeStrings(string[] array, ModifyStringDelegate method)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = method(array[i]); //ModifyStringElement(array[i]);
            }
        }

        //private static string ModifyStringElement(string msg)
        //{
        //    return "★" + msg + "★";
        //}
    }
}
