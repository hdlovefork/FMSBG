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
            this.tool_OU = new System.Windows.Forms.ToolStripButton();
            this.tool_Role = new System.Windows.Forms.ToolStripButton();
            this.tool_Function = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Quit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolMain
            // 
            this.toolMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_User,
            this.tool_OU,
            this.tool_Role,
            this.tool_Function,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.tool_Quit});
            this.toolMain.Location = new System.Drawing.Point(0, 0);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(773, 39);
            this.toolMain.TabIndex = 8;
            this.toolMain.Text = "toolStrip1";
            // 
            // tool_User
            // 
            this.tool_User.Image = ((System.Drawing.Image)(resources.GetObject("tool_User.Image")));
            this.tool_User.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tool_User.Name = "tool_User";
            this.tool_User.Size = new System.Drawing.Size(92, 36);
            this.tool_User.Text = "用户管理";
            // 
            // tool_OU
            // 
            this.tool_OU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_OU.Name = "tool_OU";
            this.tool_OU.Size = new System.Drawing.Size(84, 36);
            this.tool_OU.Text = "组织机构管理";
            // 
            // tool_Role
            // 
            this.tool_Role.ImageTransparentColor = System.Drawing.Color.White;
            this.tool_Role.Name = "tool_Role";
            this.tool_Role.Size = new System.Drawing.Size(60, 36);
            this.tool_Role.Text = "角色管理";
            // 
            // tool_Function
            // 
            this.tool_Function.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Function.Name = "tool_Function";
            this.tool_Function.Size = new System.Drawing.Size(60, 36);
            this.tool_Function.Text = "功能管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tool_Quit
            // 
            this.tool_Quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Quit.Name = "tool_Quit";
            this.tool_Quit.Size = new System.Drawing.Size(60, 36);
            this.tool_Quit.Text = "退出系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentUser,
            this.tssLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(232, 17);
            this.lblCurrentUser.Text = "                                                        ";
            // 
            // tssLink
            // 
            this.tssLink.IsLink = true;
            this.tssLink.Name = "tssLink";
            this.tssLink.RightToLeftAutoMirrorImage = true;
            this.tssLink.Size = new System.Drawing.Size(526, 17);
            this.tssLink.Spring = true;
            this.tssLink.Text = "版权所有:城建智能建筑学院";
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
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(773, 485);
            this.dockPanel.TabIndex = 18;
            this.dockPanel.ActiveContentChanged += new System.EventHandler(this.dockPanel_ActiveContentChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 36);
            this.toolStripButton2.Text = "修改密码";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 36);
            this.toolStripButton4.Text = "关于我们";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 546);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
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
        private System.Windows.Forms.ToolStripButton tool_OU;
        private System.Windows.Forms.ToolStripButton tool_Role;
        private System.Windows.Forms.ToolStripButton tool_Function;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_Quit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel tssLink;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}