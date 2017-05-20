using HD.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.DAL
{
   public  interface IUserDepartmentPosition: IService
    {
        bool AddUserDepPs(UserDepartmentPosition udp);
        bool DeleteUserDepPs(UserDepartmentPosition udp);
    }
}
