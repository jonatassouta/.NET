
namespace Aula1WForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReultado = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(95, 60);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(260, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(95, 138);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(260, 20);
            this.txtAltura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular IMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtReultado
            // 
            this.txtReultado.Location = new System.Drawing.Point(95, 277);
            this.txtReultado.Name = "txtReultado";
            this.txtReultado.Size = new System.Drawing.Size(260, 20);
            this.txtReultado.TabIndex = 3;
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.Location = new System.Drawing.Point(144, 325);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(0, 31);
            this.txtLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 387);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReultado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Name = "Form1";
            this.Text = "PrimeiroProgramaWF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReultado;
        private System.Windows.Forms.Label txtLabel;
    }
}

