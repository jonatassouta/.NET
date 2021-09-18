
namespace WindowsFormsApp1
{
    partial class FormComboBox
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "HTML",
            "CSS",
            "C#",
            "ASP .NET",
            "Docker"});
            this.comboBox.Location = new System.Drawing.Point(23, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(291, 21);
            this.comboBox.TabIndex = 0;
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(320, 29);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(254, 20);
            this.txtCombo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.comboBox);
            this.Name = "FormComboBox";
            this.Text = "FormComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}