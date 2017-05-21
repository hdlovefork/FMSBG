namespace FMSBackground
{
    partial class FrmEditTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditTree));
            this.grbFunction = new System.Windows.Forms.GroupBox();
            this.tvFunctionTree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.chksele = new System.Windows.Forms.CheckBox();
            this.grbFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFunction
            // 
            this.grbFunction.Controls.Add(this.tvFunctionTree);
            this.grbFunction.Location = new System.Drawing.Point(12, 12);
            this.grbFunction.Name = "grbFunction";
            this.grbFunction.Size = new System.Drawing.Size(457, 609);
            this.grbFunction.TabIndex = 0;
            this.grbFunction.TabStop = false;
            this.grbFunction.Text = "编辑信息";
            // 
            // tvFunctionTree
            // 
            this.tvFunctionTree.CheckBoxes = true;
            this.tvFunctionTree.ImageIndex = 0;
            this.tvFunctionTree.ImageList = this.imageList1;
            this.tvFunctionTree.Location = new System.Drawing.Point(7, 24);
            this.tvFunctionTree.Name = "tvFunctionTree";
            this.tvFunctionTree.SelectedImageIndex = 0;
            this.tvFunctionTree.Size = new System.Drawing.Size(444, 576);
            this.tvFunctionTree.TabIndex = 0;
            this.tvFunctionTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFunctionTree_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "small_function.bmp");
            // 
            // btYes
            // 
            this.btYes.Location = new System.Drawing.Point(250, 634);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(100, 36);
            this.btYes.TabIndex = 1;
            this.btYes.Text = "确定";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.Location = new System.Drawing.Point(363, 633);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(100, 36);
            this.btNo.TabIndex = 1;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // chksele
            // 
            this.chksele.AutoSize = true;
            this.chksele.Location = new System.Drawing.Point(19, 628);
            this.chksele.Name = "chksele";
            this.chksele.Size = new System.Drawing.Size(59, 19);
            this.chksele.TabIndex = 2;
            this.chksele.Text = "全选";
            this.chksele.UseVisualStyleBackColor = true;
            this.chksele.CheckedChanged += new System.EventHandler(this.chksele_CheckedChanged);
            // 
            // FrmEditTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 676);
            this.Controls.Add(this.chksele);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.grbFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "FrmEditTree";
            this.Text = "FrmEditTree";
            this.Load += new System.EventHandler(this.FrmEditTree_Load);
            this.grbFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFunction;
        private System.Windows.Forms.TreeView tvFunctionTree;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.CheckBox chksele;
        private System.Windows.Forms.ImageList imageList1;
    }
}