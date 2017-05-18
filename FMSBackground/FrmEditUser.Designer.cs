namespace FMSBackground
{
    partial class FrmEditUser
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
            this.grpRser = new System.Windows.Forms.GroupBox();
            this.tvindUser = new System.Windows.Forms.TreeView();
            this.btNo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkSele = new System.Windows.Forms.CheckBox();
            this.grpRser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRser
            // 
            this.grpRser.Controls.Add(this.tvindUser);
            this.grpRser.Location = new System.Drawing.Point(13, 13);
            this.grpRser.Name = "grpRser";
            this.grpRser.Size = new System.Drawing.Size(338, 457);
            this.grpRser.TabIndex = 0;
            this.grpRser.TabStop = false;
            this.grpRser.Text = "可编辑用户";
            // 
            // tvindUser
            // 
            this.tvindUser.CheckBoxes = true;
            this.tvindUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvindUser.Location = new System.Drawing.Point(3, 21);
            this.tvindUser.Name = "tvindUser";
            this.tvindUser.Size = new System.Drawing.Size(332, 433);
            this.tvindUser.TabIndex = 0;
            // 
            // btNo
            // 
            this.btNo.Location = new System.Drawing.Point(262, 476);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(89, 36);
            this.btNo.TabIndex = 1;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chkSele
            // 
            this.chkSele.AutoSize = true;
            this.chkSele.Location = new System.Drawing.Point(13, 486);
            this.chkSele.Name = "chkSele";
            this.chkSele.Size = new System.Drawing.Size(59, 19);
            this.chkSele.TabIndex = 2;
            this.chkSele.Text = "全选";
            this.chkSele.UseVisualStyleBackColor = true;
            this.chkSele.CheckedChanged += new System.EventHandler(this.chkSele_CheckedChanged);
            // 
            // FrmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 524);
            this.Controls.Add(this.chkSele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.grpRser);
            this.Name = "FrmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑相关用户";
            this.Load += new System.EventHandler(this.FrmEditUser_Load);
            this.grpRser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRser;
        private System.Windows.Forms.TreeView tvindUser;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSele;
    }
}