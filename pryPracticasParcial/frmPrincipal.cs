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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoAlumno NuevoAlumno = new frmNuevoAlumno();
            NuevoAlumno.ShowDialog();
        }

        private void consultarAlumnoPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaXDNI frmConsultaXDNI = new frmConsultaXDNI();
            frmConsultaXDNI.ShowDialog();
        }

        private void consultarAlumnoPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaxNombre frmConsultaxNombre = new frmConsultaxNombre();
            frmConsultaxNombre.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTodosLosClientes_dgv_ frmVerTodosLosClientes_Dgv_ = new frmVerTodosLosClientes_dgv_();
            frmVerTodosLosClientes_Dgv_.ShowDialog();
        }

        private void nuevaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaFruta frmFrutaNueva = new frmNuevaFruta();
            frmFrutaNueva.ShowDialog();
        }

        private void verTodasLasFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTodasLasFrutas frmVerTodasLasFrutas = new frmVerTodasLasFrutas();
            frmVerTodasLasFrutas.ShowDialog();
        }

        private void agregarOQuitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar_Eliminar_Frutas_Que_Le_Gustan frmAgregar_Eliminar_Frutas_Que_Le_Gustan = new frmAgregar_Eliminar_Frutas_Que_Le_Gustan();
            frmAgregar_Eliminar_Frutas_Que_Le_Gustan.ShowDialog();
        }

        private void verFrutasQueLeGustanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasQueLeGustan frmFrutasQueLeGustan = new frmFrutasQueLeGustan();
            frmFrutasQueLeGustan.ShowDialog();
        }

        private void queFrutasNoLeGustanLosALumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrutasQueNoLeGustan frmFrutasQueNoLeGustan = new frmFrutasQueNoLeGustan();
            frmFrutasQueNoLeGustan.ShowDialog();
        }

        private void queAlumnoLeGustaUnaFrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAQueAlumnoLeGustaUnaFruta fruta= new frmAQueAlumnoLeGustaUnaFruta();
            fruta.ShowDialog();
        }
    }
}
