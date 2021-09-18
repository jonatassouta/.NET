using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_By_Jonatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navegar()
        {
            webBrowser1.Navigate(txtPesquisa.Text);
        }

        private void btmNavegar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                navegar();
            }
            else
            {
                MessageBox.Show("Digite uma URL");
                txtPesquisa.Focus();
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navegar();
            }
        }
    }
}
