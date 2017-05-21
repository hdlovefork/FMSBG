using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileSystem.Entity;

namespace FileSystem.DAL
{
   public interface IUserRoleService : IService
    {
        bool AddRoleUser(UserRole ur);
        bool DeleteRoleUser(int rid, int uid);
    }
}
