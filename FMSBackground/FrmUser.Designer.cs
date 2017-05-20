﻿namespace FMSBackground
{
    partial class FrmUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.btnAdd = new FMSBackground.Control.AuthButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvUser = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbDeatil = new System.Windows.Forms.GroupBox();
            this.lblError4 = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkUserEnable = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDepPos = new System.Windows.Forms.ListBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnEdit = new FMSBackground.Control.AuthButton();
            this.authBtnDelete = new FMSBackground.Control.AuthButton();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbDeatil.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 49);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Tag = "User/Add";
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvUser);
            this.groupBox1.Location = new System.Drawing.Point(23, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 704);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户列表";
            // 
            // tvUser
            // 
            this.tvUser.ContextMenuStrip = this.contextMenuStrip1;
            this.tvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUser.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvUser.HideSelection = false;
            this.tvUser.ImageIndex = 0;
            this.tvUser.ImageList = this.imageList1;
            this.tvUser.Location = new System.Drawing.Point(4, 22);
            this.tvUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvUser.Name = "tvUser";
            this.tvUser.SelectedImageIndex = 0;
            this.tvUser.ShowNodeToolTips = true;
            this.tvUser.Size = new System.Drawing.Size(317, 678);
            this.tvUser.TabIndex = 0;
            this.tvUser.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvUser_NodeMouseClick);
            this.tvUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvUser_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除DToolStripMenuItem,
            this.添加AToolStripMenuItem,
            this.toolStripMenuItem1,
            this.编辑ToolStripMenuItem,
            this.刷新列表ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.删除DToolStripMenuItem.Text = "删除(D)";
            // 
            // 添加AToolStripMenuItem
            // 
            this.添加AToolStripMenuItem.Name = "添加AToolStripMenuItem";
            this.添加AToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.添加AToolStripMenuItem.Text = "添加(A)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.编辑ToolStripMenuItem.Text = "编辑(E)";
            // 
            // 刷新列表ToolStripMenuItem
            // 
            this.刷新列表ToolStripMenuItem.Name = "刷新列表ToolStripMenuItem";
            this.刷新列表ToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.刷新列表ToolStripMenuItem.Text = "刷新列表(U)";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "small_user.bmp");
            // 
            // gbDeatil
            // 
            this.gbDeatil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeatil.Controls.Add(this.lblError4);
            this.gbDeatil.Controls.Add(this.lblError3);
            this.gbDeatil.Controls.Add(this.lblError2);
            this.gbDeatil.Controls.Add(this.lblError1);
            this.gbDeatil.Controls.Add(this.rdoMale);
            this.gbDeatil.Controls.Add(this.rdoMan);
            this.gbDeatil.Controls.Add(this.btnCancel);
            this.gbDeatil.Controls.Add(this.txtUserName);
            this.gbDeatil.Controls.Add(this.btnSave);
            this.gbDeatil.Controls.Add(this.chkUserEnable);
            this.gbDeatil.Controls.Add(this.txtAddress);
            this.gbDeatil.Controls.Add(this.txtMobile);
            this.gbDeatil.Controls.Add(this.txtRealName);
            this.gbDeatil.Controls.Add(this.label12);
            this.gbDeatil.Controls.Add(this.label8);
            this.gbDeatil.Controls.Add(this.label5);
            this.gbDeatil.Controls.Add(this.txtPwd);
            this.gbDeatil.Controls.Add(this.label3);
            this.gbDeatil.Controls.Add(this.label2);
            this.gbDeatil.Controls.Add(this.label1);
            this.gbDeatil.Enabled = false;
            this.gbDeatil.Location = new System.Drawing.Point(357, 84);
            this.gbDeatil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbDeatil.Name = "gbDeatil";
            this.gbDeatil.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbDeatil.Size = new System.Drawing.Size(480, 704);
            this.gbDeatil.TabIndex = 8;
            this.gbDeatil.TabStop = false;
            this.gbDeatil.Text = "用户详细信息";
            // 
            // lblError4
            // 
            this.lblError4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError4.AutoSize = true;
            this.lblError4.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError4.ForeColor = System.Drawing.Color.Red;
            this.lblError4.Location = new System.Drawing.Point(191, 360);
            this.lblError4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(0, 14);
            this.lblError4.TabIndex = 19;
            this.lblError4.Visible = false;
            // 
            // lblError3
            // 
            this.lblError3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError3.AutoSize = true;
            this.lblError3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(191, 276);
            this.lblError3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(0, 14);
            this.lblError3.TabIndex = 18;
            this.lblError3.Visible = false;
            // 
            // lblError2
            // 
            this.lblError2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(191, 189);
            this.lblError2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 14);
            this.lblError2.TabIndex = 17;
            this.lblError2.Visible = false;
            // 
            // lblError1
            // 
            this.lblError1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(191, 61);
            this.lblError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 14);
            this.lblError1.TabIndex = 15;
            this.lblError1.Visible = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(299, 99);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 19);
            this.rdoMale.TabIndex = 16;
            this.rdoMale.Text = "女";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(213, 99);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(43, 19);
            this.rdoMan.TabIndex = 16;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(320, 656);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(188, 30);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(263, 25);
            this.txtUserName.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(151, 656);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkUserEnable
            // 
            this.chkUserEnable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUserEnable.AutoSize = true;
            this.chkUserEnable.Checked = true;
            this.chkUserEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserEnable.Location = new System.Drawing.Point(188, 597);
            this.chkUserEnable.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkUserEnable.Name = "chkUserEnable";
            this.chkUserEnable.Size = new System.Drawing.Size(89, 19);
            this.chkUserEnable.TabIndex = 12;
            this.chkUserEnable.Text = "允许登录";
            this.chkUserEnable.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(188, 408);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(264, 160);
            this.txtAddress.TabIndex = 11;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobile.Location = new System.Drawing.Point(189, 324);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(263, 25);
            this.txtMobile.TabIndex = 7;
            // 
            // txtRealName
            // 
            this.txtRealName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRealName.Location = new System.Drawing.Point(188, 239);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(263, 25);
            this.txtRealName.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "住  址：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "移动电话：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "真实姓名(*)：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.Location = new System.Drawing.Point(188, 152);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(263, 25);
            this.txtPwd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "密   码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "性   别：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名(*)：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstDepPos);
            this.groupBox3.Location = new System.Drawing.Point(852, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(275, 704);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 直属部门";
            // 
            // lstDepPos
            // 
            this.lstDepPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstDepPos.ItemHeight = 15;
            this.lstDepPos.Location = new System.Drawing.Point(3, 20);
            this.lstDepPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDepPos.Name = "lstDepPos";
            this.lstDepPos.Size = new System.Drawing.Size(269, 679);
            this.lstDepPos.TabIndex = 0;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnEdit);
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Controls.Add(this.authBtnDelete);
            this.pnlAction.Location = new System.Drawing.Point(23, 12);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(372, 56);
            this.pnlAction.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(249, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 49);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Tag = "User/Edit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnEdit_Click);
            // 
            // authBtnDelete
            // 
            this.authBtnDelete.Location = new System.Drawing.Point(125, 4);
            this.authBtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authBtnDelete.Name = "authBtnDelete";
            this.authBtnDelete.Size = new System.Drawing.Size(100, 49);
            this.authBtnDelete.TabIndex = 17;
            this.authBtnDelete.Tag = "User/Delete";
            this.authBtnDelete.Text = "删除";
            this.authBtnDelete.UseVisualStyleBackColor = true;
            this.authBtnDelete.Click += new FMSBackground.Control.AuthEventHandler(this.authBtnDelete_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 792);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDeatil);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmUser";
            this.TabText = " 用户管理";
            this.Text = " 用户管理";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbDeatil.ResumeLayout(false);
            this.gbDeatil.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvUser;
        private System.Windows.Forms.GroupBox gbDeatil;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkUserEnable;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lstDepPos;

        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCancel;
        private Control.AuthButton btnEdit;
        private Control.AuthButton btnAdd;
        private Control.AuthButton authBtnDelete;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError4;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表ToolStripMenuItem;

    }
}