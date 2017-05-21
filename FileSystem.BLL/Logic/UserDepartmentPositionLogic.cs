using FileSystem.DAL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.BLL
{
   public  class UserDepartmentPositionLogic: BaseLogic<UserDepartmentPositionService>
    {
        public bool AddUserDepartmentPosition(UserDepartmentPosition udp)
        {
            return Service.AddUserDepPs(udp);
        }

        public List<User> GetExcludeUserByDepIDAndPosID(int depID, int posID) {

            return Service.GetExcludeUserByDepIDAndPosID(depID, posID);
        }
        public bool DeleteUserDepPs(UserDepartmentPosition udp)
        {
            return Service.DeleteUserDepPs(udp);
        }
    }
}
