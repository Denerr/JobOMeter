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

        private void formataHora(string text)
        {
            if (text.Length == 4)
            {
                //string hora = string.Empty;
                //hora = ;
                //text = long.Parse(Convert.ToString(hora)).ToString("00:00");
                string hora;
                string min;
                text = long.Parse(Convert.ToString(text)).ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEntUm_Leave(object sender, EventArgs e)
        {
            formataHora(txtEntUm.Text);
        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAno.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAno.SelectedIndex = 0;
            txtEntUm.Text = "";
            txtEntDois.Text = "";
            txtSaiUm.Text = "";
            txtSaiDois.Text = "";
        }

        private void txtSaiUm_Leave(object sender, EventArgs e)
        {
            formataHora(txtSaiUm.Text);
        }

        private void txtEntDois_Leave(object sender, EventArgs e)
        {
            formataHora(txtEntDois.Text);
        }

        private void txtSaiDois_Leave(object sender, EventArgs e)
        {
            formataHora(txtSaiDois.Text);
        }
    }
}
