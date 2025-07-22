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
    public partial class frmRegistrarEmpleado : Form
    {
          

        public frmRegistrarEmpleado()
        {
            InitializeComponent();
            CargarRol();
            MostrarEmpleados();

        }
        private void CargarRol()
        {
            cbRol.Items.Clear();
            cbRol.Items.Add("Empleado");
            cbRol.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            txtCorreo.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cbRol.SelectedIndex = 0;
        }
        private void MostrarEmpleados()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            

            string consulta = "SELECT idUsuario, nombreUsuario, correoElectronico, contraseña FROM Usuarios WHERE id_Rol = 32";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionDB.conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvEmpleados.DataSource = tabla;
            dgvEmpleados.AutoGenerateColumns = true;

            conexionDB.cerrar();
        }

        



        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            string nombreUsuario = txtUsuario.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;

            string insertar = "INSERT INTO Usuarios (nombreUsuario, correoElectronico, contraseña, id_Rol) " +
                              "VALUES (@nombreUsuario, @correoElectronico, @contraseña, @id_Rol)";

            SqlCommand comando = new SqlCommand(insertar, conexionDB.conexion);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@correoElectronico", correo);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            comando.Parameters.AddWithValue("@id_Rol", 32); // ID del rol 'Empleado'

            comando.ExecuteNonQuery();

            conexionDB.cerrar();

            MessageBox.Show("Empleado registrado correctamente");

            MostrarEmpleados();
            LimpiarCampos();
        }


        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["idUsuario"].Value);

                ConexionDB conexionDB = new ConexionDB();
                conexionDB.conexion.Open();
                SqlCommand comando = new SqlCommand("DELETE FROM Usuarios WHERE idUsuario = @id", conexionDB.conexion);
                comando.Parameters.AddWithValue("@id", idEmpleado);
                comando.ExecuteNonQuery();

                MessageBox.Show("Empleado eliminado correctamente.");
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccioná un empleado para eliminar.");
            }
        }

    }
}


