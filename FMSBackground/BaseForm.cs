/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-11 14:13:04 
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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FMSBackground
{
    /// <summary>
    /// 这是所有窗体的基类（主窗体FrmMain不继承此类）
    /// 该类职责主要是统一应用程序图标
    /// </summary>
    public partial class BaseForm : DockContent
    {

        public BaseForm()
        {
            InitializeComponent();
        }

    }
}
