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
    
    internal class clsAgregarFrutas
    {
        private string nombre;
        private int codigo;
        string Tabla = "Frutas";
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adap;
        private DataTable dtA;
        public clsAgregarFrutas()
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
        public void CargaFrutas()
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
                fila["fruta"] = Codigo;
                fila["nombre"] = Nombre;
                
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
