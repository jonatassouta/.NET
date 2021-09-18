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
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCombo.Text != "")
            {
                if (comboBox.FindString(txtCombo.Text) < 0)
                {
                    comboBox.Items.Add(txtCombo.Text);
                    txtCombo.Text = "";
                    txtCombo.Focus();
                }
                else
                {
                    MessageBox.Show("Já existe");
                    txtCombo.Text = "";
                    txtCombo.Focus();
                }     
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox.Items.Remove(comboBox.Text);
        }
    }
}
