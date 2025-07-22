using Modelos.Conexion;
using Modelos.Entidades;
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
        ConexionDB conexionDB = new ConexionDB();
        
        public frmVerVentas()
        {
            InitializeComponent();
            CargarDetalleVentas();

        }
        public void CargarDetalleVentas()
        {
            
            conexionDB.conexion.Open();


            string consulta = "select idCompra, nombreCliente as Cliente, apellido as Apellido, fecha as Fecha, tipoPago, totalPago from DetalleVentas " +
                             "inner join Compras on DetalleVentas.id_Compra = Compras.idCompra " +
                             "inner join Clientes on Compras.id_Cliente = Clientes.idCliente";

            SqlCommand comandoSQL = new SqlCommand(consulta, conexionDB.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvVerVentas.DataSource = tabla;

            conexionDB.cerrar();
        }

        


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            CargarDetalleVentas();

        }
    }
    }
