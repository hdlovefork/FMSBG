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
    public class DocTemplete:BaseEntity
    {
        public int TempleteID { get; set; }
        public string TempleteName { get; set; }
        public int TempleteType { get; set; }
        public string TempleteExt { get; set; }
        public byte[] TempleteData { get; set; }
    }

    public enum DocType
    {
        Word = 1,
        Excel = 2,
        PPT = 3,
    }
}
