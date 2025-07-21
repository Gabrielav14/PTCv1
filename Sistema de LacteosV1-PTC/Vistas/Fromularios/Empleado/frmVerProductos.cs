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

namespace Vistas.Fromularios.Empleado
{
    public partial class frmVerProductos : Form
    {
        public frmVerProductos()
        {
            InitializeComponent();
        }

        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string consulta = "SELECT idProducto, nombreProducto, precioUnitario, peso, fechaEntrada, fechaVencimiento FROM Productos";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaProductos = new DataTable();

            adaptador.Fill(tablaProductos);

            dvgVerProductos.DataSource = tablaProductos;

            conexionDB.cerrar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string textoBusqueda = txtBuscar.Text.Trim();
            string consulta = "";

            if (int.TryParse(textoBusqueda, out int idProducto))
            {
                
                consulta = "SELECT p.idProducto, p.nombreProducto, p.precioUnitario, p.peso, p.fechaEntrada, p.fechaVencimiento, " +
                           "c.nombreCategoria, pr.nombreProveedor, u.nombreUnidad " +
                           "FROM Productos p " +
                           "INNER JOIN Categorias c ON p.id_Categoria = c.idCategoria " +
                           "INNER JOIN Proveedores pr ON p.id_Proveedor = pr.idProveedor " +
                           "INNER JOIN UnidadMedida u ON p.id_UnidadMedida = u.idUnidadMedida " +
                           "WHERE p.idProducto = @dato";
            }
            else
            {
                consulta = "SELECT p.idProducto, p.nombreProducto, p.precioUnitario, p.peso, p.fechaEntrada, p.fechaVencimiento, " +
                           "c.nombreCategoria, pr.nombreProveedor, u.nombreUnidad " +
                           "FROM Productos p " +
                           "INNER JOIN Categorias c ON p.id_Categoria = c.idCategoria " +
                           "INNER JOIN Proveedores pr ON p.id_Proveedor = pr.idProveedor " +
                           "INNER JOIN UnidadMedida u ON p.id_UnidadMedida = u.idUnidadMedida " +
                           "WHERE p.nombreProducto LIKE '%' + @dato + '%'";
            }

            SqlCommand comandoBuscar = new SqlCommand(consulta, conexionDB.conexion);
            comandoBuscar.Parameters.AddWithValue("@dato", textoBusqueda);

            SqlDataAdapter adaptadorBusqueda = new SqlDataAdapter(comandoBuscar);
            DataTable tablaResultado = new DataTable();

            adaptadorBusqueda.Fill(tablaResultado);
            dvgVerProductos.AutoGenerateColumns = true;
            dvgVerProductos.DataSource = tablaResultado;

            conexionDB.cerrar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dvgVerProductos.SelectedRows.Count > 0)
            {
                string idProducto = dvgVerProductos.CurrentRow.Cells["idProducto"].Value.ToString();
                frmGestionarProductos formulario = new frmGestionarProductos();

                formulario.CargarProductosPorId(idProducto); 

                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccioná un producto para editar");
            }

        }
    }
}
