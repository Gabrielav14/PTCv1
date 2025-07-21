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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void dgvReportesEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            CargarDetalleVentas();

        }
        private void CargarDetalleVentas()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
           
            string consulta = "SELECT DetalleVentas.idDetalleVenta, DetalleVentas.id_Compra, Usuarios.nombreUsuario " +
                              "FROM DetalleVentas " +
                              "JOIN Usuarios ON DetalleVentas.id_Usuario = Usuarios.idUsuario";

            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tablaVentas = new DataTable();
            adaptador.Fill(tablaVentas);

            dgvReportesEmpleados.DataSource = tablaVentas;

            
            dgvReportesEmpleados.Columns["idDetalleVenta"].HeaderText = "ID Venta";
            dgvReportesEmpleados.Columns["id_Compra"].HeaderText = "ID Compra";
            dgvReportesEmpleados.Columns["nombreUsuario"].HeaderText = "Empleado que Vendió";

            conexionDB.cerrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDetalleVentas();

        }
    }
}
