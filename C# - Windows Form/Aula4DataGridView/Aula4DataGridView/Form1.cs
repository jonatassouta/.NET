using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4DataGridView
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            //Definir o nome das colunas.
            //dt.Columns.Add("nomeColuna", typeof(tipo));

            dt.Columns.Add("Cursos", typeof(string));
            dt.Columns.Add("Carga Horaria", typeof(string));
            dt.Columns.Add("Instrutor", typeof(string));
            dt.Columns.Add("DDS", typeof(string));
            dt.Columns.Add("Preço", typeof(decimal));
            dt.Columns.Add("Ano", typeof(decimal));

            //1 - seg/qua/sex  2 - terc/quin  3 - 

            dt.Rows.Add(new Object[] { "Java", "40h", "João", "2", 3000, 2019});
            dt.Rows.Add(new Object[] { ".Net", "80h", "Marcos", "3", 3000, 2020});
            dt.Rows.Add(new Object[] { "Docker", "10h", "João", "1", 3000, 2020});
            dt.Rows.Add(new Object[] { "C#", "80h", "João", "1", 3000, 2021});
            dt.Rows.Add(new Object[] { "CSS", "10h", "Marta", "4", 3000, 2021});

            dataGridView1.DataSource = dt;   
        }

        private void FiltrarGrade()
        {
            // {1}% --> A % no final indica todos os nomes que começa com a letra que eu digitar, o resto nao importa.
            // '%{1}%' --> Ja dos dois lados significa que nao importa a podisao da letra que eu digitar.
            // LIKE --> string    = --> numeros

            if (txtPesquisar.Text == "")
            {
                dt.DefaultView.RowFilter = null;
            }
            else if (IsNumeric(txtPesquisar.Text))
            {
                dt.DefaultView.RowFilter = string.Format("{0} = {1}", "Ano", txtPesquisar.Text);
                dataGridView1.DataSource = dt;
            }
        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            FiltrarGrade();
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private bool IsNumeric(string valor)
        {
            return valor.All(char.IsNumber);
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FiltrarGrade();
        }
    }
}
