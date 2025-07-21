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
    public partial class frmVerVentas : Form
    {
        public frmVerVentas()
        {
            InitializeComponent();
            CargarDetalleVentas();

        }
        private void CargarDetalleVentas()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
           

            string consulta = "SELECT DetalleVentas.idDetalleVenta, Productos.nombreProducto, DetalleCompras.cantidad, " +
                              "Productos.precioUnitario, Compras.totalPago, " +
                              "Clientes.nombreCliente, Usuarios.nombreUsuario " +
                              "FROM DetalleVentas " +
                              "JOIN Productos ON DetalleCompras.id_Producto = Productos.idProducto " +
                              "JOIN Clientes ON Compras.id_Cliente = Clientes.idCliente " +
                              "JOIN Compras ON DetalleCompras.id_Compra= Compras.idCompras"+
                              "JOIN Usuarios ON DetalleVentas.id_Usuario = Usuarios.idUsuario";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaDetalle = new DataTable();
            adaptador.Fill(tablaDetalle);

            dgvVerVentas.DataSource = tablaDetalle;

            conexionDB.cerrar();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDetalleVentas();


        }
    }
    }
