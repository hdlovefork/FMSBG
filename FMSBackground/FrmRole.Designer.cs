namespace FMSBackground
{
    partial class FrmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRole));
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btse = new System.Windows.Forms.Button();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btsele = new System.Windows.Forms.Button();
            this.lstFunction = new System.Windows.Forms.ListBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvRole = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnEdit = new FMSBackground.Control.AuthButton();
            this.btnDelete = new FMSBackground.Control.AuthButton();
            this.btnAdd = new FMSBackground.Control.AuthButton();
            this.gbUser.SuspendLayout();
            this.gbFunction.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUser.Controls.Add(this.button4);
            this.gbUser.Controls.Add(this.btse);
            this.gbUser.Controls.Add(this.lstUser);
            this.gbUser.Enabled = false;
            this.gbUser.Location = new System.Drawing.Point(1032, 51);
            this.gbUser.Margin = new System.Windows.Forms.Padding(4);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(4);
            this.gbUser.Size = new System.Drawing.Size(276, 716);
            this.gbUser.TabIndex = 10;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "包含用户";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(149, 669);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 36);
            this.button4.TabIndex = 1;
            this.button4.Text = "移除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btup_Click);
            // 
            // btse
            // 
            this.btse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btse.Location = new System.Drawing.Point(26, 669);
            this.btse.Margin = new System.Windows.Forms.Padding(4);
            this.btse.Name = "btse";
            this.btse.Size = new System.Drawing.Size(100, 36);
            this.btse.TabIndex = 3;
            this.btse.Text = "添加";
            this.btse.UseVisualStyleBackColor = true;
            this.btse.Click += new System.EventHandler(this.btse_Click);
            // 
            // lstUser
            // 
            this.lstUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 15;
            this.lstUser.Location = new System.Drawing.Point(4, 18);
            this.lstUser.Margin = new System.Windows.Forms.Padding(4);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(267, 634);
            this.lstUser.TabIndex = 2;
            // 
            // gbFunction
            // 
            this.gbFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFunction.Controls.Add(this.btsele);
            this.gbFunction.Controls.Add(this.lstFunction);
            this.gbFunction.Enabled = false;
            this.gbFunction.Location = new System.Drawing.Point(355, 273);
            this.gbFunction.Margin = new System.Windows.Forms.Padding(4);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Padding = new System.Windows.Forms.Padding(4);
            this.gbFunction.Size = new System.Drawing.Size(669, 496);
            this.gbFunction.TabIndex = 11;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "可操作功能";
            // 
            // btsele
            // 
            this.btsele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btsele.Location = new System.Drawing.Point(552, 447);
            this.btsele.Margin = new System.Windows.Forms.Padding(4);
            this.btsele.Name = "btsele";
            this.btsele.Size = new System.Drawing.Size(100, 36);
            this.btsele.TabIndex = 0;
            this.btsele.Text = "编辑";
            this.btsele.UseVisualStyleBackColor = true;
            this.btsele.Click += new System.EventHandler(this.btsele_Click);
            // 
            // lstFunction
            // 
            this.lstFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFunction.FormattingEnabled = true;
            this.lstFunction.ItemHeight = 15;
            this.lstFunction.Location = new System.Drawing.Point(19, 22);
            this.lstFunction.Margin = new System.Windows.Forms.Padding(4);
            this.lstFunction.Name = "lstFunction";
            this.lstFunction.Size = new System.Drawing.Size(633, 409);
            this.lstFunction.TabIndex = 4;
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Controls.Add(this.lblError);
            this.gbDetail.Controls.Add(this.btnCancel);
            this.gbDetail.Controls.Add(this.btnSave);
            this.gbDetail.Controls.Add(this.txtNote);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Enabled = false;
            this.gbDetail.Location = new System.Drawing.Point(355, 51);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetail.Size = new System.Drawing.Size(669, 180);
            this.gbDetail.TabIndex = 12;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "角色详情信息";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(123, 51);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(233, 18);
            this.lblError.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(537, 135);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "放弃";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(436, 135);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(113, 72);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(495, 55);
            this.txtNote.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(113, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(495, 25);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvRole);
            this.groupBox1.Location = new System.Drawing.Point(16, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(325, 718);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色列表";
            // 
            // tvRole
            // 
            this.tvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRole.ImageIndex = 0;
            this.tvRole.ImageList = this.imageList1;
            this.tvRole.ItemHeight = 16;
            this.tvRole.Location = new System.Drawing.Point(4, 22);
            this.tvRole.Margin = new System.Windows.Forms.Padding(4);
            this.tvRole.Name = "tvRole";
            this.tvRole.SelectedImageIndex = 0;
            this.tvRole.Size = new System.Drawing.Size(317, 692);
            this.tvRole.TabIndex = 0;
            this.tvRole.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRole_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "small_role.bmp");
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnEdit);
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Location = new System.Drawing.Point(7, 0);
            this.pnlAction.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(333, 48);
            this.pnlAction.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 36);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Tag = "Role/Edit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new FMSBackground.Control.AuthEventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 36);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Tag = "Role/Delete";
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new FMSBackground.Control.AuthEventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Tag = "Role/Add";
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.btnAdd_Click);
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 788);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbFunction);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRole";
            this.TabText = "角色管理";
            this.Text = "角色管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.gbUser.ResumeLayout(false);
            this.gbFunction.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btse;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.Button btsele;
        private System.Windows.Forms.ListBox lstFunction;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlAction;
        private Control.AuthButton btnEdit;
        private Control.AuthButton btnDelete;
        private Control.AuthButton btnAdd;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ImageList imageList1;
    }
}