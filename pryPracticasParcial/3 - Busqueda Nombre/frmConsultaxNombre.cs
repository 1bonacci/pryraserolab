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
    public partial class frmConsultaxNombre : Form
    {
        public frmConsultaxNombre()
        {
            InitializeComponent();
        }

        clsBusquedaxNom clsBusquedaxNom = new clsBusquedaxNom();
        private void frmConsultaxNombre_Load(object sender, EventArgs e)
        {
            clsBusquedaxNom.CargaCombo(cboBarrio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBusquedaxNom.BuscarxNOM(txtNombre.Text);
            txtDNI.Text = clsBusquedaxNom.Dni.ToString();
            txtFoto.Text = clsBusquedaxNom.Foto.ToString();
            txtSexo.Text = clsBusquedaxNom.Sexo.ToString();
            cboBarrio.SelectedValue = clsBusquedaxNom.Barrio.ToString();
        }
    }
}
