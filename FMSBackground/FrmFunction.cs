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

namespace FMSBackground
{
    public partial class FrmFunction : BaseForm
    {
        TreeNode _selectedNode = null;//保存最后一次点击的节点
        FunctionLogic _funLogic = new FunctionLogic();
        bool _bAdd = false;//当前是否正在添加Function

        public FrmFunction()
        {
            InitializeComponent();
        }

        private void FrmFunction_Load(object sender, EventArgs e)
        {
            InitFunctionTree();//初始化左边的功能树状结构
            InitFunctionList();//初始化下拉列表
        }

        private void InitFunctionList()
        {
            List<Function> list = _funLogic.GetFunctions();
            foreach (var f in list)
            {
                cboFunction.Items.Add(f);
            }
            if (cboFunction.Items.Count > 0)
                cboFunction.SelectedIndex = 0;
        }

        private void InitFunctionTree()
        {
            //获取所有PID为-1的，也就是顶级的菜单，如：XXX管理
            Function f = _funLogic.GetFunctions(-1)[0];
            TreeNode root = tvFunction.Nodes.Add(f.FunctionID.ToString(), f.FunctionName);
            AddChildNode(root, f.FunctionID);
            tvFunction.ExpandAll();
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
        private void tvFunction_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Function f = e.Node.Tag as Function;
            if (f == null) return;
            _selectedNode = e.Node;//保存当前选中的节点
            txtFunctionName.Text = f.FunctionName;
            txtFunctionControl.Text = f.FunctionControl;
            Function pf = _funLogic.GetParentFunctionByPID((int)f.FunctionPID);
            if (pf == null) return;
            cboFunction.Text = pf.FunctionName;
        }

        private void btnDelete_Click(object sender, AuthEventArgs e)
        {
          
                //有删除权限的情况，调用逻辑层真正删除
                if (_selectedNode == null) return;
                Function f = _selectedNode.Tag as Function;
                if (f == null) return;
                //从数据库删除这个FuncitonID=_selectedFunID的记录
                bool ok = _funLogic.DeleteFuncitonByID(f.FunctionID);
                if (ok)
                {
                    tvFunction.Nodes.Clear();//清除所有节点重新加载
                    InitFunctionTree();
                }
           
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_bAdd)
            {
                //执行添加操作，没有添加成功不作任何操作               
                if (!AddFunction()) return;
                _bAdd = false;//把添加状态改为更新状态
            }
            else
            {
                //执行更新操作
                UpdateFunction();
            }
            gbDetail.Enabled = false;//保存完了加锁界面/禁用界面
            pnlAction.Enabled = true;//动作面板要启用
            
        }

        private void UpdateFunction()
        {
            //判断有没有选中上级Function，如果没有选中直接返回
            if (_selectedNode == null) return;
            //得到上级Function
            Function f = _selectedNode.Tag as Function;
            if (f == null) return;
            //从下拉列表中的选中项中拿到上级FunctionID
            int? pid = (cboFunction.SelectedItem as Function).FunctionID;
            //修改左侧树中选中的Function属性
            f.FunctionName = txtFunctionName.Text;
            f.FunctionControl = txtFunctionControl.Text;
            f.FunctionPID = pid;
            if (_funLogic.EditFunction(f))
            {
                ReloadTree();
            }
        }
        //返回是否添加成功，没有添加成功不作任何操作
        private bool AddFunction()
        {
            #region 提高用户体验的代码
            string name = txtFunctionName.Text;
            if (string.IsNullOrWhiteSpace(name))//没有输入功能名称
            {
                lbFunctionName.Text  = "请输入功能名称";
                txtFunctionName.Focus();//让控件获得焦点
                return false;
            }
            lbFunctionName.Text = string.Empty;
            string control = txtFunctionControl.Text;
            if (string.IsNullOrWhiteSpace(control))
            {
                lbFunctionID  .Text = "请输入控件ID";
                txtFunctionControl.Focus();//让控件获得焦点
                return false;
            }
            lbFunctionID.Text = string.Empty; 

            #endregion
            int? pid = (cboFunction.SelectedItem as Function).FunctionID;
            Function f = new Function
            {
                FunctionName = txtFunctionName.Text,
                FunctionControl = txtFunctionControl.Text,
                FunctionPID = pid
            };
            bool ok = _funLogic.AddFunction(f);
            if (ok)//表示数据库成功添加了一条记录，才更新界面
            {
                ReloadTree();
            }
            return true;
        }

        private void ReloadTree()
        {
            tvFunction.Nodes.Clear();//清空所有节点
            InitFunctionTree();//初始化所有节点
            tvFunction.ExpandAll();//展开所有 节点
        }

        private void btnAdd_Click(object sender, AuthEventArgs e)
        {
            if (!e.OK) return;
            Debug.WriteLine("btnAdd_Click");
            if (!e.OK) return;
            _bAdd = true;
            txtFunctionControl.Text = string.Empty;
            txtFunctionName.Text = string.Empty;
            gbDetail.Enabled = true;//添加时解锁界面/启用界面
            pnlAction.Enabled = false;//禁用动作面板
        }

       

        private void authBtnEdit_Click(object sender, AuthEventArgs e)
        {
            gbDetail.Enabled = true;//编辑时解锁界面/启用界面
            pnlAction.Enabled = false;
        }

        private void authBtnDelete_Click(object sender, AuthEventArgs e)
        {


            gbDetail.Enabled = false;//取消时详情面板要禁用
            pnlAction.Enabled = true;//启用动作面板
            lblError.Text = string.Empty;
        }
        private void InitFunctiontList() {

        }


        //    }
        //    if (_selectedNode == null) return;
        //    Function f = _selectedNode.Tag as Function;
        //    if (f == null) return;
        //    //从数据库删除这个FuncitonID=_selectedFunID的记录
        //    bool ok = _funLogic.DeleteFuncitonByID(f.FunctionID);
        //    if (ok)
        //    {
        //        tvFunction.Nodes.Remove(_selectedNode);
        //        MessageBox.Show("删除成功");
        //    }
        //    else
        //    {
        //        MessageBox.Show("删除失败");

        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbDetail.Enabled = false;
            pnlAction.Enabled = true;
        }
    }
}
