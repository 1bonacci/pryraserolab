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
    internal class clsFrutasQueNoLeGustan
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public clsFrutasQueNoLeGustan()
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
                String sql = "SELECT Frutas.nombre AS Fruta FROM Frutas LEFT JOIN (SELECT fruta FROM LeGustan WHERE dni = @dni) AS LG ON Frutas.fruta = LG.fruta WHERE LG.fruta IS NULL";
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
