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
    internal class clsAgregarEliminarFrutas
    {
        string Tabla = "LeGustan";

        private Int32 fruta;
        private Int32 dni;

        public Int32 Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }

        public Int32 Dni
        {
            get { return dni; }
            set { dni = value; }
        }



        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adap;
        private DataTable dtA;

        public clsAgregarEliminarFrutas()
        {
            conn = new OleDbConnection(Properties.Settings.Default.Cadena);
            comm = new OleDbCommand();

            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "LeGustan";

            adap = new OleDbDataAdapter(comm);
            dtA = new DataTable();
            adap.Fill(dtA);
        }

        public void CargaComboFrutas(ComboBox combo)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "Frutas";

            adap = new OleDbDataAdapter(comm);
            DataSet DS = new DataSet();
            adap.Fill(DS, "Frutas");
            combo.DataSource = DS.Tables["Frutas"];
            combo.ValueMember = "fruta";
            combo.DisplayMember = "nombre";

        }

        public void CargaComboAlumnos(ComboBox combo)
        {
            comm.Connection = conn;
            comm.CommandType = CommandType.TableDirect;
            comm.CommandText = "Alumnos";

            adap = new OleDbDataAdapter(comm);
            DataSet DS = new DataSet();
            adap.Fill(DS, "Alumnos");
            combo.DataSource = DS.Tables["Alumnos"];
            combo.ValueMember = "dni";
            combo.DisplayMember = "nombre";

        }

        public void Agregar()
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
                fila["fruta"] = Fruta;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adap);
                adap.Update(DS, Tabla);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void Eliminar(Int32 dni, Int32 codigoFruta)
        {
            try
            {
                String sql = "DELETE FROM LeGustan WHERE dni = @dni AND fruta = @codigoFruta";
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.Cadena))
                using (OleDbCommand comm = new OleDbCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@dni", dni);
                    comm.Parameters.AddWithValue("@codigoFruta", codigoFruta);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



    }

}
