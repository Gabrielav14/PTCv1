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

    public partial class frmReportesEmpleado : Form
    {

        public frmReportesEmpleado()
        {
            InitializeComponent();
            dtpInicio.Value = DateTime.Now.Date.AddMonths(-1);
            dtpFin.Value = DateTime.Now.Date;
            CargarTodasLasVentas();


        }
        public void CargarTodasLasVentas()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string consulta = @"
                SELECT 
                    DetalleVentas.id_Compra AS IdCompra,
                    Usuarios.nombreUsuario AS NombreUsuario,
                    Compras.fecha AS FechaVenta,
                    Compras.tipoPago AS TipoPago,
                    Compras.totalPago AS TotalPago
                FROM DetalleVentas
                INNER JoIN Usuarios ON DetalleVentas.id_Usuario = Usuarios.idUsuario
                INNER JOIN Compras ON DetalleVentas.id_Compra = Compras.idCompra
            ";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            dgvReportes.DataSource = tabla;

            conexionDB.cerrar();

            MostrarTotalVendido();
        }
        public void FiltrarVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            string consulta = @"
               
                    select
                        DetalleVentas.id_Compra AS IdCompra,
                        Compras.fecha AS FechaVenta,
                        Compras.tipoPago AS TipoPago, Compras.totalPago AS TotalPago
                        FROM DetalleVentas
                        INNER JOIN Compras ON DetalleVentas.id_Compra = Compras.idCompra
                WHERE Compras.fecha >= @fechaInicio AND Compras.fecha <= @fechaFin
            ";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            comando.Parameters.AddWithValue("@fechaFin", fechaFin);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            dgvReportes.DataSource = tabla;
            dgvReportes.AutoGenerateColumns = true;

            conexionDB.cerrar();

            MostrarTotalVendido();
        }

        private void MostrarTotalVendido()
        {
            decimal totalVendido = 0;

            foreach (DataGridViewRow fila in dgvReportes.Rows)
            {
                if (fila.Cells["TotalPago"].Value != DBNull.Value)
                {
                    totalVendido += Convert.ToDecimal(fila.Cells["TotalPago"].Value);
                }
            }

            lblTotal.Text = "Total vendido: $" + totalVendido.ToString("0.00");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarVentasPorFecha(dtpInicio.Value.Date, dtpFin.Value.Date);

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarTodasLasVentas();

        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

     




