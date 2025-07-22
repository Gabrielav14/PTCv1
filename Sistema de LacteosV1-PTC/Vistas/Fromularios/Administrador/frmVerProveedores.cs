using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Fromularios.Administrador
{
    public partial class frmVerProveedores : Form
    {
        public frmVerProveedores()
        {
            InitializeComponent();
            MostrarProveedores();

        }
        private void MostrarProveedores()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            SqlCommand comandoSql = new SqlCommand("SELECT * FROM Proveedores", conexionDB.conexion);
            SqlDataAdapter adaptadorSql = new SqlDataAdapter(comandoSql);
            DataTable tabla = new DataTable();
            adaptadorSql.Fill(tabla);
            dvgProveedores.DataSource = tabla;
            dvgProveedores.AutoGenerateColumns = true;
            conexionDB.cerrar();
        }


        private void frmVerProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dvgProveedores.SelectedRows.Count > 0)
            {
                int idProveedor = Convert.ToInt32(dvgProveedores.SelectedRows[0].Cells["idProveedor"].Value);

                ConexionDB conexionDB = new ConexionDB();
                conexionDB.conexion.Open();
                SqlCommand comandoSql = new SqlCommand("DELETE FROM Proveedores WHERE idProveedor = @id", conexionDB.conexion);
                comandoSql.Parameters.AddWithValue("@id", idProveedor);
                comandoSql.ExecuteNonQuery();
                conexionDB.cerrar();

                MessageBox.Show("Proveedor eliminado correctamente.");
                MostrarProveedores();
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");

            }
        }
    }
}

