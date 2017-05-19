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
    public class TemplateLogic : BaseLogic<TempleteService>
    {
        public IList<DocTemplete> GetTemplateByType(DocType type)
        {
            return Service.GetTempleteByType(type);
        }

        public bool DeleteTemplete(int id)
        {
            return Service.DeleteByKey(id.ToString());
        }
      

        public bool AddTemplate(string path, out DocType type)
        {
            type = DocType.Word;
            if (string.IsNullOrWhiteSpace(path)) return false;
            if (!System.IO.File.Exists(path)) return false;
            string fileName = path.Substring(path.LastIndexOf('\\') + 1);
            string fileExt = fileName.Substring(fileName.LastIndexOf('.') + 1);
            switch (fileExt)
            {
                case "doc":
                case "docx":
                    type = DocType.Word;
                    break;
                case "ppt":
                case "pptx":
                    type = DocType.PPT;
                    break;
                case "xls":
                case "xlsx":
                    type = DocType.Excel;
                    break;
            }
            byte[] data = FileKit.GetFileData(path);
            DocTemplete t = new DocTemplete
            {
                TempleteName = fileName,
                TempleteExt = fileExt,
                TempleteData = data,
                TempleteType = (int)type
            };
            return Service.InsertTemplete(t);
        }
    }
}
