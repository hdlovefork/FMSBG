/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-12 13:44:29 
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
using System.Text;
using System.Threading.Tasks;
using FileSystem.Entity;

namespace FileSystem.BLL
{
    public class DepartmentLogic : BaseLogic<DepartmentService>
    {
        public List<Department> GetDepartments()
        {
            return Service.GetDepartments();
        }

        public List<Department> GetDepartmentsByUID(int uid)
        {
            return Service.GetDepartmentsByUID(uid);
        }

        //public List<Department> GetDepartment()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
