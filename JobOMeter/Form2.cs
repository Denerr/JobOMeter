using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobOMeter
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEntUm_Leave(object sender, EventArgs e)
        {
            if(txtEntUm.TextLength == 4)
            {
                string hora = string.Empty;
                hora = txtEntUm.Text;
                txtEntUm.Text = long.Parse(Convert.ToString(hora)).ToString("00:00");
            }
        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAno.SelectedIndex = 0;
        }
    }
}
