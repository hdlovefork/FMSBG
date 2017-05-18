using FileSystem.BLL;
using FileSystem.Entity;
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
       
        
        RoleLogic _roleLogic = new RoleLogic();
        UserLogic _userLogic = new UserLogic();
        FunctionLogic _functionLogic = new FunctionLogic();
        List<int > _lis = new List<int>();
        List<int> _lisUser = new List<int>();
        public FrmRole()
        {
            InitializeComponent();
        }

       

        private void FrmRole_Load(object sender, EventArgs e)
        {
            InitRoleTree();
            tvRole.ExpandAll();
        }

        private void InitRoleTree()
        {
            TreeNode root = tvRole.Nodes.Add("角色");
            AddChildNode(root);
        }

        private void AddChildNode(TreeNode pNode)
        {
            List<Role> list = _roleLogic.GetRoles();
            foreach (var r in list)
            {
                TreeNode node = new TreeNode(r.RoleName);
                node.Tag = r;
                node.Name = r.RoleID.ToString ();
                pNode.Nodes.Add(node);
            }
        }



   

        private void tvRole_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Role r = e.Node.Tag as Role;
            if (r == null) return;
            //FrmEditTree fet = new FrmEditTree(r.RoleID);                                      //_seleNode = e.Node;
            lisRole.Items.Clear();
            SeleUser(r);//显示可编辑用户
            lstFunction.Items.Clear();
            SeleFunction(r);
        }

        private void SeleFunction(Role r)
        {
            InitFunctionTree(r);
        }

        private void InitFunctionTree(Role r)
        {
            List<Function> list = _functionLogic.GetRoleFunction(r.RoleID);
            if (list == null) return;
            _lis.Clear();
            foreach (var f in list)
            {
                lstFunction.Items.Add(f.FunctionName);
                _lis.Add(f.FunctionID);
            }

        }

        private void SeleUser(Role r)
        {
            List<User> list = _userLogic.GetUsersByRID(r.RoleID);
            if (list == null) return;
            _lisUser.Clear();
            foreach (var u in list)
            {
                lisRole.Items.Add(u.UserRealName);
                _lisUser.Add(u.UserID);
            }
        }

        private void btsele_Click(object sender, EventArgs e)
        {
            FrmEditTree fet = new FrmEditTree(_lis);
            fet.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEditUser fdu = new FrmEditUser(_lisUser );
            fdu.ShowDialog();
        }
    }
}
