
namespace Aula_27___CRUD
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btmNovo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.btmEditar = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.btmRemover = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btmNovo
            // 
            this.btmNovo.Location = new System.Drawing.Point(618, 23);
            this.btmNovo.Name = "btmNovo";
            this.btmNovo.Size = new System.Drawing.Size(113, 40);
            this.btmNovo.TabIndex = 1;
            this.btmNovo.Text = "Novo";
            this.btmNovo.UseVisualStyleBackColor = true;
            this.btmNovo.Click += new System.EventHandler(this.btmNovo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(239, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 31);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pesquisar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Funcionarios";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(239, 136);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 31);
            this.txtLogin.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(239, 184);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(218, 31);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(239, 284);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(331, 31);
            this.txtPesquisar.TabIndex = 10;
            // 
            // btmSalvar
            // 
            this.btmSalvar.Location = new System.Drawing.Point(618, 69);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(113, 40);
            this.btmSalvar.TabIndex = 11;
            this.btmSalvar.Text = "Salvar";
            this.btmSalvar.UseVisualStyleBackColor = true;
            this.btmSalvar.Click += new System.EventHandler(this.btmSalvar_Click);
            // 
            // btmEditar
            // 
            this.btmEditar.Location = new System.Drawing.Point(618, 115);
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(113, 40);
            this.btmEditar.TabIndex = 12;
            this.btmEditar.Text = "Editar";
            this.btmEditar.UseVisualStyleBackColor = true;
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(618, 207);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(113, 40);
            this.btmCancelar.TabIndex = 13;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            // 
            // btmRemover
            // 
            this.btmRemover.Location = new System.Drawing.Point(618, 161);
            this.btmRemover.Name = "btmRemover";
            this.btmRemover.Size = new System.Drawing.Size(113, 40);
            this.btmRemover.TabIndex = 14;
            this.btmRemover.Text = "Remover";
            this.btmRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(618, 253);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNovo.Size = new System.Drawing.Size(113, 40);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "button1";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 483);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btmRemover);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btmEditar);
            this.Controls.Add(this.btmSalvar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btmNovo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmNovo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.Button btmEditar;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Button btmRemover;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
    }
}