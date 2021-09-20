
namespace Calculadora {
    partial class Calculadora {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btm7 = new System.Windows.Forms.Button();
            this.btmMul = new System.Windows.Forms.Button();
            this.btmMenos = new System.Windows.Forms.Button();
            this.btmMais = new System.Windows.Forms.Button();
            this.btmIgual = new System.Windows.Forms.Button();
            this.btmDivi = new System.Windows.Forms.Button();
            this.btm8 = new System.Windows.Forms.Button();
            this.btm9 = new System.Windows.Forms.Button();
            this.btm6 = new System.Windows.Forms.Button();
            this.btm5 = new System.Windows.Forms.Button();
            this.btm4 = new System.Windows.Forms.Button();
            this.btm3 = new System.Windows.Forms.Button();
            this.btm2 = new System.Windows.Forms.Button();
            this.btm1 = new System.Windows.Forms.Button();
            this.btmPonto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btmClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(359, 72);
            this.textBox1.TabIndex = 0;
            // 
            // btm7
            // 
            this.btm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm7.Location = new System.Drawing.Point(7, 184);
            this.btm7.Name = "btm7";
            this.btm7.Size = new System.Drawing.Size(89, 59);
            this.btm7.TabIndex = 1;
            this.btm7.Text = "7";
            this.btm7.UseVisualStyleBackColor = true;
            this.btm7.Click += new System.EventHandler(this.btm7_Click);
            // 
            // btmMul
            // 
            this.btmMul.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMul.Location = new System.Drawing.Point(118, 117);
            this.btmMul.Name = "btmMul";
            this.btmMul.Size = new System.Drawing.Size(89, 52);
            this.btmMul.TabIndex = 7;
            this.btmMul.Text = "X";
            this.btmMul.UseVisualStyleBackColor = true;
            this.btmMul.Click += new System.EventHandler(this.btmMul_Click);
            // 
            // btmMenos
            // 
            this.btmMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMenos.Location = new System.Drawing.Point(323, 221);
            this.btmMenos.Name = "btmMenos";
            this.btmMenos.Size = new System.Drawing.Size(56, 76);
            this.btmMenos.TabIndex = 8;
            this.btmMenos.Text = "-";
            this.btmMenos.UseVisualStyleBackColor = true;
            this.btmMenos.Click += new System.EventHandler(this.btmMenos_Click);
            // 
            // btmMais
            // 
            this.btmMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMais.Location = new System.Drawing.Point(324, 303);
            this.btmMais.Name = "btmMais";
            this.btmMais.Size = new System.Drawing.Size(56, 71);
            this.btmMais.TabIndex = 9;
            this.btmMais.Text = "+";
            this.btmMais.UseVisualStyleBackColor = true;
            this.btmMais.Click += new System.EventHandler(this.btmMais_Click);
            // 
            // btmIgual
            // 
            this.btmIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmIgual.Location = new System.Drawing.Point(224, 378);
            this.btmIgual.Name = "btmIgual";
            this.btmIgual.Size = new System.Drawing.Size(156, 60);
            this.btmIgual.TabIndex = 10;
            this.btmIgual.Text = "=";
            this.btmIgual.UseVisualStyleBackColor = true;
            this.btmIgual.Click += new System.EventHandler(this.btmIgual_Click);
            // 
            // btmDivi
            // 
            this.btmDivi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDivi.Location = new System.Drawing.Point(7, 117);
            this.btmDivi.Name = "btmDivi";
            this.btmDivi.Size = new System.Drawing.Size(89, 52);
            this.btmDivi.TabIndex = 11;
            this.btmDivi.Text = "/";
            this.btmDivi.UseVisualStyleBackColor = true;
            this.btmDivi.Click += new System.EventHandler(this.btmDivi_Click);
            // 
            // btm8
            // 
            this.btm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm8.Location = new System.Drawing.Point(118, 184);
            this.btm8.Name = "btm8";
            this.btm8.Size = new System.Drawing.Size(89, 59);
            this.btm8.TabIndex = 1;
            this.btm8.Text = "8";
            this.btm8.UseVisualStyleBackColor = true;
            this.btm8.Click += new System.EventHandler(this.btm8_Click);
            // 
            // btm9
            // 
            this.btm9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm9.Location = new System.Drawing.Point(224, 184);
            this.btm9.Name = "btm9";
            this.btm9.Size = new System.Drawing.Size(89, 59);
            this.btm9.TabIndex = 1;
            this.btm9.Text = "9";
            this.btm9.UseVisualStyleBackColor = true;
            this.btm9.Click += new System.EventHandler(this.button3_Click);
            // 
            // btm6
            // 
            this.btm6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm6.Location = new System.Drawing.Point(224, 249);
            this.btm6.Name = "btm6";
            this.btm6.Size = new System.Drawing.Size(89, 59);
            this.btm6.TabIndex = 12;
            this.btm6.Text = "6";
            this.btm6.UseVisualStyleBackColor = true;
            this.btm6.Click += new System.EventHandler(this.btm6_Click);
            // 
            // btm5
            // 
            this.btm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm5.Location = new System.Drawing.Point(118, 249);
            this.btm5.Name = "btm5";
            this.btm5.Size = new System.Drawing.Size(89, 59);
            this.btm5.TabIndex = 13;
            this.btm5.Text = "5";
            this.btm5.UseVisualStyleBackColor = true;
            this.btm5.Click += new System.EventHandler(this.btm5_Click);
            // 
            // btm4
            // 
            this.btm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm4.Location = new System.Drawing.Point(7, 249);
            this.btm4.Name = "btm4";
            this.btm4.Size = new System.Drawing.Size(89, 59);
            this.btm4.TabIndex = 14;
            this.btm4.Text = "4";
            this.btm4.UseVisualStyleBackColor = true;
            this.btm4.Click += new System.EventHandler(this.btm4_Click);
            // 
            // btm3
            // 
            this.btm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm3.Location = new System.Drawing.Point(224, 314);
            this.btm3.Name = "btm3";
            this.btm3.Size = new System.Drawing.Size(89, 59);
            this.btm3.TabIndex = 15;
            this.btm3.Text = "3";
            this.btm3.UseVisualStyleBackColor = true;
            this.btm3.Click += new System.EventHandler(this.btm3_Click);
            // 
            // btm2
            // 
            this.btm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm2.Location = new System.Drawing.Point(118, 314);
            this.btm2.Name = "btm2";
            this.btm2.Size = new System.Drawing.Size(89, 59);
            this.btm2.TabIndex = 16;
            this.btm2.Text = "2";
            this.btm2.UseVisualStyleBackColor = true;
            this.btm2.Click += new System.EventHandler(this.btm2_Click);
            // 
            // btm1
            // 
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm1.Location = new System.Drawing.Point(7, 314);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(89, 59);
            this.btm1.TabIndex = 17;
            this.btm1.Text = "1";
            this.btm1.UseVisualStyleBackColor = true;
            this.btm1.Click += new System.EventHandler(this.btm1_Click_1);
            // 
            // btmPonto
            // 
            this.btmPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPonto.Location = new System.Drawing.Point(7, 379);
            this.btmPonto.Name = "btmPonto";
            this.btmPonto.Size = new System.Drawing.Size(89, 59);
            this.btmPonto.TabIndex = 18;
            this.btmPonto.Text = ".";
            this.btmPonto.UseVisualStyleBackColor = true;
            this.btmPonto.Click += new System.EventHandler(this.btmPonto_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(118, 379);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 59);
            this.button11.TabIndex = 19;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(31, 35);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperacao.Size = new System.Drawing.Size(0, 25);
            this.lblOperacao.TabIndex = 21;
            // 
            // btmClean
            // 
            this.btmClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btmClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClean.Location = new System.Drawing.Point(224, 118);
            this.btmClean.Name = "btmClean";
            this.btmClean.Size = new System.Drawing.Size(89, 51);
            this.btmClean.TabIndex = 23;
            this.btmClean.Text = "CE";
            this.btmClean.UseVisualStyleBackColor = false;
            this.btmClean.Click += new System.EventHandler(this.btmClean_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 98);
            this.button1.TabIndex = 24;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmClean);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btmPonto);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btm3);
            this.Controls.Add(this.btm2);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.btm6);
            this.Controls.Add(this.btm5);
            this.Controls.Add(this.btm4);
            this.Controls.Add(this.btmDivi);
            this.Controls.Add(this.btmIgual);
            this.Controls.Add(this.btmMais);
            this.Controls.Add(this.btmMenos);
            this.Controls.Add(this.btmMul);
            this.Controls.Add(this.btm9);
            this.Controls.Add(this.btm8);
            this.Controls.Add(this.btm7);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 489);
            this.MinimumSize = new System.Drawing.Size(399, 489);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btm7;
        private System.Windows.Forms.Button btmMul;
        private System.Windows.Forms.Button btmMenos;
        private System.Windows.Forms.Button btmMais;
        private System.Windows.Forms.Button btmIgual;
        private System.Windows.Forms.Button btmDivi;
        private System.Windows.Forms.Button btm8;
        private System.Windows.Forms.Button btm9;
        private System.Windows.Forms.Button btm6;
        private System.Windows.Forms.Button btm5;
        private System.Windows.Forms.Button btm4;
        private System.Windows.Forms.Button btm3;
        private System.Windows.Forms.Button btm2;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Button btmPonto;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btmClean;
        private System.Windows.Forms.Button button1;
    }
}

