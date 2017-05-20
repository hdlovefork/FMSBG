namespace FMSBackground
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.tool_User = new System.Windows.Forms.ToolStripButton();
            this.tool_Dep = new System.Windows.Forms.ToolStripButton();
            this.tool_Role = new System.Windows.Forms.ToolStripButton();
            this.tool_Function = new System.Windows.Forms.ToolStripButton();
            this.tool_Template = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Quit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.tool_pwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_about = new System.Windows.Forms.ToolStripButton();
            this.toolMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMain
            // 
            this.toolMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_User,
            this.tool_Dep,
            this.tool_Role,
            this.tool_Function,
            this.tool_Template,
            this.toolStripSeparator2,
            this.tool_pwd,
            this.tool_about,
            this.toolStripSplitButton1,
            this.tool_Quit});
            this.toolMain.Location = new System.Drawing.Point(0, 0);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1615, 39);
            this.toolMain.TabIndex = 8;
            this.toolMain.Text = "toolStrip1";
            // 
            // tool_User
            // 
            this.tool_User.Image = ((System.Drawing.Image)(resources.GetObject("tool_User.Image")));
            this.tool_User.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tool_User.Name = "tool_User";
            this.tool_User.Size = new System.Drawing.Size(105, 36);
            this.tool_User.Text = "用户管理";
            this.tool_User.Click += new System.EventHandler(this.tool_Button_Click);
            // 
            // tool_Dep
            // 
            this.tool_Dep.Image = ((System.Drawing.Image)(resources.GetObject("tool_Dep.Image")));
            this.tool_Dep.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_Dep.Name = "tool_Dep";
            this.tool_Dep.Size = new System.Drawing.Size(105, 36);
            this.tool_Dep.Text = "部门管理";
            this.tool_Dep.Click += new System.EventHandler(this.tool_Button_Click);
            // 
            // tool_Role
            // 
            this.tool_Role.Image = ((System.Drawing.Image)(resources.GetObject("tool_Role.Image")));
            this.tool_Role.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_Role.Name = "tool_Role";
            this.tool_Role.Size = new System.Drawing.Size(105, 36);
            this.tool_Role.Text = "角色管理";
            this.tool_Role.Click += new System.EventHandler(this.tool_Button_Click);
            // 
            // tool_Function
            // 
            this.tool_Function.Image = ((System.Drawing.Image)(resources.GetObject("tool_Function.Image")));
            this.tool_Function.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_Function.Name = "tool_Function";
            this.tool_Function.Size = new System.Drawing.Size(105, 36);
            this.tool_Function.Text = "功能管理";
            this.tool_Function.Click += new System.EventHandler(this.tool_Button_Click);
            // 
            // tool_Template
            // 
            this.tool_Template.Image = ((System.Drawing.Image)(resources.GetObject("tool_Template.Image")));
            this.tool_Template.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Template.Name = "tool_Template";
            this.tool_Template.Size = new System.Drawing.Size(109, 36);
            this.tool_Template.Text = " 模板管理";
            this.tool_Template.Click += new System.EventHandler(this.tool_Button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tool_Quit
            // 
            this.tool_Quit.Image = ((System.Drawing.Image)(resources.GetObject("tool_Quit.Image")));
            this.tool_Quit.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_Quit.Name = "tool_Quit";
            this.tool_Quit.Size = new System.Drawing.Size(105, 36);
            this.tool_Quit.Text = "退出系统";
            this.tool_Quit.Click += new System.EventHandler(this.tool_Quit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentUser,
            this.tssLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 883);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1615, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(233, 20);
            this.lblCurrentUser.Text = "                                                        ";
            // 
            // tssLink
            // 
            this.tssLink.IsLink = true;
            this.tssLink.Name = "tssLink";
            this.tssLink.RightToLeftAutoMirrorImage = true;
            this.tssLink.Size = new System.Drawing.Size(1362, 20);
            this.tssLink.Spring = true;
            this.tssLink.Text = "版权所有：BlueSky项目开发团队";
            this.tssLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.DefaultFloatWindowSize = new System.Drawing.Size(150, 150);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 39);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(1615, 844);
            this.dockPanel.TabIndex = 18;
            // 
            // tool_pwd
            // 
            this.tool_pwd.Image = ((System.Drawing.Image)(resources.GetObject("tool_pwd.Image")));
            this.tool_pwd.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_pwd.Name = "tool_pwd";
            this.tool_pwd.Size = new System.Drawing.Size(109, 36);
            this.tool_pwd.Text = " 修改密码";
            this.tool_pwd.Click += new System.EventHandler(this.tool_pwd_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 39);
            // 
            // tool_about
            // 
            this.tool_about.Image = ((System.Drawing.Image)(resources.GetObject("tool_about.Image")));
            this.tool_about.ImageTransparentColor = System.Drawing.Color.Black;
            this.tool_about.Name = "tool_about";
            this.tool_about.Size = new System.Drawing.Size(109, 36);
            this.tool_about.Text = " 关于我们";
            this.tool_about.Click += new System.EventHandler(this.tool_about_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 908);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "BlueSky文件管理系统";
            this.Text = "BlueSky文件管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton tool_User;
        private System.Windows.Forms.ToolStripButton tool_Dep;
        private System.Windows.Forms.ToolStripButton tool_Role;
        private System.Windows.Forms.ToolStripButton tool_Function;
        private System.Windows.Forms.ToolStripButton tool_Quit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel tssLink;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripButton tool_Template;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tool_pwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton tool_about;
    }
}