using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileSystem.BLL;

namespace FMSBackground
{
    public partial class FrmIncludeUser : BaseForm
    {
        UserLogic _userLogin = new UserLogic();
        int _depID;
        int _posID;
        List<User> _usersInDep = new List<User>();
        List<User> _addUsers = new List<User>();
        UserDepartmentPositionLogic _userdepartmentposition = new UserDepartmentPositionLogic();

        public FrmIncludeUser(int departmentID, int positionID,List <User> lis)
        {
            InitializeComponent();
            _posID = positionID;
            _depID = departmentID;
            _usersInDep = lis;
            Debug.WriteLine("{0} - {1}", departmentID, positionID);
        }


        private void FrmIncludeUser_Load_1(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
        }
        private void InitUserTree()
        {
            List<User> list = _userLogin.GetUsers();
            list = list.Distinct().Except(_usersInDep, new UserComparer()).ToList();
            //List<User> list = _userLogin.GetUsers();
            foreach (var u in list)
            {
                TreeNode node = tvUsers.Nodes.Add(u.ToString());
                node.Tag = u;
                //pNode .Tag  =
                //foreach (int r in _lis)
                //{
                //    if (r == u.UserID)
                //    {
                //        node.Remove();

                //    }
                //}

            }
            tvUsers.ExpandAll();
        }

        private void chksele_CheckedChanged(object sender, EventArgs e)
        {
            foreach (TreeNode n in tvUsers.Nodes)
            {
                n.Checked = chkSelect.Checked;
            }
        }
      
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            GetSelectedUsers();
            foreach(var u in _addUsers)
            {
                UserDepartmentPosition rf = new UserDepartmentPosition(u.UserID,_depID ,_posID );
                _userdepartmentposition.AddUserDepartmentPosition(rf);
            }
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 获取选中的用户
        /// </summary>
        private void GetSelectedUsers()
        {
            foreach (TreeNode node in tvUsers.Nodes)
            {
                if (!node.Checked) continue;
                User u = node.Tag as User;
                if (u == null) continue;
                _addUsers.Add(u);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
        }

        //单击父节点，勾选父节点下的所有子节点
        private void tvindUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectTheParentNodeSelect(e.Node,e.Node.Checked);            
        }

        private void SelectTheParentNodeSelect(TreeNode currNode,bool state)
        {
            TreeNodeCollection node = currNode.Nodes;
            if (node.Count > 0)
            {
                foreach(TreeNode tn in node)
                {
                    tn.Checked = state;
                    SelectTheParentNodeSelect(tn, state);
                }
            }
        }

    }
}
    
