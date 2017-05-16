/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-16 20:36:48 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.DAL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FileSystem.Service
{
    public class FileAccessService : BaseService<File>, IFileAccessService
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("View_File_User", null);

        public File GetFileByUID(int fileID)
        {
            return FindSingle("FileID=@FileID", new SqlParameter("@FileID", fileID));
        }
    }

}
