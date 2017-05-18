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
    public partial class FrmLogin : Form
    {

        UserLogic _userLogic = new UserLogic();

        public FrmLogin()
        {
            InitializeComponent();
        }

        //登录按钮点击后的事件，在设计视图双击按钮自动创建该事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;//用于提示用户的消息
            User user = null;
            if (_userLogic.Login(txtUserName.Text, txtUserPassword.Text, out msg, out user))
            {
                if (user.UserEnable)
                {
                    GObj.CurrentUser = user;//将当前用户保存到全局静态变量，因为很多地方需要使用
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("您的账号已冻结，请联系管理员！");
                }
            }
            else
            {
                MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //退出应用程序
            Application.Exit();
            //或者使用以下方式也可以退出，因为我们这里是一个对话框，
            //在Main方法中会收到DialogResult的返回值不是Yes则不会启动主窗体
            //DialogResult = DialogResult.No;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "xm";
            txtUserPassword.Text = "123";
        }

        
    }
}
