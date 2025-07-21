using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Fromularios.Empleado
{
    public partial class frmGestionarProductos : Form
    {
        public frmGestionarProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProveedores();
            CargarUnidades();
            CargarTablaProductos();

        }
        public void CargarProductosPorId(string idProducto)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string consulta = "SELECT * FROM Productos WHERE idProducto = @id";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            comando.Parameters.AddWithValue("@id", idProducto);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                txtidProducto.Text = lector["id_Producto"].ToString();
                txtNombreProducto.Text = lector["nombreProducto"].ToString();
                txtPrecio.Text = lector["precioUnitario"].ToString();
                txtPeso.Text = lector["peso"].ToString();
                dtpFechaEntrada.Value = Convert.ToDateTime(lector["fechaEntrada"]);
                dtpFechaVencimiento.Value = Convert.ToDateTime(lector["fechaVencimiento"]);
            }

            lector.Close();
            conexionDB.cerrar();
        }
        private void CargarCategorias()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT idCategoria, nombreCategoria FROM Categorias", conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmbCategoria.DataSource = tabla;
            cmbCategoria.DisplayMember = "nombreCategoria";
            cmbCategoria.ValueMember = "idCategoria";

            conexionDB.cerrar();
        }

        private void CargarProveedores()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT idProveedor, nombreProveedor FROM Proveedores", conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmbProveedor.DataSource = tabla;
            cmbProveedor.DisplayMember = "nombreProveedor";
            cmbProveedor.ValueMember = "idProveedor";

            conexionDB.cerrar();
        }

        private void CargarUnidades()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT idUnidadMedida, nombreUnidad FROM UnidadMedida", conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmbIdUnidad.DataSource = tabla;
            cmbIdUnidad.DisplayMember = "nombreUnidad";
            cmbIdUnidad.ValueMember = "idUnidadMedida";

            conexionDB.cerrar();
        }

        private void CargarTablaProductos()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            string consulta = @"SELECT Productos.idProducto, Productos.nombreProducto, Productos.precioUnitario, Productos.peso,
                                       Productos.cantidadDisponible, Productos.fechaEntrada, Productos.fechaVencimiento,
                                       Categorias.nombreCategoria, Proveedores.nombreProveedor, UnidadMedida.nombreUnidad
                                FROM Productos
                                JOIN Categorias ON Productos.id_Categoria = Categorias.idCategoria
                                JOIN Proveedores ON Productos.id_Proveedor = Proveedores.idProveedor
                                JOIN UnidadMedida ON Productos.id_UnidadMedida = UnidadMedida.idUnidadMedida";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProductos.DataSource = tabla;

            conexionDB.cerrar();
        }


        private void frmGestionarProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProveedores();
            CargarUnidades();
            CargarTablaProductos();

        }
        public void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtPeso.Clear();
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now;
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbIdUnidad.SelectedIndex = -1;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string consulta = @"INSERT INTO Productos (nombreProducto, precioUnitario, peso, cantidadDisponible, fechaEntrada, fechaVencimiento, id_Categoria, id_Proveedor, id_UnidadMedida)
                                VALUES (@nombre, @precio, @peso, @cantidad, @entrada, @vencimiento, @categoria, @proveedor, @unidad)";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            comando.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
            comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
            comando.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
            comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
            comando.Parameters.AddWithValue("@entrada", dtpFechaEntrada.Value);
            comando.Parameters.AddWithValue("@vencimiento", dtpFechaVencimiento.Value);
            comando.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);
            comando.Parameters.AddWithValue("@proveedor", cmbProveedor.SelectedValue);
            comando.Parameters.AddWithValue("@unidad", cmbIdUnidad.SelectedValue);

            comando.ExecuteNonQuery();
            MessageBox.Show("Producto guardado correctamente.");
            CargarTablaProductos();
            btnLimpiar_Click(null, null);
            conexionDB.cerrar();
        }







        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            if (dgvProductos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["idProducto"].Value);
                string consulta = "DELETE FROM Productos WHERE idProducto = @id";

                SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto eliminado correctamente.");
                CargarTablaProductos();
                conexionDB.cerrar();
            }



        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            if (dgvProductos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["idProducto"].Value);

                string consulta = @"UPDATE Productos SET nombreProducto = @nombre, precioUnitario = @precio, peso = @peso,
                                    cantidadDisponible = @cantidad, fechaEntrada = @entrada, fechaVencimiento = @vencimiento,
                                    id_Categoria = @categoria, id_Proveedor = @proveedor, id_UnidadMedida = @unidad
                                    WHERE idProducto = @id";

                SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                comando.Parameters.AddWithValue("@peso", Convert.ToDecimal(txtPeso.Text));
                comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                comando.Parameters.AddWithValue("@entrada", dtpFechaEntrada.Value);
                comando.Parameters.AddWithValue("@vencimiento", dtpFechaVencimiento.Value);
                comando.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);
                comando.Parameters.AddWithValue("@proveedor", cmbProveedor.SelectedValue);
                comando.Parameters.AddWithValue("@unidad", cmbIdUnidad.SelectedValue);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente.");
                CargarTablaProductos();
                conexionDB.cerrar();
            }

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                txtNombreProducto.Text = fila.Cells["nombreProducto"].Value.ToString();
                txtPrecio.Text = fila.Cells["precioUnitario"].Value.ToString();
                txtPeso.Text = fila.Cells["peso"].Value.ToString();
                txtCantidad.Text = fila.Cells["cantidadDisponible"].Value.ToString();
                dtpFechaEntrada.Value = Convert.ToDateTime(fila.Cells["fechaEntrada"].Value);
                dtpFechaVencimiento.Value = Convert.ToDateTime(fila.Cells["fechaVencimiento"].Value);
                cmbCategoria.Text = fila.Cells["nombreCategoria"].Value.ToString();
                cmbProveedor.Text = fila.Cells["nombreProveedor"].Value.ToString();
                cmbIdUnidad.Text = fila.Cells["nombreUnidad"].Value.ToString();
            }
        }
    }

}
    
    
    

