using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "LAPTOP-OFMGDRLU\\SQLEXPRESS";
        private static string dataBase = "GestiondeLacteosV1";

        public static SqlConnection conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={dataBase};Integrated Security=true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-OFMGDRLU\\SQLEXPRESS;Initial Catalog=GestiondeLacteosV1;Integrated Security=True");

        public void abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }


    }
}
