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
    public partial class frmNuevoAlumno : Form
    {
        public frmNuevoAlumno()
        {
            InitializeComponent();
        }
        clsNuevoAlumno clsNuevoAlumno = new clsNuevoAlumno();
        private void frmNuevoAlumno_Load(object sender, EventArgs e)
        {
            clsNuevoAlumno.CargaCombo(cboBarrio);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SEXO = "";
            clsNuevoAlumno.Nombre = txtNombre.Text;
            clsNuevoAlumno.Dni = (Convert.ToInt32(txtDNI.Text));
            clsNuevoAlumno.Foto = txtFoto.Text;
            if (rbF.Checked == true)
            {
                SEXO = "F";
            }
            if (rbM.Checked == true)
            {
                SEXO = "M";
            }
            clsNuevoAlumno.Sexo = SEXO;
            clsNuevoAlumno.Barrio = (Convert.ToInt32(cboBarrio.SelectedValue));

            clsNuevoAlumno.CargaAlumnos();
        }
    }
}
