namespace FMSBackground
{
    partial class FrmFunction
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
            this.btnDelete = new FMSBackground.Control.AuthButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvFunction = new System.Windows.Forms.TreeView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboFunction = new System.Windows.Forms.ComboBox();
            this.txtFunctionControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFunctionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new FMSBackground.Control.AuthButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEdit = new FMSBackground.Control.AuthButton();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Tag = "Function/Delete";
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new FMSBackground.Control.AuthEventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tvFunction);
            this.groupBox1.Location = new System.Drawing.Point(10, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 517);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能列表";
            // 
            // tvFunction
            // 
            this.tvFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFunction.HideSelection = false;
            this.tvFunction.Location = new System.Drawing.Point(3, 17);
            this.tvFunction.Name = "tvFunction";
            this.tvFunction.Size = new System.Drawing.Size(251, 497);
            this.tvFunction.TabIndex = 0;
            this.tvFunction.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFunction_NodeMouseClick);
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Controls.Add(this.lblError);
            this.gbDetail.Controls.Add(this.btnCancel);
            this.gbDetail.Controls.Add(this.btnSave);
            this.gbDetail.Controls.Add(this.cboFunction);
            this.gbDetail.Controls.Add(this.txtFunctionControl);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtFunctionName);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Enabled = false;
            this.gbDetail.Location = new System.Drawing.Point(273, 38);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(295, 514);
            this.gbDetail.TabIndex = 5;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "功能详细信息";
            this.gbDetail.Enter += new System.EventHandler(this.gbDetail_Enter);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 199);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(206, 37);
            this.lblError.TabIndex = 8;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(210, 151);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = " 放弃";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(150, 151);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFunction
            // 
            this.cboFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunction.FormattingEnabled = true;
            this.cboFunction.Location = new System.Drawing.Point(109, 59);
            this.cboFunction.Margin = new System.Windows.Forms.Padding(2);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(157, 20);
            this.cboFunction.TabIndex = 6;
            // 
            // txtFunctionControl
            // 
            this.txtFunctionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionControl.Location = new System.Drawing.Point(109, 98);
            this.txtFunctionControl.Name = "txtFunctionControl";
            this.txtFunctionControl.Size = new System.Drawing.Size(157, 21);
            this.txtFunctionControl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "功能控件ID(*):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "上层管理(*):";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFunctionName.Location = new System.Drawing.Point(109, 19);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(157, 21);
            this.txtFunctionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "功能名称(*):";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Tag = "Function/Add";
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(577, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 517);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "课操作的角色";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 497);
            this.listBox1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(86, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Tag = "User/Edit";
            this.btnEdit.Text = " 编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new FMSBackground.Control.AuthEventHandler(this.btnEdit_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnEdit);
            this.pnlAction.Location = new System.Drawing.Point(6, 0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(243, 36);
            this.pnlAction.TabIndex = 8;
            // 
            // FrmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 561);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFunction";
            this.TabText = "功能管理";
            this.Text = "功能管理";
            this.Load += new System.EventHandler(this.FrmFunction_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvFunction;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.ComboBox cboFunction;
        private System.Windows.Forms.TextBox txtFunctionControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFunctionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Label lblError;
        private Control.AuthButton btnDelete;
        private Control.AuthButton btnEdit;
        private Control.AuthButton btnAdd;
    }
}