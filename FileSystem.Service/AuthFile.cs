/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-16 20:35:17 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.Service
{
    public class AuthFile
    {
        /// <summary>
        /// 判断用户是否具有指定权限操作
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="fileID">文件ID</param>
        /// <param name="access">访问动作</param>
        /// <returns></returns>
        public bool Auth(int uid,int fileID,FileAccess access)
        {

            return true;
        }
    }
}
