using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPracticasParcial
{
    public partial class frmNuevaFruta : Form
    {
        public frmNuevaFruta()
        {
            InitializeComponent();
        }
        clsAgregarFrutas clsAgregarFrutas = new clsAgregarFrutas();
        private void button1_Click(object sender, EventArgs e)
        {
            clsAgregarFrutas.Codigo = Convert.ToInt32(txtCodigo.Text);
            clsAgregarFrutas.Nombre = txtNombre.Text;
            clsAgregarFrutas.CargaFrutas();
        }
    }
}
