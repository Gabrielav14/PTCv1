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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            CargarUnidadMedida();
            MostrarProductos();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        { 

        }
        private void CargarUnidadMedida()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            SqlCommand comandoSQL = new SqlCommand("SELECT idUnidadMedida, nombreUnidad FROM UnidadMedida", conexionDB.conexion);
            SqlDataReader lector = comandoSQL.ExecuteReader();

            cmbUnidadMedida.Items.Clear();

            while (lector.Read())
            {
                cmbUnidadMedida.Items.Add(new
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1)
                });
            }

            conexionDB.cerrar();
        }

            private void MostrarProductos()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            SqlCommand comandoSQL = new SqlCommand(@"SELECT p.idProducto, p.nombreProducto, p.precioUnitario, 
    u.nombreUnidad AS UnidadMedida, p.fechaEntrada, p.fechaVencimiento
    FROM Productos p
    JOIN UnidadMedida u ON p.id_UnidadMedida = u.idUnidadMedida", conexionDB.conexion);

            SqlDataAdapter adaptadorSQL = new SqlDataAdapter(comandoSQL);
            DataTable tabla = new DataTable();
            adaptadorSQL.Fill(tabla);

            dgvProductos.DataSource = tabla;
            dgvProductos.AutoGenerateColumns = true;


            conexionDB.cerrar();

        }
        private void LimpiarCampos()
        {
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            cmbUnidadMedida.SelectedIndex = -1;
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
    
    
}
