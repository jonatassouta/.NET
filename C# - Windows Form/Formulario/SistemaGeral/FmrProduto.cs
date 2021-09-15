using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGeral
{
    public partial class FmrProduto : Form
    {
        public FmrProduto()
        {
            InitializeComponent();
        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro efetuado com sucesso!!!");
        }

        private void btmImprimirProd_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(txtPreçoProd.Text);

            MessageBox.Show($"Nome do Produto: {txtProduto.Text} \nQuantidade: {txtProdQuantidade.Text}\nPreço: {preco}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
