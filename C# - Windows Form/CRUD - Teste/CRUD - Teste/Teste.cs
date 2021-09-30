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

namespace CRUD___Teste
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void btmNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
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
            else
            {
                try
                {
                    string nome = txtNome.Text;

                    string strSql = $"insert into cliente (nome) values ('{nome}');";

                    objComandoSql = new SqlCommand(strSql, conn);

                    //conn.Open();

                    objComandoSql.ExecuteNonQuery();

                    MessageBox.Show("Cadastrado com Sucesso!!");
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
    }
}
