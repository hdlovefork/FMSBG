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
    public partial class FrmEditUser : Form
    {
        List<int> _lis = new List<int>();
        UserRoleLogic _userRoleLogic = new UserRoleLogic();
        UserLogic _userLogin = new UserLogic();
        List<int> _uid = new List<int>();
        int _id = 0;
        public FrmEditUser(List <int> lis,int id)
        {
            InitializeComponent();
            _lis = lis;
            _id = id;
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            InitUserTree();//初始化用户树
        }
        private void InitUserTree()
        {
            TreeNode root = tvindUser.Nodes.Add("所有用户");
            AddChildNode(root);
        }
        private void AddChildNode(TreeNode pNode)
        {
            List<User> list = _userLogin.GetUsers();
            foreach (var u in list)
            {
                TreeNode node = pNode.Nodes.Add(u.UserRealName);
                foreach (int r in _lis)
                {
                    if (r == u.UserID)
                    {
                        node.Checked = true;
                    }
                }

            }
            tvindUser.ExpandAll();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSele_CheckedChanged(object sender, EventArgs e)
        {
            setChildNodeCheckedState(tvindUser .Nodes[0], chkSele.Checked);
        }
        public void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            currNode.Checked = state;
            foreach (TreeNode n in currNode.Nodes)
            {
                setChildNodeCheckedState(n, state);
            }

        }

        private void btYes_Click(object sender, EventArgs e)
        {
            foreach (var t in _uid)
            {
                UserRole  rf = new UserRole(_id,t);
                _userRoleLogic.AddUsrRole(rf);
            }
        }

        private void tvindUser_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            UserRole  f = e.Node.Tag as UserRole;
            if (e.Node .Checked)
            {
                _uid.Add(f.UserID );
            }
        }
    }
}
