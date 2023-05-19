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
    public partial class frmVerTodasLasFrutas : Form
    {
        public frmVerTodasLasFrutas()
        {
            InitializeComponent();
        }
        clsVerTodasLasFrutas clsVerTodasLasFrutas = new clsVerTodasLasFrutas();
        private void frmVerTodasLasFrutas_Load(object sender, EventArgs e)
        {
            clsVerTodasLasFrutas.MostrarGrilla(dataGridView1);
        }
    }
}
