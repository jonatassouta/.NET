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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        //Conexão com o BD
        public SqlConnection cn = new SqlConnection(
            @"Data Source=DESKTOP-9SPM9G4\SQLEXPRESS;
            Initial Catalog=db_livraria;
            integrated Security=true;
            User Id=Jonatas"
            );

        //Objeto que ira ser chamada para Conseguir mandar e exucutar os comandos SQL (SELECT INSERT UPDATE DELETE)
        public SqlCommand objComandoSql = new SqlCommand();

        //Variavel do tipo sqlDataReader que recebe o resultado dos comandos objComandoSql
        public SqlDataReader dt;

        private void btmAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos Login e Senha");
                txtLogin.Focus();
            }
            else
            {
                try
                {
                    //Abrir a conexão
                    objComandoSql.Connection = cn;
                    cn.Open();

                    //Qual comando e quero usar - consultar conteudo textbox---->som mostra o comando mai snao executa
                    objComandoSql.CommandText = "select * from tbl_atendente where ds_login=('"+txtLogin.Text+"') and ds_senha=('"+txtSenha.Text+"')";
                    //Executar os comandos sql
                    dt = objComandoSql.ExecuteReader();
                    //Verificar o resultado de dt
                    if (dt.HasRows)//if(se dt gerou linhas)
                    {
                        //MessageBox.Show("Usuario Existe");
                        FormMenu menu = new FormMenu(this);
                        menu.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha Invalido.");
                        cn.Close();
                    }          
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
