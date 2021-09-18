
namespace WindowsFormsApp1
{
    partial class FormCheckBox
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
            this.chkWindows = new System.Windows.Forms.CheckBox();
            this.chkDocker = new System.Windows.Forms.CheckBox();
            this.chkCs = new System.Windows.Forms.CheckBox();
            this.chkHtmlCss = new System.Windows.Forms.CheckBox();
            this.chkAsp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btmChamarFormFilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkWindows
            // 
            this.chkWindows.AutoSize = true;
            this.chkWindows.Location = new System.Drawing.Point(30, 22);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(70, 17);
            this.chkWindows.TabIndex = 0;
            this.chkWindows.Text = "Windows";
            this.chkWindows.UseVisualStyleBackColor = true;
            // 
            // chkDocker
            // 
            this.chkDocker.AutoSize = true;
            this.chkDocker.Location = new System.Drawing.Point(30, 56);
            this.chkDocker.Name = "chkDocker";
            this.chkDocker.Size = new System.Drawing.Size(61, 17);
            this.chkDocker.TabIndex = 0;
            this.chkDocker.Text = "Docker";
            this.chkDocker.UseVisualStyleBackColor = true;
            // 
            // chkCs
            // 
            this.chkCs.AutoSize = true;
            this.chkCs.Location = new System.Drawing.Point(30, 130);
            this.chkCs.Name = "chkCs";
            this.chkCs.Size = new System.Drawing.Size(40, 17);
            this.chkCs.TabIndex = 0;
            this.chkCs.Text = "C#";
            this.chkCs.UseVisualStyleBackColor = true;
            // 
            // chkHtmlCss
            // 
            this.chkHtmlCss.AutoSize = true;
            this.chkHtmlCss.Location = new System.Drawing.Point(30, 91);
            this.chkHtmlCss.Name = "chkHtmlCss";
            this.chkHtmlCss.Size = new System.Drawing.Size(89, 17);
            this.chkHtmlCss.TabIndex = 0;
            this.chkHtmlCss.Text = "HTML e CSS";
            this.chkHtmlCss.UseVisualStyleBackColor = true;
            // 
            // chkAsp
            // 
            this.chkAsp.AutoSize = true;
            this.chkAsp.Location = new System.Drawing.Point(30, 166);
            this.chkAsp.Name = "chkAsp";
            this.chkAsp.Size = new System.Drawing.Size(75, 17);
            this.chkAsp.TabIndex = 0;
            this.chkAsp.Text = "ASP .NET";
            this.chkAsp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cursos Infomartica selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmChamarFormFilo
            // 
            this.btmChamarFormFilo.Location = new System.Drawing.Point(167, 105);
            this.btmChamarFormFilo.Name = "btmChamarFormFilo";
            this.btmChamarFormFilo.Size = new System.Drawing.Size(272, 93);
            this.btmChamarFormFilo.TabIndex = 2;
            this.btmChamarFormFilo.Text = "Chamar Form Filho";
            this.btmChamarFormFilo.UseVisualStyleBackColor = true;
            this.btmChamarFormFilo.Click += new System.EventHandler(this.btmChamarFormFilo_Click);
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 221);
            this.Controls.Add(this.btmChamarFormFilo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkHtmlCss);
            this.Controls.Add(this.chkAsp);
            this.Controls.Add(this.chkCs);
            this.Controls.Add(this.chkDocker);
            this.Controls.Add(this.chkWindows);
            this.Name = "FormCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox chkWindows;
        public System.Windows.Forms.CheckBox chkDocker;
        public System.Windows.Forms.CheckBox chkCs;
        public System.Windows.Forms.CheckBox chkHtmlCss;
        public System.Windows.Forms.CheckBox chkAsp;
        private System.Windows.Forms.Button btmChamarFormFilo;
    }
}