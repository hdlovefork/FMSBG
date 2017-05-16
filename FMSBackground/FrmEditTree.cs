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
    public partial class FrmEditTree : Form
    {
        FunctionLogic _funLogic = new FunctionLogic();
        List <Role_Function > _seleFunction = null;
        RoleFunctionLogic _roleFunction = new RoleFunctionLogic();
        int _rid = 0;
        public FrmEditTree()
        {
            
            InitializeComponent();

        }
       

            private void FrmEditTree_Load(object sender, EventArgs e)
        {
            InitFunctionTree();//初始化左边的功能树状结构

        }

        private void InitFunctionTree()
        {
            Function f = _funLogic.GetFunctions(-1)[0];
            TreeNode root = tvFunctionTree .Nodes.Add(f.FunctionID.ToString(), f.FunctionName);
            AddChildNode(root, f.FunctionID);
            tvFunctionTree.ExpandAll();
        }
        private void AddChildNode(TreeNode pNode, int pid)
        {
            List<Function> childList = _funLogic.GetFunctions(pid);
            foreach (var f in childList)
            {
                TreeNode childNode = new TreeNode(f.FunctionName);
                childNode.Name = f.FunctionID.ToString();
                childNode.Tag = f;
                pNode.Nodes.Add(childNode);
                AddChildNode(childNode, f.FunctionID);   
            }
        }

        private void chksele_CheckedChanged(object sender, EventArgs e)
        {
            setChildNodeCheckedState(tvFunctionTree.Nodes[0], chksele.Checked);
        }
        public void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            currNode.Checked = state;
            foreach (TreeNode n in currNode.Nodes)
            {
                setChildNodeCheckedState(n, state);
            }
            
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvFunctionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            Function f =e.Node .Tag as Function ;
            
            Role_Function rf = new Role_Function();
            rf.FunctionID = f.FunctionID;
            rf.RoleID = _rid;
            _seleFunction.Add(rf);
            //_roleFunction.AddRoleFunction(_seleFunction);
        }
    }
}
