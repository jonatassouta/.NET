using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_27___CRUD
{
    public partial class FormMenu : Form
    {
        FormLogin formLogin;

        public FormMenu(FormLogin menu)
        {
            InitializeComponent();
            formLogin = menu;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void desabilitaCampos()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btmEditar.Enabled = false;
            btmCancelar.Enabled = false;
            btmRemover.Enabled = false;
            btmSalvar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;

            txtNome.Focus();
        }

        private void btmNovo_Click(object sender, EventArgs e)
        {
           // vamos obter a conexão com o banco de dados

           SqlConnection conn = conexao.obterConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {​​​​
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else
            {​​​​
                MessageBox.Show("A conexão foi obtida com sucesso.");
            }​​​​             
            // não precisamos mais da conexão? vamos fechá-la

            conexao.fecharConexao();

            habilitaCampos();
            btmSalvar.Enabled = true;
            btmNovo.Enabled = false;
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            btmNovo.Enabled = false;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatorio campo Nome");
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatorio campo Login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio campo Senha");
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    //Criar as variaveis que irão receber os valores dos textboxs
                    string login = txtLogin.Text;
                    string nome = txtNome.Text;
                    string senha = txtSenha.Text;

                    //Criar o comando de insert
                    string strSql = $"INSERT INTO tbl_atendente (ds_login, ds_senha,nome_atendente) values('{login}', '{senha}','{nome}')";

                    //criar um novo obejto com base no sqlComand, vantagem, nao declaração repetitiva
                    formLogin.objComandoSql = new SqlCommand(strSql, formLogin.cn);

                    //------pode ser usado assim tbm-------------
                    //Atribuir propiedades do sqlComand existente
                    //formLogin.objComandoSql.CommandText = strSql;
                    //formLogin.objComandoSql.Connection = formLogin.cn;

                    formLogin.cn.Open();

                    formLogin.objComandoSql.ExecuteNonQuery();

                    MessageBox.Show("Usuario Cadastrado com Sucesso", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, x.StackTrace);
                }
                finally
                {
                    formLogin.cn.Close();
                }
            }
        }
    }
}
