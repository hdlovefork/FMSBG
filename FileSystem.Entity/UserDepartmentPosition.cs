using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.Entity
{
    public class UserDepartmentPosition: BaseEntity
    {
        public int UserID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public UserDepartmentPosition()
        {

        }



        public UserDepartmentPosition (int uid,int did,int pid)
        {
            UserID = uid;
            DepartmentID = did;
            PositionID = pid;
        }

    }
}

