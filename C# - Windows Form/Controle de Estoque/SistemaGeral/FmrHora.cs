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
    public partial class FmrHora : Form {
        public FmrHora()
        {
            InitializeComponent();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelData.Text = DateTime.Now.ToLongDateString();
        }
    }
}
