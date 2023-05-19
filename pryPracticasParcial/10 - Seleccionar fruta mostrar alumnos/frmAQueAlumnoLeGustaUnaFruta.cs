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
    public partial class frmAQueAlumnoLeGustaUnaFruta : Form
    {
        public frmAQueAlumnoLeGustaUnaFruta()
        {
            InitializeComponent();
        }
        clsAQueAlumnoLeGustaUnaFruta Fruta = new clsAQueAlumnoLeGustaUnaFruta();
        private void frmAQueAlumnoLeGustaUnaFruta_Load(object sender, EventArgs e)
        {
            Fruta.CargaCombo(cboFruta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 fruta = Convert.ToInt32(cboFruta.SelectedValue);
            Fruta.BuscarFrutas(fruta, dataGridView1);
        }
    }
}
