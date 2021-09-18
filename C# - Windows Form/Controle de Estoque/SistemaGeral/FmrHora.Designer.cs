
namespace SistemaGeral {
    partial class FmrHora {
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
            this.components = new System.ComponentModel.Container();
            this.panelContainer2 = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panelContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer2
            // 
            this.panelContainer2.AutoScroll = true;
            this.panelContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContainer2.Controls.Add(this.labelData);
            this.panelContainer2.Controls.Add(this.labelHora);
            this.panelContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer2.Location = new System.Drawing.Point(0, 0);
            this.panelContainer2.Name = "panelContainer2";
            this.panelContainer2.Size = new System.Drawing.Size(584, 411);
            this.panelContainer2.TabIndex = 3;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.SlateGray;
            this.labelData.Location = new System.Drawing.Point(77, 250);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(86, 31);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "label1";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelHora.Location = new System.Drawing.Point(166, 150);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(209, 76);
            this.labelHora.TabIndex = 0;
            this.labelHora.Text = "label1";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FmrHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panelContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrHora";
            this.Text = "FmrHora";
            this.panelContainer2.ResumeLayout(false);
            this.panelContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer2;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerHora;
    }
}