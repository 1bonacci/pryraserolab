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
    public partial class frmConsultaXDNI : Form
    {
        public frmConsultaXDNI()
        {
            InitializeComponent();
        }

        clsBusquedaxDNI busquedaxDNI = new clsBusquedaxDNI();
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            busquedaxDNI.BuscarxDNI((Convert.ToInt32(txtDNI.Text)));
            txtNombre.Text = busquedaxDNI.Nombre;
            txtSexo.Text = busquedaxDNI.Sexo;
            txtFoto.Text = busquedaxDNI.Foto;
            cboBarrio.SelectedValue = busquedaxDNI.Barrio.ToString();


        }

        private void frmConsultaXDNI_Load(object sender, EventArgs e)
        {
            busquedaxDNI.CargaCombo(cboBarrio);
        }
    }
}
