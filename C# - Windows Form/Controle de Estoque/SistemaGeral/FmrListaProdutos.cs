using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGeral {
    public partial class FmrListaProdutos : Form  
    {
        public DataTable dt = new DataTable();

        string nome;
       
        public FmrListaProdutos()
        {
            InitializeComponent();
            CarregarDados();
        }

        public FmrListaProdutos(string nomeProd) {
            nome = nomeProd;
        }


        public void CarregarDados() {

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Quantidade", typeof(int));
            dt.Columns.Add("Preço", typeof(string));


            //dt.Rows.Add(new Object[] {"sdasd", 4, "sadsad"});
            //dt.Rows.Add(new Object[] { "Docker", 10, 20.8});

            dataGridView1.DataSource = dt;
        }

        private void FiltrarGrade() {

            if (txtPesquisa.Text == "") {
                dt.DefaultView.RowFilter = null;
            }
            else {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Nome", txtPesquisa.Text);
                dataGridView1.DataSource = dt;
            }
            
        }
       
        /*private bool IsNumeric(string valor) {
            return valor.All(char.IsNumber);
        }*/

        private void btmPesquisar_Click(object sender, EventArgs e) {
            FiltrarGrade();
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                FiltrarGrade();
        }

        private void btmAdd_Click(object sender, EventArgs e) {
            FormAdd fmrAdicionar = new FormAdd();
      
            fmrAdicionar.ShowDialog();
        }

        private void btmEditar_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                FormAdd p = new FormAdd();

                p.txtProduto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                p.txtQuantidade.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                p.txtPreço.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                p.ShowDialog();
            }
            else {
                MessageBox.Show("Por favor selecione uma linha!!!","Linha não Selecionada");
            }
           
        }

        public void Venda() {
            if (dataGridView1.SelectedRows.Count > 0) {
                FormAdd p = new FormAdd();

                p.btmVender.Visible = true;
                p.button2.Visible = false;
                p.txtProduto.Enabled = false;          
           
                p.txtProduto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                p.txtQuantidade.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                p.txtPreço.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                try {       
                    int q = int.Parse(p.txtQuantidade.Text);

                    if (q <= 2) {
                        MessageBox.Show("Estoque Minimo atingido!!!");
                    }
                    else {
                        p.ShowDialog();
                    }
                }
                catch (System.FormatException e) {

                    MessageBox.Show(e.Message + " Apenas numeros inteiros", "Quantidade");
                }
            }
            else {
                MessageBox.Show("Por favor selecione uma linha!!!", "Linha não Selecionada");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Venda();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            try {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Produto excluido com Sucesso!!");
            }
            catch (System.NullReferenceException) {

                MessageBox.Show("Nenhum campo selecionado!!", "Erro!!");
            }           
        }

        public void VerificarEstoque() {
            FormAdd p = new FormAdd();

        
        }
    }
}
