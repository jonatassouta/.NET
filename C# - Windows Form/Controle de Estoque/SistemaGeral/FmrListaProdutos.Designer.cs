
namespace SistemaGeral {
    partial class FmrListaProdutos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrListaProdutos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btmPesquisar = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.btmEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(259, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmPesquisar.BackgroundImage")));
            this.btmPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmPesquisar.FlatAppearance.BorderSize = 0;
            this.btmPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPesquisar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPesquisar.Location = new System.Drawing.Point(277, 31);
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.Size = new System.Drawing.Size(45, 36);
            this.btmPesquisar.TabIndex = 2;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            this.btmPesquisar.Click += new System.EventHandler(this.btmPesquisar_Click);
            // 
            // btmAdd
            // 
            this.btmAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAdd.Location = new System.Drawing.Point(428, 32);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(69, 36);
            this.btmAdd.TabIndex = 3;
            this.btmAdd.Text = "Novo";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // btmEditar
            // 
            this.btmEditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEditar.Location = new System.Drawing.Point(503, 31);
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(69, 36);
            this.btmEditar.TabIndex = 3;
            this.btmEditar.Text = "Editar";
            this.btmEditar.UseVisualStyleBackColor = true;
            this.btmEditar.Click += new System.EventHandler(this.btmEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(491, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(328, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Venda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmrListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 448);
            this.Controls.Add(this.btmEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btmAdd);
            this.Controls.Add(this.btmPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrListaProdutos";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btmPesquisar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.Button btmEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}