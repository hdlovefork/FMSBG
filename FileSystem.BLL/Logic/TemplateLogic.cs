/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-19 9:03:02 
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HD.Tool;

namespace FileSystem.BLL
{
    public class TemplateLogic:BaseLogic<TemplateService>
    {
        public IList<DocTemplate> GetTemplateByType(DocType type)
        {
            return Service.GetTemplateByType(type);
        }

        public bool AddTemplate(string fileName, string fileExt, DocType word)
        {
            throw new NotImplementedException();
        }

        public bool AddTemplate(string path, DocType type)        {

            if (string.IsNullOrWhiteSpace(path)) return false;
            string fileName = path.Substring(path.LastIndexOf('\\')+1);
            string fileExt = fileName.Substring(fileName.LastIndexOf('.')+1);
            byte[] data= FileKit.GetFileData(path);
            DocTemplate t = new DocTemplate
            {
                TemplateName = fileName,
                TemplateExt = fileExt,
                TemplateData = data,
                TemplateType = (int)type
            };
            return Service.Insert(t) > 0;
        }
    }
}
