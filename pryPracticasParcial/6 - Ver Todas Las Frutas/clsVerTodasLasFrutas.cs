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
    internal class clsVerTodasLasFrutas
    {
        string Tabla = "Frutas";
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adap;
        private DataTable dtA;
        public clsVerTodasLasFrutas()
        {
            conn = new OleDbConnection(Properties.Settings.Default.Cadena);
            comm = new OleDbCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "Frutas";

            adap = new OleDbDataAdapter(comm);
            dtA = new DataTable();
            adap.Fill(dtA);

        }

        public void MostrarGrilla(DataGridView grilla)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = Tabla;
            adap = new OleDbDataAdapter(comm);
            DataSet DS = new DataSet();
            adap.Fill(DS, Tabla);
            grilla.Rows.Clear();
            if (DS.Tables[Tabla].Rows.Count > 0)
            {
                foreach (DataRow fila in DS.Tables[Tabla].Rows)
                {

                    
                    grilla.Rows.Add(fila["fruta"], fila["nombre"]);
                }
            }
        }
    }
}
