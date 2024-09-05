using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones.Windows.Formularios
{
    public partial class frmFiltroTexto : Form
    {
        private string textoBusqueda = string.Empty;
        public frmFiltroTexto()
        {
            InitializeComponent();
        }
        public string GetTexto() => textoBusqueda;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTexto.Text.Trim()))
            {
                textoBusqueda = txtTexto.Text.Trim();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
