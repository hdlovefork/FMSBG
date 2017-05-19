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
    public partial class FrmIncludeUser : Form
    {
        UserLogic _userLogin = new UserLogic();
        int _depID;
        int _posID;
        List<int> _lis = new List<int>();

        public FrmIncludeUser(int departmentID, int positionID,List <int> lis)
        {
            InitializeComponent();
            _posID = positionID;
            _depID = departmentID;
            _lis = lis;
            Debug.WriteLine("{0} - {1}", departmentID, positionID);
        }


        private void FrmIncludeUser_Load_1(object sender, EventArgs e)
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
                    if(r==u.UserID)
                    {
                        node.Checked = true;
                    }
                }

            }
            tvindUser.ExpandAll();
        }

        private void chksele_CheckedChanged(object sender, EventArgs e)
        {
            setChildNodeChkState(tvindUser.Nodes[0], chksele.Checked);
           
        }
        public void setChildNodeChkState(TreeNode currNode, bool state)
        {
            currNode.Checked = state;
            foreach (TreeNode n in currNode.Nodes)
            {
                setChildNodeChkState(n, state);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    
