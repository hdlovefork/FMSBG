using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.DAL
{
    public class UserRoleService : BaseService<UserRole>, IUserRole
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("ACL_User_Role", null);

        public bool AddRoleUser(UserRole ur)
        {
            
                int i = Insert(ur);
                return i > 0;
            
        }
    }
}
