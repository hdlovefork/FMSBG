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
    public partial class IncludeUser : Form
    {
        private object _userLogic;

        public IncludeUser()
        {
            InitializeComponent();
        }
        //private void FrmUser_Load(object sender, EventArgs e)
        //{
        //    InitUserTree();//初始化用户树
        //}
        //private void InitUserTree()
        //{
        //    List<User> list = _userLogic.GetUsers();
        //    foreach (var u in list)
        //    {
        //        TreeNode node = new TreeNode(u.UserRealName);
        //        node.Name = u.UserID.ToString();
        //        node.Tag = u;
        //        tvUser.Nodes.Add(node);
        //    }

        //    tvUser.ExpandAll();
        //}
    }
}
