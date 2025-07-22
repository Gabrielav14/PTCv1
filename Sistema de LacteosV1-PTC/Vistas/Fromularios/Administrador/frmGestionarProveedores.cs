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
    public partial class frmGestionarProveedores : Form
    {
        public frmGestionarProveedores()
        {
            InitializeComponent();
        }
        private void MostrarProveedores()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

           
            string consulta = "SELECT idProveedor, nombreEmpresa, nombreProveedor, correoElectronico, telefono, fechaIngreso FROM Proveedores";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionDB.conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvProveedores.DataSource = tabla;
            dgvProveedores.AutoGenerateColumns = true;

            conexionDB.cerrar();
        }

        private void LimpiarCampos()
        {
            txtNombreEmpresa.Text = "";
            txtNombreProveedor.Text = "";
            txtCorreo.Text = "";
            mtbTelefono.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
        }


        private void frmGestionarProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            string consulta = "INSERT INTO Proveedores (nombreEmpresa, nombreProveedor, correoElectronico, telefono, fechaIngreso) VALUES (@empresa, @proveedor, @correo, @telefono, @fecha)";
            SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
            comando.Parameters.AddWithValue("@empresa", txtNombreEmpresa.Text);
            comando.Parameters.AddWithValue("@proveedor", txtNombreProveedor.Text);
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
            comando.Parameters.AddWithValue("@telefono", mtbTelefono.Text);
            comando.Parameters.AddWithValue("@fecha", dtpFechaIngreso.Value);

            comando.ExecuteNonQuery();
            conexionDB.cerrar();

            MessageBox.Show("Proveedor agregado correctamente.");
            MostrarProveedores();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

