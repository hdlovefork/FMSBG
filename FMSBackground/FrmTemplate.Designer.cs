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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemplate));
            this.tbTemplete = new System.Windows.Forms.TabControl();
            this.tpWord = new System.Windows.Forms.TabPage();
            this.lvWord = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpExcel = new System.Windows.Forms.TabPage();
            this.lvExcel = new System.Windows.Forms.ListView();
            this.tpPPT = new System.Windows.Forms.TabPage();
            this.lvPPT = new System.Windows.Forms.ListView();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnDelete = new FMSBackground.Control.AuthButton();
            this.btnAdd = new FMSBackground.Control.AuthButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTemplete.SuspendLayout();
            this.tpWord.SuspendLayout();
            this.tpExcel.SuspendLayout();
            this.tpPPT.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTemplete
            // 
            this.tbTemplete.Controls.Add(this.tpWord);
            this.tbTemplete.Controls.Add(this.tpExcel);
            this.tbTemplete.Controls.Add(this.tpPPT);
            this.tbTemplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTemplete.Location = new System.Drawing.Point(0, 0);
            this.tbTemplete.Name = "tbTemplete";
            this.tbTemplete.SelectedIndex = 0;
            this.tbTemplete.Size = new System.Drawing.Size(953, 595);
            this.tbTemplete.TabIndex = 0;
            // 
            // tpWord
            // 
            this.tpWord.Controls.Add(this.lvWord);
            this.tpWord.Location = new System.Drawing.Point(4, 25);
            this.tpWord.Name = "tpWord";
            this.tpWord.Padding = new System.Windows.Forms.Padding(3);
            this.tpWord.Size = new System.Drawing.Size(945, 566);
            this.tpWord.TabIndex = 0;
            this.tpWord.Tag = "1";
            this.tpWord.Text = "Word";
            this.tpWord.UseVisualStyleBackColor = true;
            // 
            // lvWord
            // 
            this.lvWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWord.LargeImageList = this.imageList1;
            this.lvWord.Location = new System.Drawing.Point(3, 3);
            this.lvWord.Name = "lvWord";
            this.lvWord.Size = new System.Drawing.Size(939, 560);
            this.lvWord.TabIndex = 0;
            this.lvWord.UseCompatibleStateImageBehavior = false;
            this.lvWord.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "word_2007_color_trans.png");
            this.imageList1.Images.SetKeyName(1, "excel_2007_color_trans.png");
            this.imageList1.Images.SetKeyName(2, "power_point_2007_color_tran.png");
            // 
            // tpExcel
            // 
            this.tpExcel.Controls.Add(this.lvExcel);
            this.tpExcel.Location = new System.Drawing.Point(4, 25);
            this.tpExcel.Name = "tpExcel";
            this.tpExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tpExcel.Size = new System.Drawing.Size(945, 566);
            this.tpExcel.TabIndex = 1;
            this.tpExcel.Tag = "2";
            this.tpExcel.Text = "Excel";
            this.tpExcel.UseVisualStyleBackColor = true;
            // 
            // lvExcel
            // 
            this.lvExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExcel.LargeImageList = this.imageList1;
            this.lvExcel.Location = new System.Drawing.Point(3, 3);
            this.lvExcel.Name = "lvExcel";
            this.lvExcel.Size = new System.Drawing.Size(939, 560);
            this.lvExcel.TabIndex = 0;
            this.lvExcel.UseCompatibleStateImageBehavior = false;
            this.lvExcel.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // tpPPT
            // 
            this.tpPPT.Controls.Add(this.lvPPT);
            this.tpPPT.Location = new System.Drawing.Point(4, 25);
            this.tpPPT.Name = "tpPPT";
            this.tpPPT.Padding = new System.Windows.Forms.Padding(3);
            this.tpPPT.Size = new System.Drawing.Size(945, 566);
            this.tpPPT.TabIndex = 2;
            this.tpPPT.Tag = "3";
            this.tpPPT.Text = "PPT";
            this.tpPPT.UseVisualStyleBackColor = true;
            // 
            // lvPPT
            // 
            this.lvPPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPPT.LargeImageList = this.imageList1;
            this.lvPPT.Location = new System.Drawing.Point(3, 3);
            this.lvPPT.Name = "lvPPT";
            this.lvPPT.Size = new System.Drawing.Size(939, 560);
            this.lvPPT.TabIndex = 0;
            this.lvPPT.UseCompatibleStateImageBehavior = false;
            this.lvPPT.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
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
            this.btnDelete.Tag = "Templete/Delete";
            this.btnDelete.Text = " 删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new FMSBackground.Control.AuthEventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Tag = "Templete/Add";
            this.btnAdd.Text = " 添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new FMSBackground.Control.AuthEventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Office 文件 (*.doc,*.docx, *.xls,*.xlsx,*.ppt,*.pptx)|*.doc;*.docx; *.xls;*.xlsx;*." +
    "ppt;*.pptx";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTemplete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 595);
            this.panel1.TabIndex = 1;
            // 
            // FrmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAction);
            this.Name = "FrmTemplate";
            this.TabText = "模板管理";
            this.Text = "模板管理";
            this.Load += new System.EventHandler(this.FrmTemplate_Load);
            this.tbTemplete.ResumeLayout(false);
            this.tpWord.ResumeLayout(false);
            this.tpExcel.ResumeLayout(false);
            this.tpPPT.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbTemplete;
        private System.Windows.Forms.TabPage tpWord;
        private System.Windows.Forms.TabPage tpExcel;
        private System.Windows.Forms.Panel pnlAction;
        private Control.AuthButton btnAdd;
        private Control.AuthButton btnDelete;
        private System.Windows.Forms.TabPage tpPPT;
        private System.Windows.Forms.ListView lvWord;
        private System.Windows.Forms.ListView lvExcel;
        private System.Windows.Forms.ListView lvPPT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}