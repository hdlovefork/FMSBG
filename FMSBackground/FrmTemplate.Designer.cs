namespace FMSBackground
{
    partial class FrmTemplate
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvWord = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvExcel = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvPPT = new System.Windows.Forms.ListView();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnDelete = new FMSBackground.Control.AuthButton();
            this.btnAdd = new FMSBackground.Control.AuthButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvWord);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "1";
            this.tabPage1.Text = "Word";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvWord
            // 
            this.lvWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWord.LargeImageList = this.imageList1;
            this.lvWord.Location = new System.Drawing.Point(3, 3);
            this.lvWord.Name = "lvWord";
            this.lvWord.Size = new System.Drawing.Size(939, 554);
            this.lvWord.SmallImageList = this.imageList1;
            this.lvWord.TabIndex = 0;
            this.lvWord.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvExcel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "2";
            this.tabPage2.Text = "Excel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvExcel
            // 
            this.lvExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExcel.Location = new System.Drawing.Point(3, 3);
            this.lvExcel.Name = "lvExcel";
            this.lvExcel.Size = new System.Drawing.Size(939, 554);
            this.lvExcel.TabIndex = 0;
            this.lvExcel.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvPPT);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(945, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "3";
            this.tabPage3.Text = "PPT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvPPT
            // 
            this.lvPPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPPT.Location = new System.Drawing.Point(3, 3);
            this.lvPPT.Name = "lvPPT";
            this.lvPPT.Size = new System.Drawing.Size(939, 554);
            this.lvPPT.TabIndex = 0;
            this.lvPPT.UseCompatibleStateImageBehavior = false;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnDelete);
            this.pnlAction.Controls.Add(this.btnAdd);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Location = new System.Drawing.Point(0, 0);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(953, 60);
            this.pnlAction.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Tag = "Template/Delete";
            this.btnDelete.Text = " 删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "Template/Add";
            this.btnAdd.Text = " 添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 655);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTemplate";
            this.TabText = "模板管理";
            this.Text = "模板管理";
            this.Load += new System.EventHandler(this.FrmTemplate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlAction;
        private Control.AuthButton btnAdd;
        private Control.AuthButton btnDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvWord;
        private System.Windows.Forms.ListView lvExcel;
        private System.Windows.Forms.ListView lvPPT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}