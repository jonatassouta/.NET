
namespace WindowsFormsApp1
{
    partial class FormFilhoCheck
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
            this.chkHtmlCss = new System.Windows.Forms.CheckBox();
            this.chkAsp = new System.Windows.Forms.CheckBox();
            this.chkCs = new System.Windows.Forms.CheckBox();
            this.chkDocker = new System.Windows.Forms.CheckBox();
            this.chkWindows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkHtmlCss
            // 
            this.chkHtmlCss.AutoSize = true;
            this.chkHtmlCss.Location = new System.Drawing.Point(26, 83);
            this.chkHtmlCss.Name = "chkHtmlCss";
            this.chkHtmlCss.Size = new System.Drawing.Size(89, 17);
            this.chkHtmlCss.TabIndex = 1;
            this.chkHtmlCss.Text = "HTML e CSS";
            this.chkHtmlCss.UseVisualStyleBackColor = true;
            this.chkHtmlCss.CheckedChanged += new System.EventHandler(this.chkHtmlCss_CheckedChanged);
            // 
            // chkAsp
            // 
            this.chkAsp.AutoSize = true;
            this.chkAsp.Location = new System.Drawing.Point(26, 156);
            this.chkAsp.Name = "chkAsp";
            this.chkAsp.Size = new System.Drawing.Size(75, 17);
            this.chkAsp.TabIndex = 2;
            this.chkAsp.Text = "ASP .NET";
            this.chkAsp.UseVisualStyleBackColor = true;
            this.chkAsp.CheckedChanged += new System.EventHandler(this.chkAsp_CheckedChanged);
            // 
            // chkCs
            // 
            this.chkCs.AutoSize = true;
            this.chkCs.Location = new System.Drawing.Point(26, 120);
            this.chkCs.Name = "chkCs";
            this.chkCs.Size = new System.Drawing.Size(40, 17);
            this.chkCs.TabIndex = 3;
            this.chkCs.Text = "C#";
            this.chkCs.UseVisualStyleBackColor = true;
            this.chkCs.CheckedChanged += new System.EventHandler(this.chkCs_CheckedChanged);
            // 
            // chkDocker
            // 
            this.chkDocker.AutoSize = true;
            this.chkDocker.Location = new System.Drawing.Point(26, 46);
            this.chkDocker.Name = "chkDocker";
            this.chkDocker.Size = new System.Drawing.Size(61, 17);
            this.chkDocker.TabIndex = 4;
            this.chkDocker.Text = "Docker";
            this.chkDocker.UseVisualStyleBackColor = true;
            this.chkDocker.CheckedChanged += new System.EventHandler(this.chkDocker_CheckedChanged);
            // 
            // chkWindows
            // 
            this.chkWindows.AutoSize = true;
            this.chkWindows.Location = new System.Drawing.Point(26, 12);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(70, 17);
            this.chkWindows.TabIndex = 5;
            this.chkWindows.Text = "Windows";
            this.chkWindows.UseVisualStyleBackColor = true;
            this.chkWindows.CheckedChanged += new System.EventHandler(this.chkWindows_CheckedChanged);
            // 
            // FormFilhoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 244);
            this.Controls.Add(this.chkHtmlCss);
            this.Controls.Add(this.chkAsp);
            this.Controls.Add(this.chkCs);
            this.Controls.Add(this.chkDocker);
            this.Controls.Add(this.chkWindows);
            this.Name = "FormFilhoCheck";
            this.Text = "FormFilhoCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkHtmlCss;
        public System.Windows.Forms.CheckBox chkAsp;
        public System.Windows.Forms.CheckBox chkCs;
        public System.Windows.Forms.CheckBox chkDocker;
        public System.Windows.Forms.CheckBox chkWindows;
    }
}