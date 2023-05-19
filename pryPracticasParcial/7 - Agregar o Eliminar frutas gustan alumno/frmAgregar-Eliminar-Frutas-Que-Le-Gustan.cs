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
    public partial class frmAgregar_Eliminar_Frutas_Que_Le_Gustan : Form
    {
        public frmAgregar_Eliminar_Frutas_Que_Le_Gustan()
        {
            InitializeComponent();
        }

        clsAgregarEliminarFrutas clsAgregarEliminarFrutas = new clsAgregarEliminarFrutas();
        private void frmAgregar_Eliminar_Frutas_Que_Le_Gustan_Load(object sender, EventArgs e)
        {
            clsAgregarEliminarFrutas.CargaComboFrutas(cboFrutas);
            clsAgregarEliminarFrutas.CargaComboAlumnos(cboAlumnos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsAgregarEliminarFrutas.Fruta = Convert.ToInt32(cboFrutas.SelectedValue);
            clsAgregarEliminarFrutas.Dni = Convert.ToInt32(cboAlumnos.SelectedValue);
            clsAgregarEliminarFrutas.Agregar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 fruta = clsAgregarEliminarFrutas.Fruta = Convert.ToInt32(cboFrutas.SelectedValue);
            Int32 dni= clsAgregarEliminarFrutas.Dni = Convert.ToInt32(cboAlumnos.SelectedValue);
            clsAgregarEliminarFrutas.Eliminar(dni,fruta);
        }
    }
}
