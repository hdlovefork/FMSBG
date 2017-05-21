using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.Entity
{
    public class UserDepartmentPosition: BaseEntity
    {
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public UserDepartmentPosition()
        {

        }

        public UserDepartmentPosition(int uid,int did)
        {
            UserID = uid;
            DepartmentID = did;
        }


        public UserDepartmentPosition (int uid,int did,int pid)
            :this(uid,did)
        {
            PositionID = pid;
        }

    }
}

