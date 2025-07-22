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
    public partial class frmControlFechas : Form
    {
        ConexionDB conexionDB = new ConexionDB();

        public frmControlFechas()
        {
            InitializeComponent();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexionDB.conexion.Open();

            string consulta = @"
                             SELECT 
                     Compras.idCompra AS 'ID Compra',
                     Clientes.nombreCliente AS 'Nombre Cliente',
                     Clientes.apellido AS 'Apellido Cliente',
                    Compras.fecha AS 'Fecha Venta',
                    Compras.tipoPago AS 'Tipo Pago',
                    Compras.totalPago AS 'Total Venta'
                        FROM Compras
                INNER JOIN Clientes ON Compras.id_Cliente = Clientes.idCliente
                WHERE Compras.fecha >= @fechaInicio AND Compras.fecha <= @fechaFin
            ";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            comando.Parameters.AddWithValue("@fechaInicio", dtpInicio.Value.Date);
            comando.Parameters.AddWithValue("@fechaFin", dtpFin.Value.Date);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            dvgResultados.DataSource = tabla;
            dvgResultados.AutoGenerateColumns = true;

            decimal totalVendido = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                totalVendido += Convert.ToDecimal(fila["Total Venta"]);
            }
            lblTotalVentas.Text = "Total Vendido: $" + totalVendido.ToString("0.00");

            conexionDB.cerrar();
        }


        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dvgResultados.DataSource = null;
            dtpInicio.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;

        }
    }
}

