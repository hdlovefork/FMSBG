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
    public partial class FrmUpUserPwd : BaseForm
    {
        string _name = null;
        string _pwd = null;
        UserLogic _userLogic = new UserLogic();
        public FrmUpUserPwd()
        {
           
            InitializeComponent();
        }

        private void FrmUpUserPwd_Load(object sender, EventArgs e)
        {
            //if (texOldPwd.Text != _pwd) return;
            //if (texNewPwd.Text  != texRealPwd.Text ) return;
            //User u = new User();
            //u.UserPassword = texNewPwd.Text;

            //bool ok = _userLogic.UpdetUserPwd(u);
            //if (ok) MessageBox.Show("密码修改成功");
            
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            if (texOldPwd.Text != GObj .CurrentUser.UserPassword ) return;
            if (texNewPwd.Text != texRealPwd.Text) return;
            if (texNewPwd.Text == string .Empty ) return;
            if (texRealPwd.Text == string.Empty) return;

            User u = GObj.CurrentUser;
            u.UserPassword = texNewPwd.Text;
            bool ok = _userLogic.UpdetUserPwd(u);
            if (ok) MessageBox.Show("密码修改成功");
            this.Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
