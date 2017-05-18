using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FileSystem.DAL.Implement
{
    public class RoleFunctionService : BaseService<Role_Function>, IRoleFunction
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("ACL_Role_Function",null);
        public bool AddRoleFunction(Role_Function rf)
        {
            int i = Insert(rf);
            return i > 0;
        }

        public bool DeleteRoleFunction(int rid,int pid)
        {
            return Delete("RoleID=@RID AND FunctionID=@PID",
                new SqlParameter("@RID",rid),
                new SqlParameter ("PID",pid)
               
                );
        }
    }
}
