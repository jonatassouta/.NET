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
    public partial class FormAdd : Form {

        public FmrListaProdutos p;
        public FormAdd() {
            InitializeComponent();
            p = Application.OpenForms["FmrListaProdutos"] as FmrListaProdutos;
        }


        public void AdicionarTabela() {
            try {
                p.dt.Rows.Add(new Object[] { txtProduto.Text, txtQuantidade.Text, txtPreço.Text });

               
            }
            catch (System.ArgumentException) {

                MessageBox.Show("Quantidade: Apenas numeros inteiros.\nPreço: numeros inteiros ou decimal", "Quantidade / Preço");
            }

            MessageBox.Show("Produto adicionado com sucesso!!");

            txtPreço.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtProduto.Focus();
        }

        private void button2_Click(object sender, EventArgs e) {
            AdicionarTabela();
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void txtPreço_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                AdicionarTabela();
        }

        public void Venda() {
           
        }

        private void FormAdd_Load(object sender, EventArgs e) {

        }

        private void btmVender_Click(object sender, EventArgs e) {
            
            int t = int.Parse(p.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int q = int.Parse(txtQuantidade.Text);

            

            p.dataGridView1.Rows.RemoveAt(p.dataGridView1.CurrentRow.Index);
           
            try {
                t -= q;

                p.dt.Rows.Add(new Object[] { txtProduto.Text, t , txtPreço.Text });
                MessageBox.Show("Venda efetuada");
            }
            catch (System.ArgumentException) {

                MessageBox.Show("Quantidade: Apenas numeros inteiros.\nPreço: numeros inteiros ou decimal", "Quantidade / Preço");
            }

            txtPreço.Text = "";
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtProduto.Focus();
        }
    }
}
