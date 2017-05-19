using FileSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmMain : Form
    {
        FrmUser _frmUser = new FrmUser();
        FrmRole _frmRole = new FrmRole();
        FrmFunction _frmFun = new FrmFunction();
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _frmUser.Show(dockPanel);
            _frmRole.Show(dockPanel);
            _frmFun.Show(dockPanel);

            _frmUser.Show(dockPanel);
            //在底部状态栏显示当前登录的用户信息
            lblCurrentUser.Text = string.Format("当前管理员:{0}",GObj.CurrentUser.UserRealName);
        }

        private void dockPanel_ActiveContentChanged(object sender, EventArgs e)
        {

        }
    }
}
