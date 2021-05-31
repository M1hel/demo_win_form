using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddAnotherTabLikeThis();
        }

        private void AddAnotherTabLikeThis()
        {

            #region Generate controls and put them into the tab

            TabPage tp = new TabPage();
            System.Windows.Forms.TextBox tb;
            System.Windows.Forms.ProgressBar pb;
            System.Windows.Forms.Button bt;
            System.Windows.Forms.WebBrowser wb;

            wb = new System.Windows.Forms.WebBrowser();
            bt = new System.Windows.Forms.Button();
            pb = new System.Windows.Forms.ProgressBar();
            tb = new System.Windows.Forms.TextBox();


            this.tabControl1.SuspendLayout();
            tp.SuspendLayout();
            this.SuspendLayout();

            tabControl1.TabPages.Add(tp);


            tp.Controls.Add(wb);
            tp.Controls.Add(bt);
            tp.Controls.Add(pb);
            tp.Controls.Add(tb);

            tp.Location = new System.Drawing.Point(4, 25);
            tp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //tp.Name = "tabPage2";
            tp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tp.Size = new System.Drawing.Size(1061, 681);
            tp.TabIndex = 0;
            //tp.Text = "tabPage2";
            tp.UseVisualStyleBackColor = true;

            // 
            // tbUrl
            // 
            tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tb.BackColor = System.Drawing.SystemColors.ControlLight;
            tb.Location = new System.Drawing.Point(0, 0);
            tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb.Name = "tbUrl";
            tb.ReadOnly = true;
            tb.Size = new System.Drawing.Size(895, 22);
            tb.TabIndex = 2;
            // 
            // webBrowser1
            // 
            wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            wb.Location = new System.Drawing.Point(8, 32);
            wb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            wb.MinimumSize = new System.Drawing.Size(27, 25);
            wb.Name = "webBrowser1";
            wb.Size = new System.Drawing.Size(1043, 601);
            wb.TabIndex = 34;
            // 
            // btUserMessage
            // 
            bt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            bt.Dock = System.Windows.Forms.DockStyle.Bottom;
            bt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bt.Location = new System.Drawing.Point(4, 641);
            bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bt.Name = "btUserMessage";
            bt.Size = new System.Drawing.Size(1053, 36);
            bt.TabIndex = 33;
            bt.Text = "btUserMessage";
            bt.UseVisualStyleBackColor = true;
            // 
            // pbPageLoad
            // 
            pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pb.Location = new System.Drawing.Point(901, 1);
            pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pb.Name = "pbPageLoad";
            pb.Size = new System.Drawing.Size(153, 23);
            pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            pb.TabIndex = 31;

            this.tabControl1.ResumeLayout(false);
            tp.ResumeLayout(false);
            tp.PerformLayout();
            this.ResumeLayout(false);
            #endregion

        }
    }
}
