using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace pryPracticasParcial
{
    internal class clsNuevoAlumno
    {
        private string nombre;
        private int dni;
        private string sexo;
        private string foto;
        private int barrio;

        public String Tabla = "Alumnos";

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Sexo
        {
            get { return sexo; } 
            set { sexo = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public int Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }


        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adap;
        private DataTable dtA;
        public clsNuevoAlumno()
        {
            conn = new OleDbConnection(Properties.Settings.Default.Cadena);
            comm = new OleDbCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "Alumnos";

            adap = new OleDbDataAdapter(comm);
            dtA = new DataTable();
            adap.Fill(dtA);
            
        }

        public void CargaCombo(ComboBox combo)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "Barrios";

            adap = new OleDbDataAdapter(comm);
            DataSet DS = new DataSet();
            adap.Fill(DS, "Barrios");
            combo.DataSource = DS.Tables["Barrios"];
            combo.ValueMember = "barrio";
            combo.DisplayMember = "nombre";

        }

        public void CargaAlumnos()
        {
            try
            {
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = Tabla;
                adap = new OleDbDataAdapter(comm);
                DataSet DS = new DataSet();
                adap.Fill(DS, Tabla);
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["dni"] = Dni;
                fila["nombre"] = Nombre;
                fila["sexo"] = Sexo;
                fila["foto"] = Foto;
                fila["barrio"] = Barrio;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adap);
                adap.Update(DS, Tabla);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

    }
}
