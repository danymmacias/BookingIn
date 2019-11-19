using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dentalsof
{
        //APLICACIÓN DE BRIDGE Y FACADE
        public abstract class baseDeDatos
        {
            SqlCommand cmd;
            SqlDataReader dr;
            private DataSet ds;

            String cadenaConexion = "Data Source=LAPTOP-11JL0HU6\\PRUEBA;Initial Catalog=DENTALSOFT;Integrated Security=True";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-11JL0HU6\\PRUEBA;Initial Catalog=DENTALSOFT;Integrated Security=True");

            private void abrirConexion()
            {
                this.cn.Open();
            }

            private void cerrarConexion()
            {
                this.cn.Close();
            }

            private SqlDataAdapter consultar(String query)
            {
                this.abrirConexion();
                SqlCommand cmd = new SqlCommand("Select * from tratamientos", cn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                this.cerrarConexion();
                return ad;

            }
        }
}
