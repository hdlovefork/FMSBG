using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.DAL
{
   public  interface IRoleFunction : IService
    {
        bool AddRoleFunction(Role_Function rf);
    }
}
