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
    public partial class frmVerTodosLosClientes_dgv_ : Form
    {
        public frmVerTodosLosClientes_dgv_()
        {
            InitializeComponent();
        }
        clsVerTodosLosAlumnos clsVerTodosLosAlumnos = new clsVerTodosLosAlumnos();
        private void frmVerTodosLosClientes_dgv__Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            clsVerTodosLosAlumnos.MostrarGrilla(dataGridView1);
        }
    }
}
