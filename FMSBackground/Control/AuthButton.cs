/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-14 15:28:14 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.BLL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FMSBackground.Control
{
    public delegate void AuthEventHandler(object sender, AuthEventArgs e);

    public class AuthButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            //Debug.WriteLine("OnClick ------{0}",this.Tag);
            bool ok = Factory.Create<AuthLogic>().Auth(this.Tag.ToString());
            if (ok)
            {
                Click(this, new AuthEventArgs { OK = true });
            }
            else
            {
                Click(this, new AuthEventArgs { OK = false });
            }
        }
        public new event AuthEventHandler Click;
    }

    public class AuthEventArgs : EventArgs
    {
        /// <summary>
        /// 是否拥有按钮Tag属性指定的权限
        /// </summary>
        public bool OK { get; set; }

    }
}
