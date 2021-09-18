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
    public partial class FormFilhoCheck : Form
    {
        public FormCheckBox fcb;

        /*
        bool inicializado = false;
        public FormFilhoCheck()
        {
            InitializeComponent();
            fcb = Application.OpenForms["FormCheckBox"] as FormCheckBox;

            foreach (CheckBox item in Controls.OfType<CheckBox>())
            {
                item.Checked = fcb.Controls.OfType<CheckBox>().First(c => c.Name == item.Name).Checked;
            }

            inicializado = true;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (inicializado)
            {
                foreach (CheckBox item in fcb.Controls.OfType<CheckBox>())
                {
                    item.Checked = Controls.OfType<CheckBox>().First(c => c.Name == item.Name).Checked;
                }
            }
        }*/
        public FormFilhoCheck()
        {
            InitializeComponent();

            fcb = Application.OpenForms["FormCheckBox"] as FormCheckBox;
            chkWindows.Checked = fcb.chkWindows.Checked;
            chkHtmlCss.Checked = fcb.chkHtmlCss.Checked;
            chkDocker.Checked = fcb.chkDocker.Checked;
            chkCs.Checked = fcb.chkCs.Checked;
            chkAsp.Checked = fcb.chkAsp.Checked;
        }

        private void chkWindows_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chkWindows.Checked = chkWindows.Checked;
        }

        private void chkDocker_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chkDocker.Checked = chkDocker.Checked;
        }

        private void chkCs_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chkCs.Checked = chkCs.Checked;
        }

        private void chkAsp_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chkAsp.Checked = chkAsp.Checked;
        }

        private void chkHtmlCss_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chkHtmlCss.Checked = chkHtmlCss.Checked;
        }
    }
}
