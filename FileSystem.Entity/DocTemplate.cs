/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-19 8:52:55 
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

namespace FileSystem.Entity
{
    public class DocTemplate:BaseEntity
    {
        public int TemplateID { get; set; }
        public string TemplateName { get; set; }
        public int TemplateType { get; set; }
        public string TemplateExt { get; set; }
        public byte[] TemplateData { get; set; }
    }

    public enum DocType
    {
        Word = 1,
        Excel = 2,
        PPT = 3,
    }
}
