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
    public partial class FormCheckBox : Form
    {
        List<CheckBox> cursos = new List<CheckBox>();

        public FormCheckBox()
        {
            InitializeComponent();

            cursos.Add(chkWindows);
            cursos.Add(chkDocker);
            cursos.Add(chkHtmlCss);
            cursos.Add(chkCs);
            cursos.Add(chkAsp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox c in cursos)
            {
                if (c.Checked)
                {
                    txt += c.Text + ", ";
                }
            }

            /*
            if (chkWindows.Checked)
            {
                txt += chkWindows.Text + ", ";
            }
            if (chkDocker.Checked)
            {
                txt += chkDocker.Text + ", ";
            }
            if (chkHtmlCss.Checked)
            {
                txt += chkHtmlCss.Text + ", ";
            }
            if (chkCs.Checked)
            {
                txt += chkCs.Text + ", ";
            }
            if (chkAsp.Checked)
            {
                txt += chkAsp.Text + ", ";
            }*/

            MessageBox.Show(txt);
        }

        private void btmChamarFormFilo_Click(object sender, EventArgs e)
        {
            FormFilhoCheck junior = new FormFilhoCheck();
            junior.Show();
        }
    }
}
