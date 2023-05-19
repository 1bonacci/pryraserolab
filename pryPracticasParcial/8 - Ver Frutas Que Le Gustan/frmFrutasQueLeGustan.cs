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
    public partial class frmFrutasQueLeGustan : Form
    {
        public frmFrutasQueLeGustan()
        {
            InitializeComponent();
        }

        clsFrutasQueGustan clsFrutasQueGustan = new clsFrutasQueGustan();

        private void frmFrutasQueLeGustan_Load(object sender, EventArgs e)
        {
            clsFrutasQueGustan.CargaCombo(cboAlumno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsFrutasQueGustan.BuscarFrutas(Convert.ToInt32(cboAlumno.SelectedValue), dataGridView1);
        }
    }
}
