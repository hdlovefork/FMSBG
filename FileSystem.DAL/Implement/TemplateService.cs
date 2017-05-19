/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-19 8:58:46 
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
using System.Linq;
using System.Text;
using FileSystem.Entity;
using System.Data.SqlClient;
using System.Data.Common;

namespace FileSystem.DAL
{
    public class TempleteService : BaseService<DocTemplete>,ITempleteService
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("DOC_Templete","TempleteID",null);

        public IList<DocTemplete> GetTempleteByType(DocType type)
        {
            return Find("TempleteType=@TempleteType", new SqlParameter("@TempleteType", (int)type));
        }

        public bool InsertTemplete(DocTemplete temp)
        {
            string sql = string.Format("INSERT INTO {0}  (TempleteName,TempleteType,TempleteExt,TempleteData) VALUES (@TempleteName,@TempleteType,@TempleteExt,@TempleteData)", QueryInfo.TableName);
            return _db.ExecuteNonQuery(sql, new DbParameter[] {
                 new SqlParameter("@TempleteName",temp.TempleteName),
                 new SqlParameter("@TempleteType",temp.TempleteType),
                 new SqlParameter("@TempleteExt",temp.TempleteExt),
                 new SqlParameter("@TempleteData",temp.TempleteData),
            }) > 0;
        }
    }
}
