namespace FMSBackground
{
    partial class FrmIncludeUser
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
            this.icdgpUser = new System.Windows.Forms.GroupBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.icdgpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // icdgpUser
            // 
            this.icdgpUser.Controls.Add(this.chkSelect);
            this.icdgpUser.Controls.Add(this.btnCancel);
            this.icdgpUser.Controls.Add(this.btnSave);
            this.icdgpUser.Controls.Add(this.tvUsers);
            this.icdgpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icdgpUser.Location = new System.Drawing.Point(0, 0);
            this.icdgpUser.Name = "icdgpUser";
            this.icdgpUser.Size = new System.Drawing.Size(374, 571);
            this.icdgpUser.TabIndex = 0;
            this.icdgpUser.TabStop = false;
            this.icdgpUser.Text = "包含用户";
            // 
            // chksele
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(13, 521);
            this.chkSelect.Name = "chksele";
            this.chkSelect.Size = new System.Drawing.Size(59, 19);
            this.chkSelect.TabIndex = 15;
            this.chkSelect.Text = "全选";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chksele_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(262, 526);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(147, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvUsers
            // 
            this.tvUsers.CheckBoxes = true;
            this.tvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvUsers.Location = new System.Drawing.Point(3, 21);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(368, 486);
            this.tvUsers.TabIndex = 0;
            this.tvUsers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvindUser_NodeMouseClick);
            // 
            // FrmIncludeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 571);
            this.Controls.Add(this.icdgpUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIncludeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "包含用户";
            this.Text = "包含用户";
            this.Load += new System.EventHandler(this.FrmIncludeUser_Load_1);
            this.icdgpUser.ResumeLayout(false);
            this.icdgpUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox icdgpUser;
        private System.Windows.Forms.TreeView tvUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSelect;
    }
}