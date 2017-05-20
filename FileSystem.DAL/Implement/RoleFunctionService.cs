using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.DAL
{
    public class RoleFunctionService : BaseService<Role_Function>, IRoleFunction
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("ACL_Role_Function",null);
        public bool AddRoleFunction(Role_Function rf)
        {
            int i = Insert(rf);
            return i > 0;
        }
    }
}
