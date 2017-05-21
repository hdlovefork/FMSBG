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
    public partial class FrmEditTree : BaseForm
    {
        FunctionLogic _funLogic = new FunctionLogic();
        List<Role_Function> _seleFunction = new List<Role_Function>();
        RoleFunctionLogic _roleFunction = new RoleFunctionLogic();
        FrmRole _frm = new FrmRole();

        List<int> _curRoleFunctions = new List<int>();
        List<int> _preDeleteFunctions = new List<int>();
        List<int> _preAddFunctions = new List<int>();

        List<int> _fid = new List<int>();
        List<int> _deleFunction = new List<int>();
        bool _yes = true;
        int _rid = 0;
        List<Function> _lisfun = new List<Function>();
        List<Function> _delisfun = new List<Function>();
        public FrmEditTree(List<int> lis, int rid)
        {

            InitializeComponent();
            _curRoleFunctions = lis;
            _rid = rid;
        }


        private void FrmEditTree_Load(object sender, EventArgs e)
        {
            InitFunctionTree();//初始化左边的功能树状结构

        }

        private void InitFunctionTree()
        {
            List<Function> list = _funLogic.GetFunctions(-1);
            if (list.Count > 0)
            {
                Function f = list[0];
                TreeNode root = tvFunctionTree.Nodes.Add(f.FunctionID.ToString(), f.FunctionName);
                root.Tag = f;
                root.Checked = IsHoldFunction(f.FunctionID);
                //_lisfun.Add(f);
                AddChildNode(root, f.FunctionID);
                tvFunctionTree.ExpandAll();
            }
        }

        private bool IsHoldFunction(int fid)
        {
            foreach (var id in _curRoleFunctions)
            {
                if (id == fid)
                    return true;
            }
            return false;
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
                childNode.Checked = IsHoldFunction(f.FunctionID);
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
            DialogResult = DialogResult.Cancel;
        }

        private void tvFunctionTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectChildNodes(e.Node, e.Node.Checked);
            SelectParentNodes(e.Node);
            SelectSiblingNode(e.Node);
            //Function f = e.Node.Tag as Function;
            //if (f == null) return;
            //if (e.Node.Checked)
            //{
            //    _fid.Add(f.FunctionID);
            //    _yes = true;
            //}
            //if (!e.Node.Checked)
            //{
            //    _yes = false;
            //}


        }
        /// <summary>
        /// 兄弟节点没有选中一个的话，父节点也不能选中
        /// </summary>
        /// <param name="node"></param>
        private void SelectSiblingNode(TreeNode node)
        {
            if (node.Checked || node.Parent == null) return;
            TreeNode cur = node.Parent.FirstNode;
            if (cur == null) return;
            if (cur.Checked) return;
            while (cur.NextNode != null)
            {
                cur = cur.NextNode;
                if (cur.Checked) return;
            }
            node.Parent.Checked = false;
            SelectSiblingNode(node.Parent);
        }

        /// <summary>
        /// 子节点有一个选中的话，父节点必须选中
        /// </summary>
        /// <param name="node"></param>
        private void SelectParentNodes(TreeNode node)
        {
            if (node == null) return;
            if (node.Parent != null && node.Checked)
                node.Parent.Checked = true;
            SelectParentNodes(node.Parent);
        }

        /// <summary>
        /// 选中节点之后，选中节点的所有子节点
        /// </summary>
        /// <param name="currNode"></param>
        /// <param name="state"></param>
        private void SelectChildNodes(TreeNode currNode, bool state)
        {
            foreach (TreeNode tn in currNode.Nodes)
            {
                tn.Checked = state;
                SelectChildNodes(tn, state);
            }
        }

        private void ForeachNodes(TreeNode parentNode)
        {
            Function f = parentNode.Tag as Function;
            if (f != null)
            {
                if (parentNode.Checked)
                    AddToPreAddList(f);
                else
                    AddToPreDelList(f);
            }
            foreach (TreeNode node in parentNode.Nodes)
            {
                ForeachNodes(node);
            }
        }

        private void btYes_Click(object sender, EventArgs e)
        {

            //if (_yes)
            //{
            //    foreach (var f in _lisfun )
            //    {
            //        Role_Function rf = new Role_Function(_rid, f.FunctionID );
            //        _roleFunction.AddRoleFunction(rf);
            //    }

            //}
            //else {
            //    foreach (var f in _delisfun  )
            //    {
            //        Role_Function rf = new Role_Function(_rid, f.FunctionID );
            //        _roleFunction.DeleteRoleFunction(rf);
            //    }
            //}
            //_lisfun.Clear();
            //FrmRole fr = new FrmRole();
            TreeNode root = tvFunctionTree.Nodes.Count > 0 ? tvFunctionTree.Nodes[0] : null;
            if (root != null)
                ForeachNodes(root);
            Role_Function rf = new Role_Function();
            foreach (var fid in _preAddFunctions)
            {
                rf.FunctionID = fid;
                rf.RoleID = _rid;
                _roleFunction.AddRoleFunction(rf);
            }
            foreach (var fid in _preDeleteFunctions)
            {
                rf.FunctionID = fid;
                rf.RoleID = _rid;
                _roleFunction.DeleteRoleFunction(rf);
            }
            DialogResult = DialogResult.OK;
        }

        private void tvFunctionTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //Function f = e.Node.Tag as Function;
            //if (f == null) return;
            //if (e.Node.Checked)
            //{
            //    AddToPreAddList(f);
            //    if (e.Node.Parent == null) return;
            //    if (!e.Node.Parent.Checked)
            //        e.Node.Parent.Checked = true;
            //}
            //else
            //{
            //    AddToPreDelList(f);
            //}
            //if(e.Node .Checked)
            //{
            //    _delisfun.Remove(f);
            //    _lisfun.Add(f);
            //}
            //if(!e.Node .Checked)
            //{
            //    _delisfun.Add(f);
            //    _lisfun.Remove(f);
            //}


        }

        private void AddToPreDelList(Function f)
        {
            bool exist = false;
            foreach (var fid in _curRoleFunctions)
            {
                if (fid == f.FunctionID)
                {
                    exist = true;
                    break;
                }
            }
            if (exist)
            {
                _preAddFunctions.Remove(f.FunctionID);
                _preDeleteFunctions.Add(f.FunctionID);
            }
        }

        private void AddToPreAddList(Function f)
        {
            foreach (var fid in _curRoleFunctions)
            {
                if (fid == f.FunctionID)
                    return;
            }
            _preAddFunctions.Add(f.FunctionID);
            _preDeleteFunctions.Remove(f.FunctionID);
        }
    }
}
