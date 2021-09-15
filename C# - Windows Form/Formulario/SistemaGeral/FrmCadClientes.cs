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
    public partial class FrmCadClientes : Form
    {
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        private void salvarRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagem Salva!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro apagado com sucesso!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string radio = "";
            double cpf = double.Parse(txtCpf.Text);
            double cep = double.Parse(txtCep.Text);
            int telefone = int.Parse(txtTelefone.Text);

            if (radioButton1.Checked == true)
            {
                radio = "Feminino";
            }
            else if (radioButton2.Checked == true)
            {
                radio = "Masculino";
            }

            MessageBox.Show($"Nome: {txtNome.Text} \n" +
                $"Endereço: {txtEndereco.Text} \n" +
                $"CEP: {cep} \n" +
                $"CPF: {cpf} \n" +
                $"Telefone: {telefone} \n" +
                $"Cidade: {txtCidade.Text} / {comboEstados.Text} \n" +
                $"Sexo: {radio}\n" +
                $"Data de Nascimento:\n {data.Text}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCep.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtCidade.Text = "";
            comboEstados.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salva com Sucesso!!!");
        }
    }
}
