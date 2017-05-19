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
    public class TemplateService : BaseService<DocTemplate>,ITemplateService
    {
        public override IQueryInfo QueryInfo => new BaseQueryInfo("DOC_Template","TemplateID",null);

        public IList<DocTemplate> GetTemplateByType(DocType type)
        {
            return Find("TemplateType=@TemplateType", new SqlParameter("@TemplateType", (int)type));
        }

        public bool InsertTemplate(DocTemplate temp)
        {
            string sql = string.Format("INSERT INTO {0}  (TemplateName,TemplateType,TemplateExt,TemplateData) VALUES (@TemplateName,@TemplateType,@TemplateExt,@TemplateData)", QueryInfo.TableName);
            return _db.ExecuteNonQuery(sql, new DbParameter[] {
                 new SqlParameter("@TemplateName",temp.TemplateName),
                 new SqlParameter("@TemplateType",temp.TemplateType),
                 new SqlParameter("@TemplateExt",temp.TemplateExt),
                 new SqlParameter("@TemplateData",temp.TemplateData),
            }) > 0;
        }
    }
}
