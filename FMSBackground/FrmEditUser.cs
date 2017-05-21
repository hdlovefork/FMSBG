using FileSystem.BLL;
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FMSBackground
{
    public partial class FrmEditUser : BaseForm
    {
        List<int> _lis = new List<int>();
        UserRoleLogic _userRoleLogic = new UserRoleLogic();
        UserLogic _userLogin = new UserLogic();
        List<int> _uid = new List<int>();
        List<int> _deleUser = new List<int>();
        int _rid = 0;

        List<User> _lisuser = new List<User>();
        public FrmEditUser(List<int> lis, int rid)
        {
            InitializeComponent();
            _lis = lis;
            _rid = rid;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
        }
        private void InitUserTree()
        {
            List<User> list = _userLogin.GetUsers();
            foreach (var u in list)
            {
                TreeNode node = tvUsers.Nodes.Add(u.ToString());
                node.Tag = u;
                //去除当前已有的用户
                foreach (int r in _lis)
                {
                    if (r == u.UserID)
                    {
                        node.Remove();
                    }
                }

            }
            tvUsers.ExpandAll();
        }     

        private void btNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void chkSele_CheckedChanged(object sender, EventArgs e)
        {           
            foreach (TreeNode n in tvUsers.Nodes)
            {
                n.Checked = chkSele.Checked;
            }
        }      

        private void btYes_Click(object sender, EventArgs e)
        {
            List<User> selectedUsers = GetChildUsers();
            UserRole rf = new UserRole();
            foreach (var u in selectedUsers)
            {
                rf.UserID = u.UserID;
                rf.RoleID = _rid;
                _userRoleLogic.AddUsrRole(rf);
            }
            DialogResult = DialogResult.OK;

        }      

        private List<User> GetChildUsers()
        {
            List<User> users = new List<User>();
            foreach (TreeNode child in tvUsers.Nodes)
            {
                if (!child.Checked) continue;
                User u = child.Tag as User;
                if (u == null) continue;
                users.Add(u);
            }
            return users;
        }

        private void tvindUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //User f = e.Node.Tag as User;
            //if (f == null) return;
            //if (e.Node.Checked)
            //{
            //    _deleUser.Add(f.UserID);

            //}
        }

    }
}

