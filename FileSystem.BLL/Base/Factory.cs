/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-14 13:33:12 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FileSystem.BLL
{
    public class Factory
    {
        //这是一个静态的字段用于保存历史生成过的实例，便于下次构造时不需要再次反射，加速而已！
        private static Dictionary<string, object> _dict = new Dictionary<string, object>();

        /// <summary>
        /// 为你实例化一个具体的对象
        /// </summary>
        /// <typeparam name="T">要返回的具体对象</typeparam>
        /// <returns></returns>
        public static T Create<T>()
            where T:class,new()
        {
            T instance = null;//默认返回一个空instance
            string fullName = typeof(T).FullName;
            //判断上次是不是已经保存了这个对象，如果保存了直接取出
            if (_dict.ContainsKey(fullName))
            {
                //如果上面不判断是否包含这个key直接取值会引发异常，因为一旦之前没有保存过这里内部会异常，所以要先判断是否已经存在
                instance = _dict[fullName] as T;
            }
            else
            {               
                Assembly asm = Assembly.GetAssembly(typeof(T));//获取程序集
                if (asm != null)
                {                   
                    instance = asm.CreateInstance(typeof(T).FullName) as T;
                    _dict.Add(fullName, instance);
                }
                else
                {
                    string msg = string.Format("不能构造一个 {0} 的实例", typeof(T).Name);
                    throw new Exception(msg);//抛出异常
                }
            }
            return instance;
        }

    }
}
