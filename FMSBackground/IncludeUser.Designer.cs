namespace FMSBackground
{
    partial class IncludeUser
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.icdgpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // icdgpUser
            // 
            this.icdgpUser.Controls.Add(this.treeView1);
            this.icdgpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icdgpUser.Location = new System.Drawing.Point(0, 0);
            this.icdgpUser.Name = "icdgpUser";
            this.icdgpUser.Size = new System.Drawing.Size(360, 587);
            this.icdgpUser.TabIndex = 0;
            this.icdgpUser.TabStop = false;
            this.icdgpUser.Text = "包含用户";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(3, 21);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(354, 465);
            this.treeView1.TabIndex = 0;
            // 
            // IncludeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 587);
            this.Controls.Add(this.icdgpUser);
            this.Name = "IncludeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "包含用户";
            this.icdgpUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox icdgpUser;
        private System.Windows.Forms.TreeView treeView1;
    }
}