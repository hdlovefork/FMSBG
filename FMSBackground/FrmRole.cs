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
        string _name = null;
        RoleLogic _roleLogic = new RoleLogic();
        UserLogic _userLogic = new UserLogic();
        FunctionLogic _functionLogic = new FunctionLogic();
        public FrmRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            //_seleNode = r.RoleID ;
            listBox2.Items.Clear();
            SeleUser(r);//显示可编辑用户
            listBox1.Items.Clear();
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
            foreach (var f in list)
            {
                listBox1.Items.Add(f.FunctionName);
            }
        }

        private void SeleUser(Role r)
        {
            List<User> list = _userLogic.GetUsersByRID(r.RoleID);
            if (list == null) return;
            foreach (var u in list)
            {
                listBox2.Items.Add(u.UserRealName);    
            }
        }

        private void btsele_Click(object sender, EventArgs e)
        {
            FrmEditTree fet = new FrmEditTree();
            fet.Show();
        }
    }
}
