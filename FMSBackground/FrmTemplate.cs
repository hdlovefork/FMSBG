using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileSystem.BLL;
using FileSystem.Entity;
using HD.Tool;
using System.Diagnostics;
using System.IO;

namespace FMSBackground
{
    public partial class FrmTemplate : BaseForm
    {
        TemplateLogic _tempLogic = new TemplateLogic();

        public FrmTemplate()
        {
            InitializeComponent();
        }

        private void FrmTemplate_Load(object sender, EventArgs e)
        {
            ShowWordTemplete();//显示Word模板
            ShowExcelTemplate();//显示Excel模板
            ShowPPTTemplate();//显示PPT模板
            tpWord.Tag = lvWord;
            tpExcel.Tag = lvExcel;
            tpPPT.Tag = lvPPT;
        }

        private void ShowPPTTemplate()
        {
            ShowTemplete(lvPPT, DocType.PPT);
        }

        private void ShowExcelTemplate()
        {
            ShowTemplete(lvExcel, DocType.Excel);
        }

        private void ShowWordTemplete()
        {
            ShowTemplete(lvWord, DocType.Word);
        }

        private void ShowTemplete(ListView lv, DocType type)
        {
            lv.Items.Clear();
            IList<DocTemplete> list = _tempLogic.GetTemplateByType(type);
            foreach (var t in list)
            {
                ListViewItem item = new ListViewItem(t.TempleteName, (int)type - 1);
                item.Name = t.TempleteID.ToString();
                item.Tag = t;
                lv.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, Control.AuthEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DocType type;
                if (_tempLogic.AddTemplate(openFileDialog1.FileName, out type))
                {
                    tbTemplete.SelectedIndex = (int)type - 1;
                    if (tbTemplete.SelectedTab == null) return;
                    ListView lv = tbTemplete.SelectedTab.Tag as ListView;
                    if (lv == null) return;
                    ShowTemplete(lv, type);
                }
            }
        }

        private void btnDelete_Click(object sender, Control.AuthEventArgs e)
        {
            if (tbTemplete.SelectedTab == null) return;
            ListView lv = tbTemplete.SelectedTab.Tag as ListView;
            if (lv == null) return;
            if (lv.SelectedItems.Count == 0) return;
            bool ok = false;
            foreach (ListViewItem item in lv.SelectedItems)
            {
                DocTemplete tpl = item.Tag as DocTemplete;
                if (tpl == null) return;
                ok = _tempLogic.DeleteTemplete(tpl.TempleteID);
            }
            if (ok)
                ShowTemplete(lv, (DocType)(tbTemplete.SelectedIndex + 1));

        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (tbTemplete.SelectedTab == null) return;
            ListView lv = tbTemplete.SelectedTab.Tag as ListView;
            if (lv == null) return;
            if (lv.SelectedItems.Count == 0) return;
            DocTemplete tpl = lv.SelectedItems[0].Tag as DocTemplete;
            if (tpl == null) return;
            if (!Directory.Exists(GObj.TEMP_DIR))
                Directory.CreateDirectory(GObj.TEMP_DIR);
            string path = string.Format(@"{0}\{1}", GObj.TEMP_DIR, tpl.TempleteName);
            if (FileKit.Write(path, tpl.TempleteData, System.IO.FileMode.OpenOrCreate))
                Process.Start(path);
        }
    }
}
