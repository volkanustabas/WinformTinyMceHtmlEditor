namespace WinformTinyMceHtmlEditor
{
    partial class FrmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Rtb_Content_Html = new System.Windows.Forms.RichTextBox();
            this.Btn_Get_Html = new System.Windows.Forms.Button();
            this.tinyMceEditor = new WinformTinyMceHtmlEditor.TinyMce();
            this.Tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Main
            // 
            this.Tlp_Main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Tlp_Main.ColumnCount = 1;
            this.Tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Main.Controls.Add(this.tinyMceEditor, 0, 0);
            this.Tlp_Main.Controls.Add(this.Rtb_Content_Html, 0, 2);
            this.Tlp_Main.Controls.Add(this.Btn_Get_Html, 0, 1);
            this.Tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Main.Name = "Tlp_Main";
            this.Tlp_Main.Padding = new System.Windows.Forms.Padding(5);
            this.Tlp_Main.RowCount = 3;
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Tlp_Main.Size = new System.Drawing.Size(784, 561);
            this.Tlp_Main.TabIndex = 0;
            // 
            // Rtb_Content_Html
            // 
            this.Rtb_Content_Html.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_Content_Html.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Content_Html.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtb_Content_Html.Location = new System.Drawing.Point(10, 380);
            this.Rtb_Content_Html.Name = "Rtb_Content_Html";
            this.Rtb_Content_Html.Size = new System.Drawing.Size(764, 171);
            this.Rtb_Content_Html.TabIndex = 1;
            this.Rtb_Content_Html.Text = "";
            // 
            // Btn_Get_Html
            // 
            this.Btn_Get_Html.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Get_Html.Location = new System.Drawing.Point(10, 338);
            this.Btn_Get_Html.Name = "Btn_Get_Html";
            this.Btn_Get_Html.Size = new System.Drawing.Size(764, 34);
            this.Btn_Get_Html.TabIndex = 2;
            this.Btn_Get_Html.Text = "Get Html";
            this.Btn_Get_Html.UseVisualStyleBackColor = true;
            this.Btn_Get_Html.Click += new System.EventHandler(this.Btn_Get_Html_Click);
            // 
            // tinyMceEditor
            // 
            this.tinyMceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinyMceEditor.HtmlContent = "";
            this.tinyMceEditor.Location = new System.Drawing.Point(10, 10);
            this.tinyMceEditor.Name = "tinyMceEditor";
            this.tinyMceEditor.Size = new System.Drawing.Size(764, 320);
            this.tinyMceEditor.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinformTinyMceHtmlEditor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Tlp_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_Main;
        private TinyMce tinyMceEditor;
        private System.Windows.Forms.RichTextBox Rtb_Content_Html;
        private System.Windows.Forms.Button Btn_Get_Html;
    }
}

