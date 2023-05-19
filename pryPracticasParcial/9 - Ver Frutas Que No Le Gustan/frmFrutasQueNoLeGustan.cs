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
    public partial class frmFrutasQueNoLeGustan : Form
    {
        public frmFrutasQueNoLeGustan()
        {
            InitializeComponent();
        }
        clsFrutasQueNoLeGustan Frutas = new clsFrutasQueNoLeGustan();
        private void frmFrutasQueNoLeGustan_Load(object sender, EventArgs e)
        {
            Frutas.CargaCombo(cboAlumno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 Alumno = Convert.ToInt32(cboAlumno.SelectedValue);
            Frutas.BuscarFrutas(Alumno,dataGridView1);
        }
    }
}
