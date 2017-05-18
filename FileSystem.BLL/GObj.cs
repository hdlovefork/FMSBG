/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-12 1:30:04 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.BLL
{
    /// <summary>
    /// 用于存储程序运行中一直需要使用的东西
    /// Global Object 的缩写
    /// </summary>
    public class GObj
    {
        /// <summary>
        /// 记录当前登录的用户
        /// </summary>
        public static User CurrentUser;

        /// <summary>
        /// 登录系统权限
        /// </summary>
        public const string SYSTEM_FUNCTION = "FMSBG";

        /// <summary>
        /// 用户管理权限
        /// </summary>
        public const string SYSTEM_FUNCTION_USER = "User";

        /// <summary>
        /// 角色管理权限
        /// </summary>
        public const string SYSTEM_FUNCTION_ROLE = "Role";

        /// <summary>
        /// 部门管理权限
        /// </summary>
        public const string SYSTEM_FUNCTION_DEPARTMENT = "Department";

        /// <summary>
        /// 功能菜单管理权限
        /// </summary>
        public const string SYSTEM_FUNCTION_FUNCTION = "Function";


        public const string SYSTEM_FUNCTION_TEMPLATE = "Template";

    }
}
