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
        }

        private void ShowPPTTemplate()
        {
            //throw new NotImplementedException();
        }

        private void ShowExcelTemplate()
        {
            //throw new NotImplementedException();
        }

        private void ShowWordTemplete()
        {
            lvWord.Items.Clear();
            IList<DocTemplate> list = _tempLogic.GetTemplateByType(DocType.Word);
            foreach (var t in list)
            {
                lvWord.Items.Add(t.TemplateID.ToString(), t.TemplateName, 0);
            }

        }

        private void btnAdd_Click(object sender, Control.AuthEventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {              
                if (_tempLogic.AddTemplate(openFileDialog1.FileName,DocType.Word))
                {
                    ShowWordTemplete();
                }
            }
        }
    }
}
