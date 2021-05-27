namespace Demo
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btUserMessage = new System.Windows.Forms.Button();
            this.pbPageLoad = new System.Windows.Forms.ProgressBar();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 710);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.btUserMessage);
            this.tabPage1.Controls.Add(this.pbPageLoad);
            this.tabPage1.Controls.Add(this.tbUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1061, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(8, 32);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1043, 601);
            this.webBrowser1.TabIndex = 34;
            // 
            // btUserMessage
            // 
            this.btUserMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btUserMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUserMessage.Location = new System.Drawing.Point(4, 641);
            this.btUserMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUserMessage.Name = "btUserMessage";
            this.btUserMessage.Size = new System.Drawing.Size(1053, 36);
            this.btUserMessage.TabIndex = 33;
            this.btUserMessage.Text = "btUserMessage";
            this.btUserMessage.UseVisualStyleBackColor = true;
            // 
            // pbPageLoad
            // 
            this.pbPageLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPageLoad.Location = new System.Drawing.Point(901, 1);
            this.pbPageLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPageLoad.Name = "pbPageLoad";
            this.pbPageLoad.Size = new System.Drawing.Size(153, 23);
            this.pbPageLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPageLoad.TabIndex = 31;
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbUrl.Location = new System.Drawing.Point(0, 0);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(895, 22);
            this.tbUrl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 710);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SurferForm2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TextBox tbUrl;
        public System.Windows.Forms.ProgressBar pbPageLoad;
        public System.Windows.Forms.Button btUserMessage;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

