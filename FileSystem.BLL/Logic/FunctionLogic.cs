/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-12 14:10:45 
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
using System.Threading.Tasks;
using FileSystem.DAL;
using FileSystem.Entity;

namespace FileSystem.BLL
{
    public class FunctionLogic : BaseLogic<FunctionService>
    {
        public List<Function> GetFunctions(int pid)
        {
            return Service.GetFunctions(pid);
        }

        public List<Function> GetFunctions()
        {
            return Service.GetFunctions();
        }

        public Function GetParentFunctionByPID(int pid)
        {
            return Service.GetParentFunctionByPID(pid);
        }

        public bool DeleteFuncitonByID(int id)
        {
            if (id <= 0) return true;
            return Service.DeleteFunctionByID(id);
        }

        public bool AddFunction(Function f)
        {
            return Service.InsertFunction(f);
        }

        public bool EditFunction(Function f)
        {
            return Service.UpdateFunction(f);
        }
        public List <Function>GetRoleFunction(int rid)
        {
            return Service.GetRoleFunction(rid);
        }
    }
}
