using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.Entity

{
    public class Role_Function: BaseEntity
    {
        public int RoleID { get; set; } 
        public int FunctionID { get; set; }
        public Role_Function (int rid,int fid)
        {
            RoleID = rid;
            FunctionID = fid;
        }
    }
}
