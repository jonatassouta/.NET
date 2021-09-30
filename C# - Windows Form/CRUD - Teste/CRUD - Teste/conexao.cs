﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Teste
{
    public class conexao
    {
        // vamos nos conectar ao SQL Server Express e à base de dados
        // locadora usando Windows Authentication
        private static string connString = @"server = DESKTOP-9SPM9G4\SQLEXPRESS;
        Database = crud_teste;integrated security = true;User Id=Jonatas";

        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            SqlConnection conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException)
            {
                conn = null;
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}