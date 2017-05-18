/**************************************************************** 
 * 作    者：肖安辉
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
        TreeNode _selectedNode = null;
        bool _badd = false;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
            ///InitDepTree(); //初始化部下拉框
            ///InitPosTree(); //初始化岗位下拉框
            //InitDepartmentList();//初始化部门列表 
        }


        private void InitDepartmentList()
        {
            lstDepPos.Items.Clear();
            lstDepPos.Items.Add("人事部-经理");
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

            tvUser.ExpandAll();
            if (tvUser.Nodes.Count > 0)
            {
                _selectedNode = tvUser.Nodes[0];
                ShowSelectedUserDepartment(_selectedNode);
            }
        }

        private void tvUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowSelectedUserDepartment(e.Node);
        }

        private void ShowSelectedUserDepartment(TreeNode node)
        {
            User u = node.Tag as User;
            //ResetUserDetail();//清除上一个用户的信息
            if (u == null) return;
            _selectedNode = node;
            txtUserName.Text = u.UserName;
            txtPwd.Text = u.UserPassword;
            txtRealName.Text = u.UserRealName;
            txtMobile.Text = u.UserMobile;
            txtAddress.Text = u.UserAddress;
            chkUserEnable.Checked = u.UserEnable;
            rdoMale.Checked = (bool)(u.UserSex);
            _selectedNode = node;
            //右边显示
            lstDepPos.Items.Clear();
            List<DepartmentPosition> list = _userLogic.GetDepartmentUser(u.UserID);
            foreach (var dp in list)
            {
                lstDepPos.Items.Add(string.Format("{0} -> {1}", dp.DepartmentName, dp.PositionName));
            }
        }

        /// <summary>
        /// 将用户信息的各项文本清空，因为以免显示了一个用户的信息，比如手机号码
        /// </summary>
        private void ResetUserDetail()
        {

            txtUserName.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtRealName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_badd)
            {
                if (!CheckInputInfo()) return;
                if (!AddUser()) return;
                _badd = false;
            }
            else
            {

                UpdateUser();
            }
            gbDeatil.Enabled = false;//保存后加锁界面
            pnlAction.Enabled = true;//动作面板要启用
            txtUserName.Enabled = false;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        private bool AddUser()
        {
            User user = new User
            {
                //赋值
                UserName = txtUserName.Text,
                UserRealName = txtRealName.Text,
                UserPassword = txtPwd.Text,
                UserAddress = txtAddress.Text,
                UserMobile = txtMobile.Text,
                UserSex = rdoMale.Checked,
                UserEnable = chkUserEnable.Checked,
            };
            bool ok = _userLogic.AddUser(user);
            if (ok)
            {
                tvUser.Nodes.Clear();
                InitUserTree();           
            }
            return true;
        }

        /// <summary>
        /// 验证输入是否正确
        /// </summary>
        /// <returns></returns>
        private bool CheckInputInfo()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                lblError1.Text = "用户名不能为空";
                txtUserName.Focus();
                lblError1.Visible = true;
                return false;
            }
            lblError1.Visible = false;
            if (string.IsNullOrWhiteSpace(txtPwd.Text))
            {
                lblError2.Text = "密码不能为空";
                txtPwd.Focus();
                lblError2.Visible = true;
                return false;
            }
            lblError2.Visible = false;
            if (string.IsNullOrWhiteSpace(txtRealName.Text))
            {
                lblError3.Text = "请输入真实姓名";
                lblError3.Focus();
                lblError3.Visible = true;
                return false;
            }
            lblError3.Visible = false;
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                lblError4.Text = "请输入联系电话";
                lblError4.Focus();
                lblError4.Visible = true;
                return false;
            }
            lblError4.Visible = false;
            return true;
        }
        /// <summary>
        /// 编辑用户
        /// </summary>
        public void UpdateUser()
        {
            if (_selectedNode == null) return;
            User u = _selectedNode.Tag as User;
            if (u == null) return;

            u.UserName = txtUserName.Text;
            u.UserRealName = txtRealName.Text;
            u.UserPassword = txtPwd.Text;
            u.UserAddress = txtAddress.Text;
            u.UserMobile = txtMobile.Text;
            u.UserSex = rdoMale.Checked;
            u.UserEnable = chkUserEnable.Checked;
            bool ok = _userLogic.EditUser(u);
            if (ok)
            {
                ReloadTree();
            }
        }
        private void ReloadTree()
        {
            tvUser.Nodes.Clear();
            InitUserTree();
            tvUser.ExpandAll();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authBtnAdd_Click(object sender, Control.AuthEventArgs e)
        {

            _badd = true;
            ResetUserDetail();
            gbDeatil.Enabled = true;
            tvUser.Enabled = true;
            pnlAction.Enabled = false;
            txtUserName.Enabled = true;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authBtnDelete_Click(object sender, Control.AuthEventArgs e)
        {
            if (_selectedNode == null) return;
            User u = _selectedNode.Tag as User;
            if (u == null) return;

            bool ok = _userLogic.DeleteUser(u.UserID);
            if (ok)
            {
                tvUser.Nodes.Remove(_selectedNode);
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authBtnEdit_Click(object sender, Control.AuthEventArgs e)
        {
            gbDeatil.Enabled = true;
            pnlAction.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDeatil.Enabled = false;
            pnlAction.Enabled = true;
            txtUserName.Enabled = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void tvUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = tvUser.GetNodeAt(e.X, e.Y);
                if (tn != null)
                {
                    tvUser.SelectedNode = tn;
                }
            }
        }

        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



    }
}
