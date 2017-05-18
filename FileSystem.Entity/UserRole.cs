using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.Entity
{
   public  class UserRole:BaseEntity
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public UserRole (int uid,int rid)
        {
            UserID = uid;
            RoleID = rid;
        }
    }
}
