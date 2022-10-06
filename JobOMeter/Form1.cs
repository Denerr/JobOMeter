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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private Form formAtivo = null;
        private void abrirChildForm(Form childForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            abrirChildForm(new frmCalculo());
        }
    }
}
