using System;
using System.IO;
using System.Windows.Forms;

namespace WinformTinyMceHtmlEditor
{
    public partial class TinyMce : UserControl
    {
        public TinyMce()
        {
            InitializeComponent();
        }

        public object ActiveXInstance => webBrowserControl.ActiveXInstance;

        public string HtmlContent
        {
            get
            {
                var content = string.Empty;
                if (webBrowserControl.Document != null)
                {
                    var html = webBrowserControl.Document.InvokeScript("GetContent");
                    content = html as string;
                }

                return content;
            }
            set { webBrowserControl.Document?.InvokeScript("SetContent", new object[] { value }); }
        }

        public void SetFullscreen()
        {
            webBrowserControl.Document?.InvokeScript("tinyMCE.execCommand('mceFullScreen')");
        }


        public void CreateEditor()
        {
            webBrowserControl.ScriptErrorsSuppressed = true;

            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"tinymce\js\tinymce\tinymce.min.js")))
                webBrowserControl.Url = new Uri(@"file:///" + Path
                    .Combine(AppDomain.CurrentDomain.BaseDirectory, @"tinymce/tinymce.html").Replace('\\', '/'));
            else
                MessageBox.Show(
                    @"tinymce.html Not Found", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}