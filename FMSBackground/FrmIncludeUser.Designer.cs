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
            this.chksele = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tvindUser = new System.Windows.Forms.TreeView();
            this.icdgpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // icdgpUser
            // 
            this.icdgpUser.Controls.Add(this.chksele);
            this.icdgpUser.Controls.Add(this.btnCancel);
            this.icdgpUser.Controls.Add(this.btnSave);
            this.icdgpUser.Controls.Add(this.tvindUser);
            this.icdgpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icdgpUser.Location = new System.Drawing.Point(0, 0);
            this.icdgpUser.Name = "icdgpUser";
            this.icdgpUser.Size = new System.Drawing.Size(360, 587);
            this.icdgpUser.TabIndex = 0;
            this.icdgpUser.TabStop = false;
            this.icdgpUser.Text = "包含用户";
            // 
            // chksele
            // 
            this.chksele.AutoSize = true;
            this.chksele.Location = new System.Drawing.Point(6, 513);
            this.chksele.Name = "chksele";
            this.chksele.Size = new System.Drawing.Size(59, 19);
            this.chksele.TabIndex = 15;
            this.chksele.Text = "全选";
            this.chksele.UseVisualStyleBackColor = true;
            this.chksele.CheckedChanged += new System.EventHandler(this.chksele_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(265, 530);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(167, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tvindUser
            // 
            this.tvindUser.CheckBoxes = true;
            this.tvindUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvindUser.Location = new System.Drawing.Point(3, 21);
            this.tvindUser.Name = "tvindUser";
            this.tvindUser.Size = new System.Drawing.Size(354, 486);
            this.tvindUser.TabIndex = 0;
            this.tvindUser.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvindUser_NodeMouseClick);
            // 
            // FrmIncludeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 587);
            this.Controls.Add(this.icdgpUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIncludeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "包含用户";
            this.Load += new System.EventHandler(this.FrmIncludeUser_Load_1);
            this.icdgpUser.ResumeLayout(false);
            this.icdgpUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox icdgpUser;
        private System.Windows.Forms.TreeView tvindUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chksele;
    }
}