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
    internal class clsFrutasQueGustan
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        string Tabla = "LeGustan";




        public clsFrutasQueGustan()
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
            comando.CommandText = "Alumnos";

            adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS, "Alumnos");
            combo.DataSource = DS.Tables["Alumnos"];
            combo.ValueMember = "dni";
            combo.DisplayMember = "nombre";

        }


        public void BuscarFrutas(Int32 dni, DataGridView gridView)
        {
            try
            {
                String sql = "SELECT Frutas.nombre AS Frutas FROM LeGustan INNER JOIN Frutas ON LeGustan.fruta = Frutas.fruta WHERE dni = @dni";
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.Cadena))
                using (OleDbCommand comm = new OleDbCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@dni", dni);

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
