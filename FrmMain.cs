using System;
using System.Windows.Forms;

namespace WinformTinyMceHtmlEditor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tinyMceEditor.CreateEditor();
        }

        private void Btn_Get_Html_Click(object sender, EventArgs e)
        {
            Rtb_Content_Html.Clear();
            Rtb_Content_Html.AppendText(tinyMceEditor.HtmlContent);
        }
    }
}