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
using FileSystem.BLL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FMSBackground
{
    public partial class FrmUser : BaseForm
    {
        UserLogic _userLogic = new UserLogic();
        DepartmentLogic _depLogic = new DepartmentLogic();

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
            InitDepTree(); //初始化部下拉框
            InitPosTree(); //初始化岗位下拉框
            InitDepartmentList();//初始化部门列表 
        }


        private void InitDepartmentList()
        {
            lstDepPos.Items.Clear();
            lstDepPos.Items.Add("人事部-经理");
            //List<Department> list = _depLogic.GetDepartments();
            //foreach (var d in list)
            //{
            //    TreeNode node = tvDepPos.Nodes.Add(d.DepartmentID.ToString(), d.DepartmentName);
            //    foreach (var p in d.Positions)
            //    {
            //        node.Nodes.Add(p.PositionID.ToString(), p.PositionName);
            //    }
            //}
        }

        private void InitPosTree()
        {
            //throw new NotImplementedException();
        }

        private void InitDepTree()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 初始化用户树显示所有用户
        /// </summary>
        private void InitUserTree()
        {
            List<User> list = _userLogic.GetUsers();
            foreach (var u in list)
            {
                TreeNode node = new TreeNode(u.UserRealName);
                node.Name = u.UserID.ToString();
                node.Tag = u;
                tvUser.Nodes.Add(node);
            }
        }

        private void tvUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            User u = e.Node.Tag as User;
            //ResetUserDetail();//清除上一个用户的信息
            if (u == null) return;
            txtUserName.Text = u.UserName;
            txtRealName.Text = u.UserRealName;
            txtMobile.Text = u.UserMobile;
            txtAddress.Text = u.UserAddress;
            chkUserEnable.Checked = u.UserEnable;
        }

        /// <summary>
        /// 将用户信息的各项文本清空，因为以免显示了一个用户的信息，比如手机号码
        /// </summary>
        private void ResetUserDetail()
        {
            txtUserName.Text = string.Empty;
            txtRealName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}
