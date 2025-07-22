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
using Vistas.Fromularios.Administrador;

namespace Vistas.Fromularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();

            SqlCommand comando = new SqlCommand("SELECT nombreUsuario, correoElectronico, contraseña, id_Rol FROM Usuarios WHERE nombreUsuario = @usuario AND correoElectronico = @correo AND contraseña = @contraseña", conexionDB.conexion);
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
            comando.Parameters.AddWithValue("@contraseña", txtContra.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                string nombre = lector["nombreUsuario"].ToString();
                string rol = lector["id_Rol"].ToString();
                

                MessageBox.Show("Bienvenido " + nombre );

                if (rol == "31") 
                {
                    frmDashboardAdmin admin = new frmDashboardAdmin();
                    admin.Show();
                    this.Hide();
                }
                

                else if (rol == "32") 
                {
                    frmDashboardEmpleado empleado = new frmDashboardEmpleado();
                    empleado.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido.");
                }
            }
            else
            {
                MessageBox.Show("Usuario, correo o contraseña incorrectos.");
            }

            conexionDB.cerrar();

        }
    }
}
