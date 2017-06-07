﻿/**************************************************************** 
 * 作    者：肖安辉
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-12 1:06:12 
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
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.BLL
{
    /// <summary>
    /// 与用户相关的逻辑类，告诉父类我要将父类的Service属性变成一个IUserService对象
    /// </summary>
    public class UserLogic : BaseLogic<UserService>
    {

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return Service.GetUsers();
        }

        /// <summary>
        /// 用户登录方法
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">返回错误提示字符串</param>
        /// <param name="user">返回用户名密码正确后返回的用户信息</param>
        /// <returns></returns>
        public bool Login(string userName, string pwd, out string msg, out User user)
        {
            msg = string.Empty;     //默认返回空字符串
            user = null;            //默认返回空用户
            //判断去掉空格(.Trim()方法去左右两边空格）后的用户名是否为空
            if (string.IsNullOrEmpty(userName.Trim()))
            {
                msg = "用户名不能为空";
                return false;
            }
            if (string.IsNullOrEmpty(pwd.Trim()))
            {
                msg = "密码不能为空";
                return false;
            }
            //IObservable<Int32> source = Observable.start

            //父类已经帮你把Service变成了UserService了，强大吧！
            //体会泛型编程的乐趣吧！
            user = Service.GetUser(userName, pwd);
            if (user == null)//用户名或密码不正确
            {
                msg = "用户名或密码不正确";
                return false;
            }
            //用戶权限判断，用户工厂方法创建一个AuthLogin的实例
            //然后调用实例的Auth方法进行权限认证

            bool ok = Factory.Create<AuthLogic>().Auth(user.UserID, GObj.SYSTEM_FUNCTION);
            if (!ok)
            {
                msg = "你没有登录后台的权限";
                return false;
            }
            return true;
        }
        public bool AddUser(User user)
        {           
            return Service.InsertUser(user);
        }
        public bool EditUser(User user)
        {
            return Service.UpdateUser(user);
        }

        public bool DeleteUser(int userid)
        {
            return Service.DeleteUser(userid);
        }
        public List<DepartmentPosition> GetDepartmentUser(int uid)
        {

            return Service.GetDepartmentByUID(uid);

        }

        public List<User> GetUsersByRID(int rid)
        {
            return Service.GetUsersByRID(rid);
        }
       
        public List<User> GetUsersByDepIDAndPosID(int depID, int posID)
        {
            return Service.GetUsersByDepIDAndPosID(depID, posID);
        }

        public List<User> GetUsersByDepID(int depID)
        {
            return Service.GetUsersByDepID(depID);
        }
    }
}
