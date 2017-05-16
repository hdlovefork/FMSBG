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
        bool _bAdd = false;
        RoleLogic _rlLogic = new RoleLogic();
        TreeNode _selectedNode = null;//保存最后一次点击的节点

        Role _rlLigo = new Role();


        public FrmRole()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            InitRoleTree();//初始化左边的功能树状结构
            
            
        }
        public void InitRoleTree() {
            Role r = _rlLogic.GetRoles()[0];
            TreeNode root = tvRole.Nodes.Add(r.RoleID.ToString(), r.RoleName);
            AddSonNode(root, r.RoleID);
            tvRole.ExpandAll();
        }
        public void AddSonNode(TreeNode pNode,int uid)
        {
            List<Role> list = _rlLogic.GetRoles();

            foreach (var r in list)
            {
                TreeNode sonNode =new TreeNode(r.RoleName);
                sonNode.Tag = r;
                pNode.Nodes.Add(sonNode);
            }
        }

        private void tvRole_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Role rl = e.Node.Tag as Role;
            if (rl==null) return;
            _selectedNode = e.Node;//保存当前选中的节点
            txtName.Text = rl.RoleName;
        }


        public bool AddRole()
        {
            //判断用户是否输入角色名
            #region
            string name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                lblError.Text = "请输入名字！";
                txtName.Focus();
                return false;
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
            if (e.OK) return;
            _bAdd = true;
            txtName.Text = string.Empty;
            gbDetail.Enabled = true;
            pnlAction.Enabled = false;
            //1.构造一个实例
            //2.向数据库插入数据
            //3.清除所有节点
            //4.重新读取节点
        }


        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, AuthEventArgs e)
        {
            if (!e.OK)
            {

            }

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
                if (!AddRole())  return; 
                _bAdd = false;
                lblError.Text = string.Empty;
            }
            else
                UpDateRole();

            gbDetail.Enabled = false;
            pnlAction.Enabled = true;
        }

        public void UpDateRole() {
            if (_selectedNode == null) return;
            Role r = _selectedNode.Tag as Role;
            if (r == null) return;
            r.RoleName = txtName.Text;
            if (_rlLogic.EditRole(r))
            {
                tvRole.Nodes.Clear();//清空所有节点
                InitRoleTree();//初始化所有节点
                tvRole.ExpandAll();//展开所有节点
            }
        }
    }
}
