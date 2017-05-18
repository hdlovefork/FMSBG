using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileSystem.Entity;

namespace FileSystem.DAL
{
   public interface IUserRole : IService
    {
        bool AddRoleUser(UserRole ur);
    }
}
