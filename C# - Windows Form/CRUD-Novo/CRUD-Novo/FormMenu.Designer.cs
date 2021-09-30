
namespace CRUD_Novo
{
    partial class FormMenu
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvfunc = new System.Windows.Forms.DataGridView();
            this.btmRemover = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.btmEditar = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btmNovo = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(635, 271);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(113, 40);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Limpar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // dgvfunc
            // 
            this.dgvfunc.AllowUserToAddRows = false;
            this.dgvfunc.AllowUserToDeleteRows = false;
            this.dgvfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfunc.Location = new System.Drawing.Point(36, 359);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfunc.Size = new System.Drawing.Size(719, 150);
            this.dgvfunc.TabIndex = 49;
            this.dgvfunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvfunc_MouseDoubleClick);
            // 
            // btmRemover
            // 
            this.btmRemover.Location = new System.Drawing.Point(635, 179);
            this.btmRemover.Name = "btmRemover";
            this.btmRemover.Size = new System.Drawing.Size(113, 40);
            this.btmRemover.TabIndex = 6;
            this.btmRemover.Text = "Remover";
            this.btmRemover.UseVisualStyleBackColor = true;
            this.btmRemover.Click += new System.EventHandler(this.btmRemover_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(635, 225);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(113, 40);
            this.btmCancelar.TabIndex = 7;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            // 
            // btmEditar
            // 
            this.btmEditar.Location = new System.Drawing.Point(635, 133);
            this.btmEditar.Name = "btmEditar";
            this.btmEditar.Size = new System.Drawing.Size(113, 40);
            this.btmEditar.TabIndex = 5;
            this.btmEditar.Text = "Editar";
            this.btmEditar.UseVisualStyleBackColor = true;
            this.btmEditar.Click += new System.EventHandler(this.btmEditar_Click);
            // 
            // btmSalvar
            // 
            this.btmSalvar.Location = new System.Drawing.Point(635, 87);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(113, 40);
            this.btmSalvar.TabIndex = 4;
            this.btmSalvar.Text = "Salvar";
            this.btmSalvar.UseVisualStyleBackColor = true;
            this.btmSalvar.Click += new System.EventHandler(this.btmSalvar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(256, 302);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(331, 33);
            this.txtPesquisar.TabIndex = 9;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(256, 228);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(218, 33);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(256, 180);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(218, 33);
            this.txtLogin.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(29, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 42);
            this.label6.TabIndex = 41;
            this.label6.Text = "Funcionarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Pesquisar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(256, 133);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 33);
            this.txtNome.TabIndex = 0;
            // 
            // btmNovo
            // 
            this.btmNovo.Location = new System.Drawing.Point(635, 41);
            this.btmNovo.Name = "btmNovo";
            this.btmNovo.Size = new System.Drawing.Size(113, 40);
            this.btmNovo.TabIndex = 3;
            this.btmNovo.Text = "Novo";
            this.btmNovo.UseVisualStyleBackColor = true;
            this.btmNovo.Click += new System.EventHandler(this.btmNovo_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(388, 95);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(86, 24);
            this.lblCod.TabIndex = 34;
            this.lblCod.Text = "Codigo";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 521);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvfunc);
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
            this.Controls.Add(this.lblCod);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvfunc;
        private System.Windows.Forms.Button btmRemover;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Button btmEditar;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btmNovo;
        private System.Windows.Forms.Label lblCod;
    }
}

