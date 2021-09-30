using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Novo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
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
            habilitaCampos();
            btmSalvar.Enabled = true;
            btmNovo.Enabled = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            if (dgvfunc.SelectedRows.Count > 0)
            {
                int index = dgvfunc.SelectedRows[0].Index;

                if (index >= 0)
                    dgvfunc.Rows[index].Selected = false;
            }
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;
            btmNovo.Enabled = false;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório campos nome");
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório campos login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campos senha");
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string login = txtLogin.Text;
                    string nome = txtNome.Text;
                    string senha = txtSenha.Text;

                    string strSql = $"insert into tbl_atendente (ds_login, ds_senha, nome_atendente) values ('{login}','{senha}','{nome}');";

                    objComandoSql = new SqlCommand(strSql, conn);

                    //conn.Open();

                    objComandoSql.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
                    conn.Close();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = conn;
            if (txtPesquisar.Text != "")
            {
                try
                {
                    objComandoSql.CommandText = "Select * from tbl_atendente where nome_atendente like ('%" + txtPesquisar.Text + "%')";
                    objComandoSql.Connection = conn;


                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = objComandoSql;
                    da.Fill(dt); //preenche o data table

                    dgvfunc.DataSource = dt;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("\n" + erro);
                    conn.Close();
                }
            }
            else
            {
                dgvfunc.DataSource = null;
                conn.Close();
            }
        }

        public void carregarAtendente()
        {
            lblCod.Text = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txtLogin.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txtNome.Text = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            txtSenha.Text = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();

            habilitaCampos();
            btmNovo.Enabled = false;
            btmSalvar.Enabled = false;
            btmEditar.Enabled = true;
            btmRemover.Enabled = true;
            btmCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void dgvfunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarAtendente();
            
        }

        public void verificarCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório campos nome");
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório campos login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campos senha");
                txtSenha.Focus();
            }
        }

        private void btmEditar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comandosql = new SqlCommand();

            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório campos nome");
                txtNome.Focus();
            }
            else if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório campos login");
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campos senha");
                txtSenha.Focus();
            }
            else
            {
                try
                {
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;
                    int cd = Convert.ToInt32(lblCod.Text);

                    string strSql = "update tbl_atendente set ds_login = @login,ds_senha=@senha,nome_atendente=@nome where id_atendente=@id";

                    comandosql.CommandText = strSql;
                    comandosql.Connection = conn;

                    comandosql.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    comandosql.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    comandosql.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    comandosql.Parameters.Add("@id", SqlDbType.Int).Value = cd;

                    comandosql.ExecuteNonQuery();
                    comandosql.Parameters.Clear();

                    dgvfunc.Refresh();

                    MessageBox.Show("Dados alterados com sucesso");
                    limparTextBoxes(this.Controls);
                    lblCod.Text = "Codigo";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu Ruim\n" + erro.Message);            
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btmRemover_Click(object sender, EventArgs e)
        {
            SqlConnection conn = conexao.obterConexao();
            SqlCommand comando = new SqlCommand();

            string nome = txtNome.Text;

            if (DialogResult.Yes == MessageBox.Show($"Tem certeza que deseja excluir o funcionario {nome}? ", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    int id = Convert.ToInt32(lblCod.Text);

                    string strSQL = $"delete from tbl_atendente where id_atendente='{id}' ";

                    comando.CommandText = strSQL;
                    comando.Connection = conn;

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados removidos com sucesso");
                    limparTextBoxes(this.Controls);
                    lblCod.Text = "Codigo";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado" + erro);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                limparTextBoxes(this.Controls);
                lblCod.Text = "Código";
                conn.Close();
            }
        }
    }
}


//// vamos obter a conexão com o banco de dados

//SqlConnection conn = conexao.obterConexao();

//// a conexão foi efetuada com sucesso?
//if (conn == null)
//{
//    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
//}
//else
//{
//    MessageBox.Show("A conexão foi obtida com sucesso.");
//}
//// não precisamos mais da conexão? vamos fechá-la

//conexao.fecharConexao();