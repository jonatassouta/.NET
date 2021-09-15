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
    public partial class FmrInicial : Form
    {
        public FmrInicial()
        {
            InitializeComponent();
        }

        //Função para abrir o formulario

        private void AbrirFomularioFilho(object formulariofilho)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            
            Form fh = formulariofilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void btmProduto_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FmrProduto());
        }

        private void btmCliente_Click(object sender, EventArgs e)
        {
            FrmCadClientes fcadclientes = new FrmCadClientes();
            fcadclientes.Show();
        }

        private void btmAjuda_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FmrAjuda());
        }
    }
}
