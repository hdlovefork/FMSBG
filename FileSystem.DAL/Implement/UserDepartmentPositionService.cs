using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FileSystem.DAL
{
    public class UserDepartmentPositionService : BaseService<UserDepartmentPosition>, IUserDepartmentPosition
    {
        public override IQueryInfo QueryInfo => new  BaseQueryInfo("User_Department_Position",null);

        public bool AddUserDepPs(UserDepartmentPosition udp)
        {
            int i = Insert(udp);
            return i > 0;
        }

       

        public bool DeleteUserDepPs(UserDepartmentPosition udp)
        {
            return Delete ("UserID=@UID AND DepartmentID =@DepID",
                new SqlParameter("@UID",udp .UserID ),
                new SqlParameter("@DepID", udp.DepartmentID )
                );
        }

        public List<User> GetExcludeUserByDepIDAndPosID(int depID,int posID)
        {
            List<User> users=  Find<User>(new BaseQueryInfo("View_User_Department_Position",null), "DepartmentID =@DepID AND PositionID=@PosID", 
                new SqlParameter("@DepID", depID),
                new SqlParameter("@PosID", posID)
                );
            return users;
        }
    }
}
