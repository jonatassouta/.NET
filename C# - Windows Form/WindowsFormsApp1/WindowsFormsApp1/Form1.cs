using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCheckBox formcheck = new FormCheckBox();

            formcheck.Show();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormComboBox fmrCombo = new FormComboBox();

            fmrCombo.Show();
        }

        private void adicionarComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
