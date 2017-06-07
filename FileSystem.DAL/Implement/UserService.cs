/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-11 16:08:21 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FileSystem.Entity;
using System.Data.SqlClient;
using System.Data.Common;

namespace FileSystem.DAL
{
    /// <summary>
    /// 用户管理实现类，实现对用户增删改查及后台权限修改
    /// 所有和数据层打交道的类都继承自BaseService，因为它帮我们实现了很多复杂的功能
    /// 我们只要调用它里面的一些方法就行，甚至不需要写SQL语句，建议同学们看看BaseService
    /// 里面是怎么实现的
    /// </summary>
    public class UserService : BaseService<User>, IUserService
    {
        /// <summary>
        /// 这是BaseService为我们留的一个坑，需要我们来填坑（返回一个实现IQueryInfo的接口）
        /// 但挖坑者为我们准备了一些石子(BaseQueryInfo)我们只要
        /// 稍微动下铲子就行了——new BaseQueryInfo("表名")
        ///  LAMBDA（拉姆达表达式）写法更简便哦下面一行搞掂：
        ///  public override IQueryInfo QueryInfo => new BaseQueryInfo("User");
        /// </summary>
        public override IQueryInfo QueryInfo
        {
            //告诉BaseService我要搜索User表

            get { return new BaseQueryInfo("User",
                    new Relationship[]
                    {
                        new Relationship("ACL_File_User"),
                        new Relationship("ACL_User_Role"),
                        new Relationship("User_Department_Position"),
                        new Relationship("File_User_Notice","ToUserID"),
                        new Relationship("File_User_Notice","FromUserID"),
                        new Relationship("Comment"),
                    }
                );
            }
        }

        public User GetUserByUserName(string name)
        {
            return FindSingle("UserName=@UserName", new SqlParameter("@UserName", name));
        }

        public bool DeleteUser(int userID)
        {

            return DeleteByKey(userID.ToString ());
        }

        public List<DepartmentPosition> GetDepartmentByUID(int uid)
        {
            return Find<DepartmentPosition>(new BaseQueryInfo("View_User_Department_Position",null), "UserID=@UserID", new SqlParameter("@UserID", uid));
        }

        public IList<Role> GetRolesByID(int userID)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string userName, string pwd)
        {
            return FindSingle("UserName=@UserName AND UserPassword=@UserPassword",
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@UserPassword", pwd)
                );
        }

        public List<User> GetUsersByRID(int rid)
        {
            return Find(new BaseQueryInfo("View_User_Role",null), "RoleID=@RoleID",
                  new SqlParameter("@RoleID", rid)
                );
        }

        public List<User> GetUsers()
        {
            return Find(string.Empty);
        }

        public bool InsertUser(User user)
        {
            try
            {
                ///1.添加用户
                int uid = Insert(user);
                if (uid > 0)
                {
                    //2.添加文件（1.我的文档，2.我的图片）PID=-1
                    File file = new File();
                    file.FilePID = -1;
                    file.FileSize = 0;
                    file.UserID = uid;
                    file.FileName = "我的文档";
                    int fid1 = InsertFile(file);
                    file.FileName = "我的图片";
                    int fid2 = InsertFile(file);
                }
                return uid > 0 ;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int InsertFile(File file)
        {
            string sql = string.Format("INSERT INTO [{0}] (FilePID,FileSize,FileName,UserID) VALUES(@FilePID,@FileSize,@FileName,@UserID);SELECT @@IDENTITY", "File");
            List<DbParameter> pList = new List<DbParameter>();
            pList.Add(new SqlParameter("@FilePID", file.FilePID));
            pList.Add(new SqlParameter("@FileSize", file.FileSize));
            pList.Add(new SqlParameter("@FileName", file.FileName));
            pList.Add(new SqlParameter("@UserID", file.UserID));

            object o = _db.ExecuteScalar(sql, pList);
            if (o is DBNull) return -1;
            if (o == null) return -1;
            return Convert.ToInt32(o);
        }


        public bool InsertFile_User(int uid, int fid)
        {
            string sql = string.Format("INSERT INTO {0} (FileID,UserID) VALUES(@FileID,@UserID)", "ACL_File_User");
            List<DbParameter> pList = new List<DbParameter>();
            pList.Add(new SqlParameter("@FileID", fid));
            pList.Add(new SqlParameter("@UserID", uid));
            return _db.ExecuteNonQuery(sql, pList) > 0;
        }

        public List<User> GetUsersByDepIDAndPosID(int depID, int posID)
        {
            return Find(new BaseQueryInfo ("View_User_Department_Position",null), "DepartmentID=@DID AND PositionID=@PID",
                new SqlParameter("@DID", depID),
                new SqlParameter("@PID", posID)
                );
        }

        public List<User> GetUsersByDepID(int depID)
        {
            return Find(new BaseQueryInfo("View_User_Department_Position", null),"DepartmentID=@DepartmentID", new SqlParameter("@DepartmentID", depID));
        }

        public bool UpdateUser(User user)
        {
            return Update(user);
        }
    }
}
