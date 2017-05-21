using FileSystem.BLL;
using FileSystem.Entity;
using FMSBackground.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmRole : BaseForm
    {

        TreeNode _selectedNode = null;//保存最后一次点击的节点
        RoleLogic _roleLogic = new RoleLogic();
        UserLogic _userLogic = new UserLogic();
        FunctionLogic _functionLogic = new FunctionLogic();
        List<int> _curRoleFunctions = new List<int>();
        List<int> _lisUser = new List<int>();
        int _roleID = 0;
        Role _role = new Role();
        UserRoleLogic _userroleFunction = new UserRoleLogic();
        List<User> _deleteUser = new List<User>();
        List<int> _ruid = new List<int>();
        List<Role> _allRoles = null;

        bool _bAdd = false;
        RoleLogic _rlLogic = new RoleLogic();
        Role _rlLigo = new Role();


        public FrmRole()
        {
            InitializeComponent();
        }



        private void FrmRole_Load(object sender, EventArgs e)
        {
            InitRoleTree();//初始化左边的功能树状结构

        }

        private void InitRoleTree()
        {

            AddChildNode();

            tvRole.ExpandAll();
        }

        private void AddChildNode()
        {
            _allRoles = _roleLogic.GetRoles();
            foreach (var r in _allRoles)
            {
                TreeNode node = new TreeNode(r.RoleName);
                node.Tag = r;
                tvRole.Nodes.Add(node);
                node.Name = r.RoleID.ToString();
                //pNode.Nodes.Add(node);
            }
            if (tvRole.Nodes.Count > 0)
            {
                _selectedNode = tvRole.Nodes[0];
                ShowSelectedNode(_selectedNode);
            }
        }

        private void tvRole_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowSelectedNode(e.Node);
        }

        private void ShowSelectedNode(TreeNode node)
        {
            Role r = node.Tag as Role;
            if (r == null) return;
            _selectedNode = node;//保存当前选中的节点
            txtName.Text = r.RoleName;
            txtNote.Text = r.RoleDescription;

            _role = r;
            lstUser.Tag = r;
            //FrmEditTree fet = new FrmEditTree(r.RoleID);                                      //_seleNode = e.Node;
            SeleUser(r);//显示可编辑用户          
            SeleFunction(r);
            _roleID = r.RoleID;
        }

        public bool AddRole()
        {
            //判断用户是否输入角色名
            #region
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                lblError.Text = "角色名不能为空";
                lblError.Visible = true;
                txtName.Focus();
                return false;
            }
            foreach (var r in _allRoles)
            {
                if(r.RoleName == name)
                {
                    lblError.Text = "该角色名已存在";
                    lblError.Visible = true;
                    txtName.Focus();
                    return false;
                }
            }
            #endregion

            Role rl = new Role
            {
                RoleName = txtName.Text,
            };
            bool ok = _rlLogic.AddRole(rl);
            if (ok)
            {
                tvRole.Nodes.Clear();//清空所有节点
                InitRoleTree();//初始化所有节点
                tvRole.ExpandAll();//展开所有节点
            }
            return true;
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, AuthEventArgs e)
        {
            if (!e.OK) return;
            _bAdd = true;
            txtName.Text = string.Empty;
            txtNote.Text = string.Empty;
            gbDetail.Enabled = true;
            pnlAction.Enabled = false;
            gbUser.Enabled = true;
            gbFunction.Enabled = true;
        }

        /// <summary>
        /// 编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, AuthEventArgs e)
        {
            gbDetail.Enabled = true;
            pnlAction.Enabled = false;
            gbUser.Enabled = true;
            gbFunction.Enabled = true;
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, AuthEventArgs e)
        {
            if (_selectedNode == null) return;
            Role r = _selectedNode.Tag as Role;
            if (r == null) return;

            bool ok = _rlLogic.DeleteRoleByID(r.RoleID);
            if (ok)
                tvRole.Nodes.Remove(_selectedNode);

        }
        /// <summary>
        /// 放弃按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDetail.Enabled = false;
            pnlAction.Enabled = true;
            gbUser.Enabled = false;
            gbFunction.Enabled = false;
            lblError.Visible = false;

        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_bAdd)
            {
                if (!AddRole()) return;
                _bAdd = false;
            }
            else
            {
                if (!UpDateRole()) return;
            }
            gbDetail.Enabled = false;
            pnlAction.Enabled = true;
            gbUser.Enabled = false;
            gbFunction.Enabled = false;
            lblError.Visible = false;
        }

        public bool UpDateRole()
        {
            if (_selectedNode == null) return false;
            Role r = _selectedNode.Tag as Role;
            if (r == null) return false;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblError.Visible = true;
                return false;
            }
            r.RoleName = txtName.Text;
            r.RoleDescription = txtNote.Text;
            if (_rlLogic.EditRole(r))
            {
                tvRole.Nodes.Clear();//清空所有节点
                InitRoleTree();//初始化所有节点
                tvRole.ExpandAll();//展开所有节点
            }
            return true;
        }





        private void SeleFunction(Role r)
        {
            InitFunctionTree(r);
        }

        private void InitFunctionTree(Role r)
        {
            lstFunction.Items.Clear();
            List<Function> list = _functionLogic.GetRoleFunction(r.RoleID);
            if (list == null) return;
            _curRoleFunctions.Clear();
            foreach (var f in list)
            {
                lstFunction.Items.Add(f.FunctionName);
                _curRoleFunctions.Add(f.FunctionID);
            }

        }

        private void SeleUser(Role r)
        {
            lstUser.Items.Clear();
            List<User> list = _userLogic.GetUsersByRID(r.RoleID);
            if (list == null) return;
            _lisUser.Clear();
            foreach (var u in list)
            {
                lstUser.Items.Add(u);
                lstUser.Tag = u;
                _deleteUser.Add(u);
                _lisUser.Add(u.UserID);
            }
        }

        private void btsele_Click(object sender, EventArgs e)
        {
            FrmEditTree fet = new FrmEditTree(_curRoleFunctions, _roleID);
            if (fet.ShowDialog() == DialogResult.OK)
            {
                Role r = _selectedNode.Tag as Role;
                SeleFunction(r);
            }
        }

        private void btup_Click(object sender, EventArgs e)
        {
            User u = lstUser.SelectedItem as User;
            if (u == null) return;

            UserRole ur = new UserRole(u.UserID, _roleID);
            _userroleFunction.DeleteRoleUser(ur);
            lstUser.Items.Clear();

            SeleUser(_role);
        }

        private void btse_Click(object sender, EventArgs e)
        {
            FrmEditUser fdu = new FrmEditUser(_lisUser, _roleID);
            if (fdu.ShowDialog() == DialogResult.OK)
            {
                if (_selectedNode == null) return;
                Role r = _selectedNode.Tag as Role;
                SeleUser(r);
            }
        }
    }
}

