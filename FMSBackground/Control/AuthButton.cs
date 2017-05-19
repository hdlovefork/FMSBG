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
    /// <summary>
    /// 认证按钮Click事件委托
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void AuthEventHandler(object sender, AuthEventArgs e);

    public class AuthButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            if (this.Tag == null) throw new Exception("请设置按钮的Tag属性，该属性为FunctionControl，表示一个用户操作");
            //Debug.WriteLine("OnClick ------{0}",this.Tag);
            //验证当前登录用户是否拥有指定的权限
            bool ok = Factory.Create<AuthLogic>().Auth(this.Tag.ToString());
            if (!ok)
            {
                MessageBox.Show("您没有该操作的权限！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Click(this, new AuthEventArgs { OK = true });
        }
        /// <summary>
        /// 重写Click点击按钮事件
        /// </summary>
        public new event AuthEventHandler Click;



}
    /// <summary>
    /// 是否通过认证的事件参数
    /// </summary>
    public class AuthEventArgs : EventArgs
    {
        /// <summary>
        /// 是否拥有按钮Tag属性指定的权限
        /// </summary>
        public bool OK { get; set; }

    }
}
