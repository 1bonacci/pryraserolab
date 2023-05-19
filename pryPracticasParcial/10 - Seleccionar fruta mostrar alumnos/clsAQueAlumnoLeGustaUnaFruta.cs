using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryPracticasParcial
{
    internal class clsAQueAlumnoLeGustaUnaFruta
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public clsAQueAlumnoLeGustaUnaFruta()
        {
            conector = new OleDbConnection(Properties.Settings.Default.Cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "LeGustan";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            adaptador.Fill(tabla);
        }

        public void CargaCombo(ComboBox combo)
        {
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";

            adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS, "Frutas");
            combo.DataSource = DS.Tables["Frutas"];
            combo.ValueMember = "fruta";
            combo.DisplayMember = "nombre";

        }

        public void BuscarFrutas(Int32 fruta, DataGridView gridView)
        {
            try
            {
                String sql = "SELECT Alumnos.nombre AS Alumnos FROM Alumnos INNER JOIN LeGustan ON Alumnos.dni = LeGustan.dni WHERE fruta = @fruta";
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.Cadena))
                using (OleDbCommand comm = new OleDbCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@fruta", fruta);

                    conn.Open();
                    OleDbDataReader reader = comm.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    gridView.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    }
}
