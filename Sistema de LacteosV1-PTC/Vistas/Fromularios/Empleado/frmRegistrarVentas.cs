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
using Vistas.Fromularios.Empleado;


namespace Vistas.Fromularios.Empleado
{
    public partial class frmRegistrarVentas : Form
    {
        List<Tuple<int, string, int, decimal>> carrito = new List<Tuple<int, string, int, decimal>>();
     
        decimal total = 0;
        

        public frmRegistrarVentas()
        {
            InitializeComponent();

            CargarProductos();
            cmbTipoPago.Items.Add("Efectivo");
            cmbTipoPago.Items.Add("Tarjeta");

        }
        private void CargarProductos()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            SqlCommand comando = new SqlCommand("SELECT idProducto, nombreProducto FROM Productos", conexionDB.conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cbProducto.Items.Add(new KeyValuePair<int, string>(
                    Convert.ToInt32(lector["idProducto"]),
                    lector["nombreProducto"].ToString()
                ));
            }

            cbProducto.DisplayMember = "Value";
            cbProducto.ValueMember = "Key";

            conexionDB.cerrar();
        }

        private void btnAgergar_Click(object sender, EventArgs e)
        {
            
            if (cbProducto.SelectedItem != null && nudCantidad.Value > 0)
            {
                var productoSeleccionado = (KeyValuePair<int, string>)cbProducto.SelectedItem;
                int idProducto = productoSeleccionado.Key;
                string nombreProducto = productoSeleccionado.Value;
                int cantidad = (int)nudCantidad.Value;

                ConexionDB conexionDB = new ConexionDB();
                conexionDB.conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT precioUnitario FROM Productos WHERE idProducto = @id", conexionDB.conexion);
                comando.Parameters.AddWithValue("@id", idProducto);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    decimal precio = Convert.ToDecimal(lector["precioUnitario"]);
                    carrito.Add(Tuple.Create(idProducto, nombreProducto, cantidad, precio));
                    total += cantidad * precio;
                    lblTotal.Text = "$" + total.ToString("0.00");
                    dvgCarrito.Columns.Clear();
                    dvgCarrito.Columns.Add("idProducto", "ID Producto");
                    dvgCarrito.Columns.Add("nombreProducto", "Nombre Producto");
                    dvgCarrito.Columns.Add("cantidad", "Cantidad");
                    dvgCarrito.Columns.Add("precio", "Precio");
                    dvgCarrito.Rows.Add(nombreProducto, cantidad, "$" + precio.ToString("0.00"), "$" + (cantidad * precio).ToString("0.00"));
                }

                conexionDB.cerrar();
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0 || cmbTipoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe agregar productos y seleccionar tipo de pago.");
                return;
            }

           
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            SqlCommand insertarCliente = new SqlCommand("insert into Clientes (nombreCliente, apellido, correoElectronicoClien, dui, direccion, telefono) VALUES (@nombre, @apellido, @correo, @dui, @direccion, @telefono); Select Scope_Identity();", conexionDB.conexion);
            insertarCliente.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
            insertarCliente.Parameters.AddWithValue("@apellido", txtApellido.Text);
            insertarCliente.Parameters.AddWithValue("@correo", txtCorreo.Text);
            insertarCliente.Parameters.AddWithValue("@dui", mtbDui.Text);
            insertarCliente.Parameters.AddWithValue("@direccion", txtDireccion.Text);
            insertarCliente.Parameters.AddWithValue("@telefono", mtbTelefono.Text);

            int idCliente = Convert.ToInt32(insertarCliente.ExecuteScalar());

            
            SqlCommand insertarCompra = new SqlCommand("insert into Compras (totalPago, tipoPago, id_Cliente) VALUES (@total, @tipo, @cliente); Select Scope_Identity();", conexionDB.conexion);
            insertarCompra.Parameters.AddWithValue("@total", total);
            insertarCompra.Parameters.AddWithValue("@tipo", cmbTipoPago.SelectedItem.ToString());
            insertarCompra.Parameters.AddWithValue("@cliente", idCliente);

            int idCompra = Convert.ToInt32(insertarCompra.ExecuteScalar());

          
            foreach (var item in carrito)
            {
                SqlCommand detalleCompra = new SqlCommand("insert into DetalleCompras (cantidad, id_Compra, id_Producto) VALUES (@cantidad, @compra, @producto)", conexionDB.conexion);
                detalleCompra.Parameters.AddWithValue("@cantidad", item.Item3);
                detalleCompra.Parameters.AddWithValue("@compra", idCompra);
                detalleCompra.Parameters.AddWithValue("@producto", item.Item1);
                detalleCompra.ExecuteNonQuery();
            }

            
            SqlCommand detalleVenta = new SqlCommand("insert into DetalleVentas (id_Compra) VALUES (@compra)", conexionDB.conexion);
            detalleVenta.Parameters.AddWithValue("@compra", idCompra);
           
            detalleVenta.ExecuteNonQuery();

            conexionDB.cerrar();

           
            string resumen = "**VENTA REGISTRADA*\nCliente: " + txtNombreCliente.Text + " " + txtApellido.Text +
                             "\nDUI: " + mtbDui.Text + "\nDirección: " + txtDireccion.Text + "\nCorreo: " + txtCorreo.Text +
                             "\nTeléfono: " + mtbTelefono.Text + "\n\nProductos:\n";

            foreach (var item in carrito)
            {
                resumen += "- " + item.Item2 + " x" + item.Item3 + " = $" + (item.Item3 * item.Item4).ToString("0.00") + "\n";
            }

            resumen += "\nTotal: $" + total.ToString("0.00") + "\nTipo de Pago: " + cmbTipoPago.SelectedItem.ToString();

            MessageBox.Show(resumen, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);


            
            carrito.Clear();
            dvgCarrito.Rows.Clear();
            lblTotal.Text = "$0.00";

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtApellido.Controls.Clear();
            txtDireccion.Controls.Clear();
            txtCorreo.Controls.Clear();
            txtNombreCliente.Controls.Clear();
            mtbDui.Controls.Clear();
            mtbTelefono.Controls.Clear();
        }

        private void frmRegistrarVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
