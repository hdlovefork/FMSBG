using FileSystem.BLL;
using FileSystem.Entity;
using FMSBackground.Control;
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
    public partial class FrmDepartment : BaseForm
    {
        TreeNode _selectedNode = null;//保存最后一次点击的节点
        DepartmentLogic _depLogic = new DepartmentLogic();
        UserDepartmentPositionLogic _userDepartmentPs = new UserDepartmentPositionLogic();
        UserLogic _userLogic = new UserLogic();
        List<User> _usersInDep = new List<User>();
        bool _bAdd = false;
        int _did = 0;
        int _pid = 0;
        List<Department> _allDeps = null;

        public FrmDepartment()
        {
            InitializeComponent();
        }


        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            Debug.Print("FrmDepartment_Load");
            InitDepartmentTree();//初始化部门树
        }


        private void InitDepartmentTree()
        {
            //创建根节点
            TreeNode root = tvDep.Nodes.Add("部门管理");
            AddChildNode(root);
        }

        private void AddChildNode(TreeNode pNode)
        {
            _allDeps = _depLogic.GetDepartments();
            foreach (var d in _allDeps)
            {
                TreeNode node = new TreeNode(d.DepartmentName);
                node.Tag = d;
                node.Name = d.DepartmentID.ToString();
                pNode.Nodes.Add(node);
                foreach (var p in d.Positions)
                {
                    TreeNode child = new TreeNode(p.PositionName);
                    child.Tag = p;
                    child.Name = p.PositionID.ToString();
                    node.Nodes.Add(child);
                }
            }
            tvDep.ExpandAll();
        }



        private void tvDep_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowNodeInfo(e.Node);
        }

        private void ShowNodeInfo(TreeNode node)
        {
            _selectedNode = node;
            Department d = node.Tag as Department;
            if (d == null)
            {
                //gang wei
                if (node.Parent == null) return;
                d = node.Parent.Tag as Department;
                if (d == null) return;
                _did = d.DepartmentID;
                Position p = node.Tag as Position;
                if (p == null) return;
                _pid = p.PositionID;
                lstUsers.Items.Clear();
                ShowPositionUsers(d, p);
                //MessageBox .Show (d.DepartmentName + "-----" + p.PositionName);
            }
            else
            {
                //bu men               
                txtDepName.Text = d.DepartmentName;
                _did = d.DepartmentID;
                ShowDepartmentUsers(d);
            }
        }

        private void ShowDepartmentUsers(Department d)
        {
            if (d == null) return;
            lstUsers.Items.Clear();
            _usersInDep = _userLogic.GetUsersByDepID(d.DepartmentID);
            foreach (var u in _usersInDep)
            {
                lstUsers.Items.Add(u);
            }
        }

        private void ShowPositionUsers(Department d, Position p)
        {
            List<User> lis = _userLogic.GetUsersByDepIDAndPosID(d.DepartmentID, p.PositionID);
            foreach (var t in lis)
            {
                lstUsers.Items.Add(t);
            }
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
            txtDepName.Text = string.Empty;
            gbDetail.Enabled = true;//添加时解锁界面/启用界面
            pnlAction.Enabled = false;//禁用动作面板
        }
        private bool AddDepartment()
        {
            if (!CheckInput()) return false;
            Department d = new Department
            {
                DepartmentName = txtDepName.Text.Trim(),
            };
            bool ok = _depLogic.AddDepartment(d);
            if (ok)
            {
                ReloadTree();
            }
            return true;
        }

        private bool CheckInput()
        {
            string name = txtDepName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                lblError.Text = "部门名称不能为空";
                lblError.Visible = true;
                txtDepName.Focus();
                return false;
            }
            foreach (Department d in _allDeps)
            {
                if (d.DepartmentName == name)
                {
                    lblError.Text = "该部门已经存在";
                    lblError.Visible = true;
                    txtDepName.Focus();
                    return false;
                }
            }
            return true;
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
                if (!AddDepartment()) return;
                _bAdd = false;
            }
            else
            {
                if (!UpdateDepartment()) return;
            }
            gbDetail.Enabled = false;//保存完了加锁界面/禁用界面
            pnlAction.Enabled = true;//动作面板要启用
            txtDepName.Clear();
            lblError.Visible = false;
        }

        private bool UpdateDepartment()
        {
            if (!CheckInput()) return false;
            if (_selectedNode == null) return false;
            Department d = _selectedNode.Tag as Department;
            if (d == null) return false;
            d.DepartmentName = txtDepName.Text.Trim();
            if (_depLogic.EditDepartment(d))
            {
                ReloadTree();
            }
            return true;
        }

        private void btnDelete_Click(object sender, AuthEventArgs e)
        {
            if (_selectedNode == null) return;
            Department d = _selectedNode.Tag as Department;
            if (d == null) return;
            bool ok = _depLogic.DeleteDepartmentByID(d.DepartmentID);
            if (ok)
            {
                tvDep.Nodes.Remove(_selectedNode);
            }
            txtDepName.Clear();
        }
        private void ReloadTree()
        {
            tvDep.Nodes.Clear();//清空所有节点
            InitDepartmentTree();//初始化所有节点
            tvDep.ExpandAll();//展开所有 节点
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDetail.Enabled = false;//取消时详情面板要禁用
            pnlAction.Enabled = true;//启用动作面板
            lblError.Visible = false;
        }

        private void btnEdit_Click(object sender, AuthEventArgs e)
        {
            if (_selectedNode == null) return;
            Department d = _selectedNode.Tag as Department;
            if (d == null) return;
            gbDetail.Enabled = true;//编辑时解锁界面/启用界面
            pnlAction.Enabled = false;
        }



        private void btnEditUser_Click_1(object sender, EventArgs e)
        {
            if (_selectedNode == null) return;
            Position pos = _selectedNode.Tag as Position;
            if (pos == null) return;
            Department dep = _selectedNode.Parent.Tag as Department;
            if (dep == null) return;
            //获取当前部门下的用户
            _usersInDep = _userLogic.GetUsersByDepID(dep.DepartmentID);
            FrmIncludeUser frm = new FrmIncludeUser(dep.DepartmentID, pos.PositionID, _usersInDep);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowNodeInfo(_selectedNode);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            User u = lstUsers.SelectedItem as User;
            if (u == null) return;
            UserDepartmentPosition udp = new UserDepartmentPosition(u.UserID, _did);
            if (_userDepartmentPs.DeleteUserDepPs(udp))
            {
                //Department d = _selectedNode.Tag as Department;
                //if (d == null)
                //{
                //    d = _selectedNode.Parent.Tag as Department;
                //}
                //ShowDepartmentUsers(d);
                lstUsers.Items.Remove(u);
            }


        }
    }
}
