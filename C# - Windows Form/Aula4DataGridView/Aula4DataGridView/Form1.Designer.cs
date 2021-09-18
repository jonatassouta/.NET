
namespace Aula4DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btmPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(12, 30);
            this.txtPesquisar.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(200, 20);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPesquisar.Location = new System.Drawing.Point(218, 14);
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.Size = new System.Drawing.Size(188, 48);
            this.btmPesquisar.TabIndex = 2;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.UseVisualStyleBackColor = true;
            this.btmPesquisar.Click += new System.EventHandler(this.btmPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btmPesquisar;
    }
}

